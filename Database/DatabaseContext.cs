using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Database
{
    public static class DatabaseContext
    {
        public static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentAssessmentDB;Integrated Security=True;";
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["StudentAssessmentDB"]
                ?.ConnectionString;

            if (string.IsNullOrEmpty(connString))
            {
                throw new InvalidOperationException(
                    "Database connection string 'StudentAssessmentDB' not found."
                );
            }

            return new SqlConnection(connString);
        }
    }
}