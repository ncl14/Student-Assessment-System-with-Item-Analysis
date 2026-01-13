using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Student_Assessment_System_with_Item_Analysis.Database;
using Student_Assessment_System_with_Item_Analysis.Source.Models;

namespace Student_Assessment_System_with_Item_Analysis.Source.Managers
{
    public class SubjectManager
    {
        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

            using (SqlConnection conn = DatabaseContext.GetConnection())
            {
                conn.Open();
                string query = "SELECT SubjectID, SubjectCode, SubjectName, Description FROM Subjects";
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subjects.Add(new Subject
                        {
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            SubjectCode = reader["SubjectCode"].ToString(),
                            SubjectName = reader["SubjectName"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return subjects;
        }
    }
}
