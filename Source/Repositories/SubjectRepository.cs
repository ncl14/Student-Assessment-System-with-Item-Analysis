using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System.Data;
using System.Data.SqlClient; // or System.Data.OleDb

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{
    public class SubjectRepository
    {
        // CHANGE THIS LINE
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentAssessmentDB;Integrated Security=True";

        // 1. Get All Subjects
        public DataTable GetAllSubjects()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Subjects", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 2. Add New Subject
        //public void AddSubject(Subject sub)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        string query = "INSERT INTO Subjects (SubjectCode, SubjectName, Units, Description) VALUES (@Code, @Name, @Units, @Desc)";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@Code", sub.SubjectCode);
        //            cmd.Parameters.AddWithValue("@Name", sub.SubjectName);
        //            cmd.Parameters.AddWithValue("@Units", sub.Units);
        //            cmd.Parameters.AddWithValue("@Desc", sub.Description);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        // 3. Update Existing Subject
        //public void UpdateSubject(Subject sub)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        string query = "UPDATE Subjects SET SubjectCode=@Code, SubjectName=@Name, Units=@Units, Description=@Desc WHERE SubjectID=@ID";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@ID", sub.SubjectID);
        //            cmd.Parameters.AddWithValue("@Code", sub.SubjectCode);
        //            cmd.Parameters.AddWithValue("@Name", sub.SubjectName);
        //            cmd.Parameters.AddWithValue("@Units", sub.Units);
        //            cmd.Parameters.AddWithValue("@Desc", sub.Description);
        //            con.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        // 4. Delete Subject
        public void DeleteSubject(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Subjects WHERE SubjectID = @ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 5. Search
        public DataTable SearchSubjects(string keyword)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Subjects WHERE SubjectCode LIKE @Key OR SubjectName LIKE @Key";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Key", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}