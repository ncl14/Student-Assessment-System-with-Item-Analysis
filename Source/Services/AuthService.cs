using Student_Assessment_System_with_Item_Analysis.Database;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
            SELECT 
                UserId,
                UserName,
                UserRole,
                PasswordHash,
                Email,
                FirstName,
                LastName,
                IsActive,
                CreatedAt
            FROM Users
            WHERE UserName = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        // ✅ Cache all DB values FIRST
                        int userId = Convert.ToInt32(reader["UserId"]);
                        string dbUsername = reader["UserName"].ToString();
                        string role = reader["UserRole"].ToString();
                        string storedHash = reader["PasswordHash"].ToString();
                        string email = reader["Email"] as string;
                        string firstName = reader["FirstName"] as string;
                        string lastName = reader["LastName"] as string;
                        bool isActive = Convert.ToBoolean(reader["IsActive"]);
                        DateTime createdAt = Convert.ToDateTime(reader["CreatedAt"]);

                        if (string.IsNullOrWhiteSpace(storedHash) || !isActive)
                            return null;

                        bool isBcryptHash =
                            storedHash.StartsWith("$2a$") ||
                            storedHash.StartsWith("$2b$") ||
                            storedHash.StartsWith("$2y$");

                        // 🔁 SHA-256 → BCrypt migration
                        if (!isBcryptHash)
                        {
                            using (SHA256 sha = SHA256.Create())
                            {
                                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                                string shaHash = BitConverter
                                    .ToString(bytes)
                                    .Replace("-", "")
                                    .ToLower();

                                if (shaHash != storedHash.ToLower())
                                    return null;
                            }

                            reader.Close(); // now safe

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

                        // 🔐 BCrypt verification (HARDENED)
                        try
                        {
                            if (!BCrypt.Net.BCrypt.Verify(password, storedHash))
                                return null;
                        }
                        catch (BCrypt.Net.SaltParseException)
                        {
                            // corrupted hash in DB
                            return null;
                        }

                        // ✅ Create correct user object
                        User user;
                        if (role == "Admin") user = new Admin();
                        else if (role == "Teacher") user = new Teacher();
                        else if (role == "Student") user = new Student();
                        else return null;

                        user.UserId = userId;
                        user.Username = dbUsername;
                        user.UserRole = role;
                        user.Email = email;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.IsActive = isActive;
                        user.CreatedAt = createdAt;

                        return user;
                    }
                }
            }
        }
    }
}
