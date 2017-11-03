namespace PNRParser
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
            this.pictureBoxDatabaseSelection = new System.Windows.Forms.PictureBox();
            this.pictureBoxDatabase = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.richTxtBoxResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBaggage = new System.Windows.Forms.CheckBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.checkBoxRemarks = new System.Windows.Forms.CheckBox();
            this.checkBoxContact = new System.Windows.Forms.CheckBox();
            this.checkBoxItineraryWithPax = new System.Windows.Forms.CheckBox();
            this.txtBoxRecordLocator = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDBSelection = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSQLServer = new System.Windows.Forms.Button();
            this.btnMSAccess = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDBSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label3.Location = new System.Drawing.Point(520, 490);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 13);
            label3.TabIndex = 16;
            label3.Text = "Enter Record Locator";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label5.Location = new System.Drawing.Point(47, 103);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(61, 13);
            label5.TabIndex = 21;
            label5.Text = "MS Access";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label6.Location = new System.Drawing.Point(150, 103);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 13);
            label6.TabIndex = 22;
            label6.Text = "SQL Server";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.topPanel.Controls.Add(this.pictureBoxCopy);
            this.topPanel.Controls.Add(this.pictureBoxDatabaseSelection);
            this.topPanel.Controls.Add(this.pictureBoxDatabase);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.btnMaximized);
            this.topPanel.Controls.Add(this.lblHeader);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(870, 23);
            this.topPanel.TabIndex = 8;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // pictureBoxCopy
            // 
            this.pictureBoxCopy.Image = global::PNRParser.Properties.Resources.preview;
            this.pictureBoxCopy.Location = new System.Drawing.Point(82, 0);
            this.pictureBoxCopy.Name = "pictureBoxCopy";
            this.pictureBoxCopy.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCopy.TabIndex = 24;
            this.pictureBoxCopy.TabStop = false;
            this.pictureBoxCopy.Click += new System.EventHandler(this.pictureBoxCopy_Click);
            // 
            // pictureBoxDatabaseSelection
            // 
            this.pictureBoxDatabaseSelection.Image = global::PNRParser.Properties.Resources.inventory;
            this.pictureBoxDatabaseSelection.Location = new System.Drawing.Point(54, 0);
            this.pictureBoxDatabaseSelection.Name = "pictureBoxDatabaseSelection";
            this.pictureBoxDatabaseSelection.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxDatabaseSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDatabaseSelection.TabIndex = 23;
            this.pictureBoxDatabaseSelection.TabStop = false;
            this.pictureBoxDatabaseSelection.Click += new System.EventHandler(this.pictureBoxDatabaseSelection_Click);
            // 
            // pictureBoxDatabase
            // 
            this.pictureBoxDatabase.Image = global::PNRParser.Properties.Resources.searchFilter;
            this.pictureBoxDatabase.Location = new System.Drawing.Point(27, 0);
            this.pictureBoxDatabase.Name = "pictureBoxDatabase";
            this.pictureBoxDatabase.Size = new System.Drawing.Size(25, 21);
            this.pictureBoxDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDatabase.TabIndex = 22;
            this.pictureBoxDatabase.TabStop = false;
            this.pictureBoxDatabase.Click += new System.EventHandler(this.pictureBoxDatabase_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PNRParser.Properties.Resources.diskette;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.BackgroundImage = global::PNRParser.Properties.Resources.rsz_tick_blank;
            this.btnMaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximized.ForeColor = System.Drawing.Color.White;
            this.btnMaximized.Location = new System.Drawing.Point(800, 1);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(35, 23);
            this.btnMaximized.TabIndex = 5;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(376, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(99, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "PNR Parser";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(765, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 23);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(835, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // richTxtBoxResult
            // 
            this.richTxtBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBoxResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxResult.Location = new System.Drawing.Point(16, 65);
            this.richTxtBoxResult.Name = "richTxtBoxResult";
            this.richTxtBoxResult.Size = new System.Drawing.Size(834, 410);
            this.richTxtBoxResult.TabIndex = 9;
            this.richTxtBoxResult.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Flight Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.checkBoxBaggage);
            this.groupBox1.Controls.Add(this.checkBoxAll);
            this.groupBox1.Controls.Add(this.checkBoxRemarks);
            this.groupBox1.Controls.Add(this.checkBoxContact);
            this.groupBox1.Controls.Add(this.checkBoxItineraryWithPax);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(59, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Element(s)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxBaggage
            // 
            this.checkBoxBaggage.AutoSize = true;
            this.checkBoxBaggage.Location = new System.Drawing.Point(337, 22);
            this.checkBoxBaggage.Name = "checkBoxBaggage";
            this.checkBoxBaggage.Size = new System.Drawing.Size(111, 17);
            this.checkBoxBaggage.TabIndex = 14;
            this.checkBoxBaggage.Text = "w/ 40kg baggage";
            this.checkBoxBaggage.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(267, 22);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAll.TabIndex = 12;
            this.checkBoxAll.Text = "Select All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // checkBoxRemarks
            // 
            this.checkBoxRemarks.AutoSize = true;
            this.checkBoxRemarks.Location = new System.Drawing.Point(193, 22);
            this.checkBoxRemarks.Name = "checkBoxRemarks";
            this.checkBoxRemarks.Size = new System.Drawing.Size(68, 17);
            this.checkBoxRemarks.TabIndex = 13;
            this.checkBoxRemarks.Text = "Remarks";
            this.checkBoxRemarks.UseVisualStyleBackColor = true;
            // 
            // checkBoxContact
            // 
            this.checkBoxContact.AutoSize = true;
            this.checkBoxContact.Location = new System.Drawing.Point(124, 22);
            this.checkBoxContact.Name = "checkBoxContact";
            this.checkBoxContact.Size = new System.Drawing.Size(63, 17);
            this.checkBoxContact.TabIndex = 12;
            this.checkBoxContact.Text = "Contact";
            this.checkBoxContact.UseVisualStyleBackColor = true;
            // 
            // checkBoxItineraryWithPax
            // 
            this.checkBoxItineraryWithPax.AutoSize = true;
            this.checkBoxItineraryWithPax.Checked = true;
            this.checkBoxItineraryWithPax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItineraryWithPax.Location = new System.Drawing.Point(18, 22);
            this.checkBoxItineraryWithPax.Name = "checkBoxItineraryWithPax";
            this.checkBoxItineraryWithPax.Size = new System.Drawing.Size(100, 17);
            this.checkBoxItineraryWithPax.TabIndex = 0;
            this.checkBoxItineraryWithPax.Text = "Itinerary w/ Pax";
            this.checkBoxItineraryWithPax.UseVisualStyleBackColor = true;
            // 
            // txtBoxRecordLocator
            // 
            this.txtBoxRecordLocator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxRecordLocator.Location = new System.Drawing.Point(523, 506);
            this.txtBoxRecordLocator.MaxLength = 6;
            this.txtBoxRecordLocator.Name = "txtBoxRecordLocator";
            this.txtBoxRecordLocator.Size = new System.Drawing.Size(106, 20);
            this.txtBoxRecordLocator.TabIndex = 15;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRetrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetrieve.ForeColor = System.Drawing.Color.White;
            this.btnRetrieve.Location = new System.Drawing.Point(648, 500);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(89, 20);
            this.btnRetrieve.TabIndex = 17;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = false;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(743, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 20);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panelBottom.Controls.Add(this.lblMessage);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 548);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(870, 20);
            this.panelBottom.TabIndex = 20;
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(3, 3);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(658, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Error Message";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(813, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "2.3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelDBSelection
            // 
            this.panelDBSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDBSelection.Controls.Add(label6);
            this.panelDBSelection.Controls.Add(label5);
            this.panelDBSelection.Controls.Add(this.label2);
            this.panelDBSelection.Controls.Add(this.btnSQLServer);
            this.panelDBSelection.Controls.Add(this.btnMSAccess);
            this.panelDBSelection.Location = new System.Drawing.Point(310, 194);
            this.panelDBSelection.Name = "panelDBSelection";
            this.panelDBSelection.Size = new System.Drawing.Size(251, 134);
            this.panelDBSelection.TabIndex = 21;
            this.panelDBSelection.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Database Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSQLServer
            // 
            this.btnSQLServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSQLServer.BackColor = System.Drawing.Color.Transparent;
            this.btnSQLServer.BackgroundImage = global::PNRParser.Properties.Resources.download;
            this.btnSQLServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQLServer.ForeColor = System.Drawing.Color.White;
            this.btnSQLServer.Location = new System.Drawing.Point(137, 45);
            this.btnSQLServer.Name = "btnSQLServer";
            this.btnSQLServer.Size = new System.Drawing.Size(89, 55);
            this.btnSQLServer.TabIndex = 19;
            this.btnSQLServer.UseVisualStyleBackColor = false;
            this.btnSQLServer.Click += new System.EventHandler(this.btnSQLServer_Click);
            // 
            // btnMSAccess
            // 
            this.btnMSAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMSAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnMSAccess.BackgroundImage = global::PNRParser.Properties.Resources.Microsoft_Access_2013_logo_svg;
            this.btnMSAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMSAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMSAccess.ForeColor = System.Drawing.Color.White;
            this.btnMSAccess.Location = new System.Drawing.Point(29, 45);
            this.btnMSAccess.Name = "btnMSAccess";
            this.btnMSAccess.Size = new System.Drawing.Size(89, 55);
            this.btnMSAccess.TabIndex = 18;
            this.btnMSAccess.UseVisualStyleBackColor = false;
            this.btnMSAccess.Click += new System.EventHandler(this.btnMSAccess_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(870, 568);
            this.Controls.Add(this.panelDBSelection);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtBoxRecordLocator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtBoxResult);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabaseSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelDBSelection.ResumeLayout(false);
            this.panelDBSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTxtBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxItineraryWithPax;
        private System.Windows.Forms.CheckBox checkBoxRemarks;
        private System.Windows.Forms.CheckBox checkBoxContact;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.TextBox txtBoxRecordLocator;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxDatabase;
        private System.Windows.Forms.PictureBox pictureBoxDatabaseSelection;
        private System.Windows.Forms.Panel panelDBSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSQLServer;
        private System.Windows.Forms.Button btnMSAccess;
        private System.Windows.Forms.PictureBox pictureBoxCopy;
        private System.Windows.Forms.CheckBox checkBoxBaggage;
    }
}