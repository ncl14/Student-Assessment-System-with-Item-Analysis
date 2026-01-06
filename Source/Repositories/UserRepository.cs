using Student_Assessment_System_with_Item_Analysis.Database;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{

    public class UserRepository
    {
        // 1. ADD USER (Create)
        public void AddUser(User user)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                // UPDATED SQL: Uses FirstName, LastName, Email, UserRole, UserName
                string query = @"INSERT INTO Users 
                                (UserName, PasswordHash, FirstName, LastName, Email, UserRole, IsActive, CreatedAt) 
                                VALUES 
                                (@user, @pass, @fname, @lname, @email, @role, 1, GETDATE())";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user.UserName);
                    cmd.Parameters.AddWithValue("@pass", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@fname", user.FirstName);
                    cmd.Parameters.AddWithValue("@lname", user.LastName);
                    cmd.Parameters.AddWithValue("@email", user.Email ?? (object)DBNull.Value); // Handle null email
                    cmd.Parameters.AddWithValue("@role", user.UserRole);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 2. GET ALL USERS (Read)
        public DataTable GetAllUsers()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                // UPDATED SQL: Selects correct columns
                string query = "SELECT UserID, UserName, FirstName, LastName, Email, UserRole, IsActive FROM Users";

                using (var cmd = new SqlCommand(query, conn))
                {
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }

        // 3. DELETE USER
        public void DeleteUser(int userId)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}