using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Student_Assessment_System_with_Item_Analysis;

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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string selectedRole = cmbRole.SelectedItem.ToString();

            modProcedureVariable.checkDatabaseConnection();

            try
            {
                string query = "SELECT userFullName FROM users WHERE userName=@username AND userPass=@password AND userRole=@role";

                MySqlCommand cmd = new MySqlCommand(query, modVariables.conDbInformation);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", selectedRole);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string fullname = dr["userFullName"].ToString();
                    dr.Close();

                    Form dashboard = null;

                    switch (selectedRole)
                    {
                        case "Admin":
                            dashboard = new AdminDashboard();
                            break;
                        case "Teacher":
                            dashboard = new Teacher_Account();
                            break;
                        case "Student":
                            dashboard = new StudentDashboard();
                            break;
                        default:
                            MessageBox.Show("Unknown role selected: " + selectedRole);
                            return;
                    }

                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Invalid Username, Password, or Role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
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
