using MySql.Data.MySqlClient;

namespace Student_Assessment_System_with_Item_Analysis
{
    public static class modVariables
    {
        public static string servername;
        public static string username;
        public static string password;
        public static string port;
        public static string dbname;
        public static string strConnection;

        public static MySqlConnection conDbInformation;
        public static MySqlCommand command;
    }
}
