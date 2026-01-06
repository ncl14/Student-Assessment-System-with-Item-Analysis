using Student_Assessment_System_with_Item_Analysis.Database;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers.Admin
{
    public class AdminDashboardManager
    {
        // Get Total Users count
        public int GetTotalUsers()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";
                using (var cmd = new SqlCommand(query, conn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        // Get Total Subjects count (Make sure you have a Subjects table!)
        public int GetTotalSubjects()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                conn.Open();
                // Check if Subjects table exists first, otherwise return 0 to avoid crash
                try
                {
                    string query = "SELECT COUNT(*) FROM Subjects";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        return (int)cmd.ExecuteScalar();
                    }
                }
                catch { return 0; }
            }
        }

        // UPDATED: Get Recent Activity for DataGridView
        public DataTable GetRecentActivity()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                conn.Open();
                // UPDATED SQL: Uses UserName, FirstName, LastName, UserRole
                string query = "SELECT TOP 5 UserName, FirstName, LastName, UserRole, CreatedAt FROM Users ORDER BY CreatedAt DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }
    }
}