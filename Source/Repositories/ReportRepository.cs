using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{
    public class ReportRepository
    {
        // USE YOUR COPIED CONNECTION STRING HERE
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAssessmentDB;Integrated Security=True";

        public List<ReportViewModel> GetAllReports()
        {
            var list = new List<ReportViewModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // EXAMPLE QUERY - Adjust table names to match your DB!
                // If you don't have a 'Reports' table yet, create one or join Assessments + Users
                string query = @"
                    SELECT 
                        r.ReportID, 
                        r.ReportTitle AS Title, 
                        s.SubjectName AS Subject, 
                        u.Username AS GeneratedBy, 
                        u.UserRole AS Role, 
                        r.Status, 
                        r.CreatedAt AS DateCreated
                    FROM Reports r
                    INNER JOIN Users u ON r.UserID = u.UserID
                    LEFT JOIN Subjects s ON r.SubjectID = s.SubjectID
                    ORDER BY r.CreatedAt DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            list.Add(new ReportViewModel
                            {
                                ReportID = Convert.ToInt32(reader["ReportID"]),
                                Title = reader["Title"].ToString(),
                                Subject = reader["Subject"].ToString(),
                                GeneratedBy = reader["GeneratedBy"].ToString(),
                                Role = reader["Role"].ToString(),
                                Status = reader["Status"].ToString(),
                                DateCreated = Convert.ToDateTime(reader["DateCreated"])
                            });
                        }
                    }
                    catch (Exception)
                    {
                        // If table doesn't exist, return empty list to prevent crash
                    }
                }
            }
            return list;
        }

        public List<ReportViewModel> SearchReports(string keyword)
        {
            // Simple search logic filtering the results
            // In a real app, you would do this with a WHERE clause in SQL
            var all = GetAllReports();
            return all.FindAll(r =>
                r.Title.ToLower().Contains(keyword.ToLower()) ||
                r.Subject.ToLower().Contains(keyword.ToLower()) ||
                r.GeneratedBy.ToLower().Contains(keyword.ToLower())
            );
        }
    }
}