using Student_Assessment_System_with_Item_Analysis.Forms.Dashboards;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Services;
using System;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // UX Improvement: Allow pressing "Enter" key to trigger the Login button
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text; // Do not trim passwords (spaces might be valid)

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Call your Service to check database
                User user = AuthService.AuthenticateUser(username, password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!user.IsActive)
                {
                    MessageBox.Show("This account has been deactivated. Please contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Route to correct Dashboard
                OpenDashboard(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while connecting to the database.\nError: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenDashboard(User user)
        {
            Form dashboard = null;

            switch (user.UserRole)
            {
                case "Admin":
                    dashboard = new AdminDashboard(user);
                    break;
                case "Teacher":
                    dashboard = new TeacherDashboard(user);
                    break;
                case "Student":
                    dashboard = new StudentDashboard(user);
                    break;
                default:
                    MessageBox.Show("Unknown user role assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (dashboard != null)
            {
                this.Hide(); // Hide Login Form
                dashboard.Show();

                // CRITICAL: Ensure the app closes when the Dashboard is closed
                dashboard.FormClosed += (s, args) => this.Close();
            }
        }

        // This ensures the entire app stops if the user clicks the 'X' on the Login form
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // Optional: You could clear error labels here if you implemented them
        }
    }
}