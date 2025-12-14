using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Windows.Forms;
using Student_Assessment_System_with_Item_Analysis;
using Student_Assessment_System_with_Item_Analysis.Forms.Dashboards;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Teacher");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both Username and Password.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cs = ConfigurationManager.ConnectionStrings["MyConn"];
            if (cs == null)
            {
                MessageBox.Show("Configuration error: missing 'MyConn' connection string in App.config.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connStr = cs.ConnectionString;

            // The using statement handles closing the connection and disposing the object automatically.
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // Corrected query using actual table column names: FullName, Username, Password, Role
                    string query = "SELECT FullName FROM dbo.Users WHERE Username=@username AND PasswordHash=@password AND UserRole=@role";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string fullname = dr["FullName"].ToString(); // Note: Using 'FullName' not 'userFullName'
                                dr.Close();

                                MessageBox.Show($"Login Successful. Welcome, {fullname}!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Role-based Navigation
                                Form dashboard = null;
                                switch (role)
                                {
                                    case "Admin":
                                        dashboard = new AdminDashboard();
                                        break;
                                    case "Teacher":
                                        dashboard = new TeacherDashboard();
                                        break;
                                    case "Student":
                                        dashboard = new StudentDashboard();
                                        break;
                                }

                                if (dashboard != null)
                                {
                                    dashboard.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Invalid Username, Password, or Role combination!", "Login Failed",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } // End using SqlDataReader
                    } // End using SqlCommand
                } // End using SqlConnection (conn.Close() called automatically here)
            }
            catch (Exception ex)
            {
                // Application must handle exceptions - no crashes allowed [cite: 212]
                MessageBox.Show("A database error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: handle role change
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle username change
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Optional: handle password change
        }
    }
}
