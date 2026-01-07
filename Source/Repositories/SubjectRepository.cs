using Student_Assessment_System_with_Item_Analysis.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{
    public class SubjectRepository
    {
        // GET ALL
        public DataTable GetAllSubjects()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = "SELECT SubjectID, SubjectCode, SubjectName, Description, Units FROM Subjects ORDER BY SubjectCode";
                using (var cmd = new SqlCommand(query, conn))
                {
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }

        // ADD
        public void AddSubject(string code, string name, string description, int units)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = @"INSERT INTO Subjects (SubjectCode, SubjectName, Description, Units, CreatedAt) 
                                VALUES (@code, @name, @desc, @units, GETDATE())";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@units", units);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // UPDATE
        public void UpdateSubject(int id, string code, string name, string description, int units)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = @"UPDATE Subjects 
                                SET SubjectCode = @code, 
                                    SubjectName = @name, 
                                    Description = @desc, 
                                    Units = @units 
                                WHERE SubjectID = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", description ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@units", units);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // DELETE
        public void DeleteSubject(int id)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = "DELETE FROM Subjects WHERE SubjectID = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}