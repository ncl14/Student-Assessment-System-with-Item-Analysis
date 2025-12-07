using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis
{
    public static class modProcedureVariable
    {
        public static bool fncConnectToDatabase()
        {
            try
            {
                modVariables.servername = "localhost";
                modVariables.dbname = "studentasessment";
                modVariables.username = "root";
                modVariables.password = "";
                modVariables.port = "3306";

                modVariables.strConnection =
                    $"SERVER={modVariables.servername};DATABASE={modVariables.dbname};UID={modVariables.username};PWD={modVariables.password};PORT={modVariables.port};";

                modVariables.conDbInformation = new MySqlConnection(modVariables.strConnection);
                modVariables.conDbInformation.Open();

                modVariables.command = new MySqlCommand();
                modVariables.command.Connection = modVariables.conDbInformation;
                modVariables.command.CommandTimeout = 20 * 60;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
                return false;
            }
        }

        public static void checkDatabaseConnection()
        {
            if (modVariables.conDbInformation == null ||
                modVariables.conDbInformation.State == System.Data.ConnectionState.Closed)
            {
                fncConnectToDatabase();
            }
        }
    }
}
