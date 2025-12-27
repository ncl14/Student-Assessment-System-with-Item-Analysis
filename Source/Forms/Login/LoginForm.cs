using Student_Assessment_System_with_Item_Analysis;
using Student_Assessment_System_with_Item_Analysis.Forms.Dashboards;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            // Authenticate user
            User user = AuthService.AuthenticateUser(username, password);

            if (string.IsNullOrEmpty(user.UserRole))
            {
                MessageBox.Show("User role was not loaded correctly.");
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
                    MessageBox.Show("Invalid user role.");
                    return;
            }

            this.Hide();
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
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
