using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.UserManagement
{
    public partial class AddEditUserForm : Form
    {
        private readonly UserRepository _userRepo;
        private int _userId = 0; // 0 = Add Mode, >0 = Edit Mode

        // --- CONSTRUCTOR 1: ADD NEW USER ---
        public AddEditUserForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            _userId = 0;

            lblTitle.Text = "Add New User";
            InitializeDropdowns();
        }

        // --- CONSTRUCTOR 2: EDIT EXISTING USER ---
        public AddEditUserForm(int userId)
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            _userId = userId;

            lblTitle.Text = "Edit User";
            InitializeDropdowns();
            LoadUserData(userId);
        }

        // 1. SETUP DROPDOWNS
        private void InitializeDropdowns()
        {
            // Roles
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Teacher");
            cmbRole.Items.Add("Student");
            cmbRole.SelectedIndex = 0;

            // Sections
            cmbSection.Items.Clear();
            cmbSection.Items.Add("N/A"); // For Admins
            cmbSection.Items.Add("Section A");
            cmbSection.Items.Add("Section B");
            cmbSection.SelectedIndex = 0;
        }

        // 2. LOAD DATA FOR EDITING
        private void LoadUserData(int id)
        {
            try
            {
                DataTable dt = _userRepo.GetUserById(id);

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtUser.Text = row["UserName"].ToString();
                    txtPassword.Text = row["Password"].ToString(); // Note: Check column name in Repo
                    txtFirstName.Text = row["FirstName"].ToString();
                    txtLastName.Text = row["LastName"].ToString();
                    txtEmail.Text = row["Email"] != DBNull.Value ? row["Email"].ToString() : "";

                    // Set Role
                    string role = row["UserRole"].ToString();
                    if (cmbRole.Items.Contains(role)) cmbRole.SelectedItem = role;

                    // Set Section (if column exists in DB, otherwise ignore)
                    if (dt.Columns.Contains("Section"))
                    {
                        string section = row["Section"].ToString();
                        if (cmbSection.Items.Contains(section)) cmbSection.SelectedItem = section;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        // 3. SAVE BUTTON (ADD OR UPDATE)
        private void btnSave_Click(object sender, EventArgs e)
        {
            // A. Validation
            if (string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please fill in all required fields (Username, Password, Names).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // B. Gather Data
                string username = txtUser.Text.Trim();
                string password = txtPassword.Text.Trim();
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim(); // Now capturing Email
                string role = cmbRole.SelectedItem.ToString();
                bool isActive = true;

                if (_userId == 0)
                {
                    // --- ADD NEW USER ---
                    // Calls the AddUser method (Ensure Repo accepts email!)
                    _userRepo.AddUser(username, password, role, firstName, lastName, email, isActive);
                    MessageBox.Show("User added successfully!");
                }
                else
                {
                    // --- UPDATE EXISTING USER ---
                    // Calls the UpdateUser method
                    _userRepo.UpdateUser(_userId, username, password, role, firstName, lastName, email, isActive);
                    MessageBox.Show("User updated successfully!");
                }

                // C. Close Form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}