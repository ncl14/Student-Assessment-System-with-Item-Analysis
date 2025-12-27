using System;
using System.Data.SqlClient;
using System.Configuration;

namespace Student_Assessment_System_with_Item_Analysis.Database
{
    public class DatabaseContext
    {
        public static SqlConnection GetConnection()
        {
            // Read connection string 'StudentAssessmentDb' but fall back to 'MyConn' for backward compatibility with existing config
            string connStr = ConfigurationManager.ConnectionStrings["StudentAssessmentDb"]?.ConnectionString
                             ?? ConfigurationManager.ConnectionStrings["MyConn"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connStr))
                throw new InvalidOperationException("Connection string 'StudentAssessmentDb' or 'MyConn' not found. Add it to app.config under <connectionStrings>.");

            return new SqlConnection(connStr);
        }
    }
}
