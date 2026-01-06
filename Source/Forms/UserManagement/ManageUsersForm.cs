using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Windows.Forms;
// Ensure this namespace points to where your AdminDashboard is located
// If AdminDashboard is in Source.Managers.Admin, use that instead.

namespace Student_Assessment_System_with_Item_Analysis.Forms.UserManagement
{
    public partial class ManageUsersForm : Form
    {
        private readonly UserRepository _userRepo;

        public ManageUsersForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository();

            // --- Wire up Event Handlers ---
            // Main Action Buttons
            // Ensure your buttons in Designer are named: btnAdd, btnDelete, btnEdit
            if (this.btnAdd != null) this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            if (this.btnDelete != null) this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            if (this.btnEdit != null) this.btnEdit.Click += new EventHandler(this.btnEdit_Click);
            if (this.dgvUsers != null) this.dgvUsers.SelectionChanged += new EventHandler(this.dgvUsers_SelectionChanged);

            // Filter Dropdown
            // Ensure your dropdown in Designer is named: cmbRoleFilter
            if (this.cmbRoleFilter != null) this.cmbRoleFilter.SelectedIndexChanged += new EventHandler(this.cmbRoleFilter_SelectedIndexChanged);

            // Sidebar Navigation
            if (this.btnDashboard != null) this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);
            if (this.lblLogout != null) this.lblLogout.Click += new EventHandler(this.lblLogout_Click);
        }

        // 1. LOAD: Setup form on start
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoGenerateColumns = false;

            // Initialize Filter Dropdown
            cmbRoleFilter.Items.Clear();
            cmbRoleFilter.Items.Add("All");
            cmbRoleFilter.Items.Add("Admin");
            cmbRoleFilter.Items.Add("Teacher");
            cmbRoleFilter.Items.Add("Student");

            // Set default to "All" (this triggers SelectedIndexChanged -> LoadUsers)
            cmbRoleFilter.SelectedIndex = 0;

            // Initial button states
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        // 2. FETCH & FILTER DATA
        private void LoadUsers()
        {
            try
            {
                DataTable dt = _userRepo.GetAllUsers();
                dgvUsers.Rows.Clear();

                // Get filter selection (Default to "All" if null)
                string selectedRole = cmbRoleFilter.SelectedItem?.ToString() ?? "All";

                foreach (DataRow row in dt.Rows)
                {
                    string dbRole = row["UserRole"].ToString();

                    // --- FILTER LOGIC ---
                    // If specific role selected AND it doesn't match current row, skip it
                    if (selectedRole != "All" && !dbRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    // Prepare Data
                    string fullName = $"{row["FirstName"]} {row["LastName"]}";
                    string status = (bool)row["IsActive"] ? "Active" : "Inactive";

                    // Add to Grid
                    int rowIndex = dgvUsers.Rows.Add(
                        row["UserName"],
                        fullName,
                        dbRole,
                        status
                    );

                    // Store ID for Actions
                    dgvUsers.Rows[rowIndex].Tag = row["UserID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. FILTER CHANGE EVENT
        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers(); // Reload grid based on new filter
        }

        // 4. ADD USER
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditUserForm addForm = new AddEditUserForm();
            addForm.ShowDialog();

            // Refresh grid after closing add form
            LoadUsers();
        }

        // 5. DELETE USER
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            if (dgvUsers.SelectedRows[0].Tag != null)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Tag);
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{username}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _userRepo.DeleteUser(userId);
                        MessageBox.Show("User deleted successfully.");
                        LoadUsers(); // Refresh grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
        }

        // 6. EDIT USER (Placeholder)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            MessageBox.Show("Edit functionality coming soon!", "Info");
        }

        // 7. SELECTION CHANGED
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvUsers.SelectedRows.Count > 0;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        // --- NAVIGATION ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to Dashboard
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                // Ensure LoginForm is available
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        // Empty events to prevent designer errors
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}