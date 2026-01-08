using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Repositories
{
    public class UserRepository
    {
        // UPDATED: Using the Catalog name 'StudentAssessmentDB' seen in your screenshot
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentAssessmentDB;Integrated Security=True";

        // --- 1. GET ALL USERS (For DataGridView) ---
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // We construct 'FullName' and format 'Status' specifically for the Grid View
                string query = @"SELECT 
                                    UserID, 
                                    UserName AS Username, 
                                    (FirstName + ' ' + LastName) AS FullName, 
                                    UserRole AS Role, 
                                    CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS Status 
                                 FROM Users";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error fetching user list: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        // --- 2. GET USER BY ID (For Edit Mode) ---
        public DataTable GetUserById(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // We map DB columns to aliases the Form expects
                string query = @"SELECT 
                                    UserID, 
                                    UserName, 
                                    PasswordHash AS Password,  -- Aliased for the form
                                    FirstName, 
                                    LastName, 
                                    UserRole, 
                                    Email,
                                    IsActive
                                 FROM Users 
                                 WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    try
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error fetching user: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        // --- 3. ADD USER ---
        public void AddUser(string username, string password, string role, string firstName, string lastName, string email, bool isActive)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                // Note: In a real app, ensure 'password' is hashed before saving to PasswordHash
                string query = @"INSERT INTO Users (UserName, PasswordHash, UserRole, FirstName, LastName, Email, IsActive, CreatedAt) 
                                 VALUES (@UserName, @Password, @Role, @FirstName, @LastName, @Email, @IsActive, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password); // Maps to PasswordHash
                    cmd.Parameters.AddWithValue("@Role", role);         // Maps to UserRole
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", isActive ? 1 : 0); // Convert bool to bit (1 or 0)

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- 4. UPDATE USER ---
        public void UpdateUser(int userId, string username, string password, string role, string firstName, string lastName, string email, bool isActive)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Users 
                                 SET UserName = @UserName, 
                                     PasswordHash = @Password, 
                                     UserRole = @Role, 
                                     FirstName = @FirstName, 
                                     LastName = @LastName, 
                                     Email = @Email,
                                     IsActive = @IsActive 
                                 WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IsActive", isActive ? 1 : 0);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // --- 5. DELETE USER ---
        public void DeleteUser(int userId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error deleting user: " + ex.Message);
                    }
                }
            }
        }
    }
}