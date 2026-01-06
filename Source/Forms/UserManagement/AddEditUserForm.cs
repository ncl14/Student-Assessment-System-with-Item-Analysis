using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.UserManagement
{
    public partial class AddEditUserForm : Form
    {
        // 1. Initialize Repository
        private readonly UserRepository _userRepo;

        public AddEditUserForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();

            // Wire up the button events
            this.btnLogin.Click += new EventHandler(this.btnSaveUser_Click);
            this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);

            // Initialize Dropdowns
            LoadRoles();
            LoadSections();
        }

        // 2. Setup Dropdowns
        private void LoadRoles()
        {
            if (cmbRole.Items.Count == 0)
            {
                cmbRole.Items.Add("Admin");
                cmbRole.Items.Add("Teacher");
                cmbRole.Items.Add("Student");
            }
            cmbRole.SelectedIndex = 0; // Default to first item
        }

        private void LoadSections()
        {
            // Dummy data for sections
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("Section A");
                comboBox1.Items.Add("Section B");
                comboBox1.Items.Add("N/A");
            }
            comboBox1.SelectedIndex = 0;
        }

        // 3. SAVE BUTTON LOGIC (Your button is named 'btnLogin')
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            // A. Validation
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) || // First Name
                string.IsNullOrWhiteSpace(textBox2.Text) || // Last Name
                string.IsNullOrWhiteSpace(txtEmail.Text))   // Email (New Field)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // B. Create User Object based on Role
                User newUser;
                string selectedRole = cmbRole.SelectedItem.ToString();

                if (selectedRole == "Teacher") newUser = new Teacher();
                else if (selectedRole == "Student") newUser = new Student();
                else newUser = new Admin();

                // C. Populate Data
                newUser.UserName = txtUser.Text.Trim();
                newUser.PasswordHash = txtPassword.Text.Trim(); // In production, hash this!
                newUser.FirstName = textBox1.Text.Trim();
                newUser.LastName = textBox2.Text.Trim();
                newUser.Email = txtEmail.Text.Trim(); // Save Email
                newUser.UserRole = selectedRole;
                newUser.IsActive = true;

                // D. Save to Database
                _userRepo.AddUser(newUser);

                MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // E. Clear Form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtUser.Clear();
            txtPassword.Clear();
            textBox1.Clear(); // First Name
            textBox2.Clear(); // Last Name
            txtEmail.Clear(); // Clear Email
            cmbRole.SelectedIndex = 0;
            comboBox1.SelectedIndex = -1;
        }

        // 4. NAVIGATION LOGIC
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to dashboard
        }

        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Are you sure you want to logout?",
                 "Logout Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                // Ensure LoginForm is accessible. 
                // If LoginForm is hidden, you might need to create a new one or show the existing one.
                LoginForm login = new LoginForm();
                login.Show();
                this.Close(); // Close the dashboard
            }
        }
    }
}