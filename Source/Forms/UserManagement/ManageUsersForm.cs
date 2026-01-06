using Student_Assessment_System_with_Item_Analysis.Forms.SubjectManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.UserManagement
{
    public partial class ManageUsersForm : Form
    {
        private readonly UserRepository _userRepo;
        private readonly User _currentUser;

        public ManageUsersForm(User currentUser)
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            _currentUser = currentUser;

            // Start Maximized
            this.WindowState = FormWindowState.Maximized;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            // Setup Dropdown
            cmbRoleFilter.Items.Clear();
            cmbRoleFilter.Items.AddRange(new string[] { "All", "Admin", "Teacher", "Student" });
            cmbRoleFilter.SelectedIndex = 0;

            // Setup DataGridView Styling
            StyleDataGridView();

            // Load Initial Data
            LoadUsers();
        }

        // --- STYLING ---
        private void StyleDataGridView()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Colors
            dgvUsers.BackgroundColor = Color.WhiteSmoke;
            dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            // Header
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvUsers.ColumnHeadersHeight = 35;
        }

        // --- LOAD DATA ---
        private void LoadUsers()
        {
            try
            {
                DataTable dt = _userRepo.GetAllUsers();
                dgvUsers.Rows.Clear();

                string selectedRole = cmbRoleFilter.SelectedItem?.ToString() ?? "All";

                foreach (DataRow row in dt.Rows)
                {
                    string dbRole = row["UserRole"].ToString();

                    // Filter
                    if (selectedRole != "All" && !dbRole.Equals(selectedRole, StringComparison.OrdinalIgnoreCase))
                        continue;

                    string fullName = $"{row["FirstName"]} {row["LastName"]}";
                    string status = (bool)row["IsActive"] ? "Active" : "Inactive";

                    int rowIndex = dgvUsers.Rows.Add(
                        row["UserName"],
                        fullName,
                        dbRole,
                        status
                    );

                    // Store UserID in Tag
                    dgvUsers.Rows[rowIndex].Tag = row["UserID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // --- ADD BUTTON ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditUserForm addForm = new AddEditUserForm();
            // If the user clicks Save, refreshing happens here
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        // --- EDIT BUTTON ---
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            if (dgvUsers.SelectedRows[0].Tag != null)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Tag);

                AddEditUserForm editForm = new AddEditUserForm(userId);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUsers();
                }
            }
        }

        // --- DELETE BUTTON ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            if (dgvUsers.SelectedRows[0].Tag != null)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Tag);
                string username = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();

                // Prevent self-deletion
                if (_currentUser != null && userId == _currentUser.UserID)
                {
                    MessageBox.Show("You cannot delete your own account while logged in.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting: " + ex.Message);
                    }
                }
            }
        }

        // --- ENABLE/DISABLE BUTTONS ON SELECTION ---
        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dgvUsers.SelectedRows.Count > 0;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        // --- NAVIGATION ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // 1. Hide the current 'Manage Users' form
            this.Hide();

            // 2. Create the 'Subject Management' form
            // We pass '_currentUser' so the session (and profile info) carries over
            AdminDashboard adminForm = new AdminDashboard(_currentUser);

            // 3. Open it as a Dialog (This pauses the code here until Subject form is closed)
            adminForm.ShowDialog();

            // 4. When Subject form closes, show this form again
            // (Unless the user navigated to Dashboard from there, which closes everything)
            this.Show();
        }

        // Prevent crashes if accidentally linked
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            // 1. Hide the current 'Manage Users' form
            this.Hide();

            // 2. Create the 'Subject Management' form
            // We pass '_currentUser' so the session (and profile info) carries over
            SubjectManagementForm subjectForm = new SubjectManagementForm(_currentUser);

            // 3. Open it as a Dialog (This pauses the code here until Subject form is closed)
            subjectForm.ShowDialog();

            // 4. When Subject form closes, show this form again
            // (Unless the user navigated to Dashboard from there, which closes everything)
            this.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Are you sure you want to logout?",
          "Logout Confirmation",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}