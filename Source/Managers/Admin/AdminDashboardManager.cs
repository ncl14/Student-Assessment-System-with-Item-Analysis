using Student_Assessment_System_with_Item_Analysis.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers.Admin
{
    public class AdminDashboardManager
    {
        // 1. Get Total Users Count
        public int GetTotalUsers()
        {
            // Use try-catch to return 0 instead of crashing if DB fails
            try
            {
                using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
                {
                    conn.Open();
                    // Counts only active users
                    string query = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        // ExecuteScalar returns the first column of the first row (the count)
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception)
            {
                return 0; // Return 0 if connection fails
            }
        }

        // 2. Get Total Subjects Count
        public int GetTotalSubjects()
        {
            try
            {
                using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Subjects";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception)
            {
                // If the table doesn't exist yet or DB is down, return 0
                return 0;
            }
        }

        // 3. Get Recent Activity (Loads Recent Users into the Grid)
        public DataTable GetRecentActivity()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
                {
                    conn.Open();

                    string query = @"
    SELECT TOP 10 
        r.Title AS [ReportTitle], 
        s.SubjectName AS [Subject], 
        r.CreatedDate AS [Date], 
        r.Status AS [Status], 
        u.Username AS [GeneratedBy]
    FROM Reports r
    INNER JOIN Subjects s ON r.SubjectID = s.SubjectID
    INNER JOIN Users u ON r.UserID = u.UserID
    ORDER BY r.CreatedDate DESC";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If the table doesn't exist yet, this prevents a crash
                Console.WriteLine("Error loading reports: " + ex.Message);
            }

            return dt;
        }
    }
}