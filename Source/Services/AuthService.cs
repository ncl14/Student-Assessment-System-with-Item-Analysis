using Student_Assessment_System_with_Item_Analysis.Database;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Student_Assessment_System_with_Item_Analysis.Source.Services
{
    public class AuthService
    {
        public static User AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = DatabaseContext.GetConnection())
            {
                conn.Open();

                const string query = @"
                    SELECT UserName, UserRole, PasswordHash
                    FROM Users
                    WHERE UserName = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        string storedHash = reader["PasswordHash"] as string;
                        string role = reader["UserRole"] as string;

                        if (string.IsNullOrWhiteSpace(storedHash))
                            return null;

                        bool isBcryptHash =
                            storedHash.StartsWith("$2a$") ||
                            storedHash.StartsWith("$2b$") ||
                            storedHash.StartsWith("$2y$");

                        // Handle legacy plain-text passwords (one-time migration)
                        if (!isBcryptHash)
                        {
                            if (storedHash != password)
                                return null;

                            reader.Close(); // REQUIRED before UPDATE

                            string newHash = BCrypt.Net.BCrypt.HashPassword(password);

                            using (SqlCommand updateCmd = new SqlCommand(
                                "UPDATE Users SET PasswordHash = @hash WHERE UserName = @username",
                                conn))
                            {
                                updateCmd.Parameters.Add("@hash", SqlDbType.NVarChar).Value = newHash;
                                updateCmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                                updateCmd.ExecuteNonQuery();
                            }

                            storedHash = newHash;
                        }

                        // Verify password securely
                        if (!BCrypt.Net.BCrypt.Verify(password, storedHash))
                            return null;

                        if (role == "Admin")
                        {
                            return new Admin
                            {
                                Username = username,
                                UserRole = "Admin"
                            };
                        }
                        else if (role == "Teacher")
                        {
                            return new Teacher
                            {
                                Username = username,
                                UserRole = "Teacher"
                            };
                        }
                        else if (role == "Student")
                        {
                            return new Student
                            {
                                Username = username,
                                UserRole = "Student"
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}