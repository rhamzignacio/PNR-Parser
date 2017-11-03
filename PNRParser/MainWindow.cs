using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PNRParser.Service;
using k1aHostToolKit;
using s1aPNR;
using System.IO;

namespace PNRParser
{
    public partial class MainWindow : Form
    {
        //For menu border style
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        HostSession objSession = new HostSession();

        PNR objPNR = new PNR();

        private void MenuMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        public void Success(string message)
        {
            lblMessage.Text = message;

            panelBottom.BackColor = Color.FromArgb(43, 87, 154);

            lblMessage.Refresh();

            panelBottom.Refresh();
        }

        public void Normal(string message = "Connected: ")
        {
            if (message == "Connected: ")
                message += PNRParser.Properties.Settings.Default.database;

            lblMessage.Text = message;

            panelBottom.BackColor = Color.FromArgb(43, 87, 154);

            lblMessage.Refresh();

            panelBottom.Refresh();
        }

        public void Error(string message)
        {
            lblMessage.Text = message;

            panelBottom.BackColor = Color.Red;

            panelBottom.Refresh();

            lblMessage.Refresh();
        }

        private void CheckDatabase()
        {
            if(Properties.Settings.Default.dbType == "ACCESS")
            {
                if (PNRParser.Properties.Settings.Default.database == "")
                {
                    Error("Please configure database connection");
                }
                else
                {
                    Normal();
                }
            }
            else
            {
                Normal("Connected to 192.168.0.6");
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            CheckDatabase();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }     

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Text = "";

            string mainOutput = "****ITINERARY INFORMATION****";

            Normal("Retrieving PNR Information . . .");

            if (!checkBoxItineraryWithPax.Checked && !checkBoxContact.Checked && !checkBoxRemarks.Checked)
            {
                Error("PNR Element must not be empty");
            }
            else
            {
                objSession = new HostSession();

                objPNR = new PNR();

                var objResponse = objSession.Send("RT" + txtBoxRecordLocator.Text);

                objPNR.RetrieveCurrent(objSession);

                var temp = objResponse.GetLineFromBuffer(1);

                var code = temp.Split(' ');

                var tempCode = code[0].ToString();

                if (tempCode == "SECURED" || tempCode == "INVALID" || tempCode == "IGNORED" || tempCode == "TRANSACTION"
                    || tempCode == "ENTRY" || tempCode == "FUNCITON")
                {
                    objSession.Send("IG");

                    Error("Invalid Entry. . . Please try again");
                }
                else if (tempCode == "INACTIVITY")
                {
                    objSession.Send("IG");

                    Error("Inactivity Time Out, Please sign in again");
                }
                else if (tempCode == "SIGN")
                {
                    objSession.Send("IG");

                    Error("Please Sign in");
                }
                else if (tempCode == "NO")
                {
                    objSession.Send("IG");

                    Error("No match for record locator");
                }
                else
                {
                    mainOutput += "\n\n" + "AMADEUS REF NO:" + objPNR.Header.recordLocator;

                    mainOutput += "\n" +  AmadeusDLL.GetAirlineRecord(objPNR, objSession);

                    //Itinerary With PAX
                    if (checkBoxItineraryWithPax.Checked)
                    {
                        if(AmadeusDLL.GetPax(objPNR, objSession) != "")
                        {
                            mainOutput += "\n\n" + "Passenger(s):\n" + AmadeusDLL.GetPaxTicket(objPNR, objSession, this);

                            mainOutput += "\n\n" + AmadeusDLL.GetItineraryInfo(objPNR, objSession, checkBoxBaggage.Checked);
                        }
                    }
                    //Contact

                    if (checkBoxContact.Checked)
                    {
                        if(AmadeusDLL.GetContactInfo(objPNR, objSession) != "")
                        {
                            mainOutput += "\n\nContact Info(s):\n" + AmadeusDLL.GetContactInfo(objPNR, objSession);
                        }
                    }

                    if (checkBoxRemarks.Checked)
                    {
                        if(AmadeusDLL.GetRemarks(objPNR, objSession) != "")
                        {
                            mainOutput += "\n\nRemark(s):\n" + AmadeusDLL.GetRemarks(objPNR, objSession);
                        }
                    }

                }

                richTxtBoxResult.Text = mainOutput;

                Normal();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Microsoft Access Database(*.accdb)|*.accdb";

            file.FilterIndex = 1;

            if (file.ShowDialog() == DialogResult.OK)
            {
                PNRParser.Properties.Settings.Default.database = file.FileName;

                PNRParser.Properties.Settings.Default.Save();

                CheckDatabase();
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                checkBoxRemarks.Checked = checkBoxContact.Checked = checkBoxItineraryWithPax.Checked = true;
            }
            else
            {
                checkBoxRemarks.Checked = checkBoxContact.Checked = checkBoxItineraryWithPax.Checked = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTxtBoxResult.Text = txtBoxRecordLocator.Text = "";
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_tick_blank;
            }
            else
            {
                WindowState = FormWindowState.Maximized;

                btnMaximized.Image = null;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_duplicate;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_duplicate;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Normal;

                btnMaximized.BackgroundImage = Properties.Resources.rsz_tick_blank;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (richTxtBoxResult.Text == "")
                Error("No data to save");
            else
            {
                var saveDialog = new SaveFileDialog();

                saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                saveDialog.FilterIndex = 2;

                if(saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName + ".txt", richTxtBoxResult.Text);
                }
            }
        }

        private void btnMSAccess_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbType = "ACCESS";

            Properties.Settings.Default.Save();

            panelDBSelection.Hide();

            CheckDatabase();
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dbType = "SERVER";

            Properties.Settings.Default.Save();

            panelDBSelection.Hide();

            CheckDatabase();
        }

        private void pictureBoxDatabaseSelection_Click(object sender, EventArgs e)
        {
            panelDBSelection.Show();
        }

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MenuMove(e);
        }

        private void pictureBoxCopy_Click(object sender, EventArgs e)
        {
            if (richTxtBoxResult.Text != "")
            {
                Clipboard.SetText(richTxtBoxResult.Text);

                Success("Result is now ready for Pasting");
            }
            else
            {
                Error("No result found");
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            CheckDatabase();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var testConnection = new HostSessions();

            if (testConnection.Count == 0)
                Error("Amadeus Selling Platform is not Started");
        }
    }
}
