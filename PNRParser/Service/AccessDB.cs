using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PNRParser.Service
{
    public class AccessDB
    {
        public static string ConvertAirlineCode(string input)
        {
            string returnVal = "";

            OleDbConnection dbConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                PNRParser.Properties.Settings.Default.database + "; Persist Security Info=True;");

            dbConn.Open();

            var dbCommand = new OleDbCommand("Select * from AIRLINENAME where AirlineCode ='" + input + "'", dbConn);

            var dbRead = dbCommand.ExecuteReader();

            while (dbRead.Read())
            {
                returnVal = dbRead["AirlineName"].ToString();
            }

            dbConn.Close();

            return returnVal;
        }

        public static string ConvertCityCode(string input)
        {
            string returnVal = "";

            OleDbConnection dbConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                PNRParser.Properties.Settings.Default.database + "; Persist Security Info=True;");

            dbConn.Open();

            var dbCommand = new OleDbCommand("Select * from AIRPORT where CITY_CODE ='" + input + "'", dbConn);

            var dbRead = dbCommand.ExecuteReader();

            while (dbRead.Read())
            {
                returnVal = dbRead["CITY_DESCR"].ToString();
            }

            dbConn.Close();

            return returnVal;
        }
    }
}
