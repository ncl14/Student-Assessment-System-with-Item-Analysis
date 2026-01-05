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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            User user = AuthService.AuthenticateUser(username, password);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (user.UserRole)
            {
                case "Admin":
                    new AdminDashboard(user).Show();
                    break;
                case "Teacher":
                    new TeacherDashboard(user).Show();
                    break;
                case "Student":
                    new StudentDashboard(user).Show();
                    break;
                default:
                    MessageBox.Show("Unknown user role.");
                    return;
            }

            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
