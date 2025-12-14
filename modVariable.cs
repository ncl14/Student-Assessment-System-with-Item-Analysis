using System.Data.SqlClient; // Import this namespace

namespace Student_Assessment_System_with_Item_Analysis
{
    class modVariable
    {
        // Change MySqlConnection to SqlConnection
        public static SqlConnection conDbInformation;

        // Change MySqlCommand to SqlCommand
        public static SqlCommand command;

        // You can keep these if you still want to build the string manually, 
        // but for LocalDB, the hardcoded string in the code above is often safer.
        public static string servername;
        public static string dbname;
        public static string username;
        public static string password;
        public static string port;
        public static string strConnection;
    }
}