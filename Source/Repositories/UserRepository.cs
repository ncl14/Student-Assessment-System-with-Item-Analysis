using Student_Assessment_System_with_Item_Analysis.Database;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{
    public class UserRepository
    {
        // ---------------------------------------------------------
        // 1. GET ALL USERS (For the Dashboard Grid)
        // ---------------------------------------------------------
        public DataTable GetAllUsers()
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = "SELECT UserID, UserName, FirstName, LastName, Email, UserRole, IsActive FROM Users";

                using (var cmd = new SqlCommand(query, conn))
                {
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }

        // ---------------------------------------------------------
        // 2. GET SINGLE USER (Fixes Error CS1061 - Used for Editing)
        // ---------------------------------------------------------
        public DataTable GetUserById(int userId)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                // Note: We select PasswordHash as 'Password' to match the Form's expectation
                string query = "SELECT UserID, UserName, PasswordHash as [Password], FirstName, LastName, Email, UserRole, IsActive FROM Users WHERE UserID = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    var dt = new DataTable();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }

        public void AddUser(string username, string password, string role, string firstName, string lastName, string email, bool isActive)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = @"INSERT INTO Users 
                        (UserName, PasswordHash, UserRole, FirstName, LastName, Email, IsActive, CreatedAt) 
                        VALUES 
                        (@user, @pass, @role, @fname, @lname, @email, @active, GETDATE())";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    // Handle null email gracefully
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@active", isActive ? 1 : 0);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(int userId, string username, string password, string role, string firstName, string lastName, string email, bool isActive)
        {
            using (var conn = new SqlConnection(DatabaseContext.ConnectionString))
            {
                string query = @"UPDATE Users 
                         SET UserName = @user, 
                             PasswordHash = @pass, 
                             UserRole = @role, 
                             FirstName = @fname, 
                             LastName = @lname, 
                             Email = @email,
                             IsActive = @active 
                         WHERE UserID = @id";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                    cmd.Parameters.AddWithValue("@active", isActive ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ---------------------------------------------------------
        // 5. DELETE USER
        // ---------------------------------------------------------
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