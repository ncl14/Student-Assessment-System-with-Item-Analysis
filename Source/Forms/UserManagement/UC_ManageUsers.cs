using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.UserManagement
{
    public partial class UC_ManageUsers : UserControl
    {
        private User currentUser;
        private readonly UserRepository _userRepo;

        public UC_ManageUsers(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            _userRepo = new UserRepository();

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load += UC_ManageUsers_Load;

            // Wire buttons safely (removing first prevents double-firing)
            btnAdd.Click -= btnAdd_Click;
            btnAdd.Click += btnAdd_Click;

            btnEdit.Click -= btnEdit_Click;
            btnEdit.Click += btnEdit_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            cboRole.SelectedIndexChanged -= cboRole_SelectedIndexChanged;
            cboRole.SelectedIndexChanged += cboRole_SelectedIndexChanged;
        }

        private void UC_ManageUsers_Load(object sender, EventArgs e)
        {
            // --- FIX 1: STOP DOUBLE COLUMNS ---
            // This tells the grid: "Don't create columns for every database field. 
            // Only use the columns I made in the Designer."
            dgvUsers.AutoGenerateColumns = false;

            LoadRoles();
            LoadUsersData();
        }

        // --- 1. DISPLAY DATA ---
        private void LoadUsersData()
        {
            try
            {
                DataTable dt = _userRepo.GetAllUsers();
                dgvUsers.DataSource = dt;

                ApplyFilter(); // Re-apply filter if needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // --- 2. FILTER LOGIC ---
        private void LoadRoles()
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("All");
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Teacher");
            cboRole.Items.Add("Student");
            cboRole.SelectedIndex = 0;
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            // Ensure DataSource is actually a DataTable before filtering
            if (dgvUsers.DataSource is DataTable dt && cboRole.SelectedItem != null)
            {
                string selectedRole = cboRole.SelectedItem.ToString();

                if (selectedRole == "All")
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {
                    // Ensure 'Role' matches the exact column name in your SQL Database
                    dt.DefaultView.RowFilter = string.Format("Role = '{0}'", selectedRole);
                }
            }
        }

        // --- 3. ADD BUTTON ---
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Pass 0 to indicate NEW user
            AddEditUserForm frm = new AddEditUserForm(0);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadUsersData(); // Refresh grid after adding
            }
        }

        // --- 4. EDIT BUTTON ---
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Make sure your Grid Column Name is exactly "UserID" in the Designer!
                var cellValue = dgvUsers.SelectedRows[0].Cells["UserID"].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int userId))
                {
                    AddEditUserForm frm = new AddEditUserForm(userId);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LoadUsersData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- 5. DELETE BUTTON ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // FIX 2: Ensure a row is actually selected
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Retrieve values safely
                // NOTE: "Username" and "UserID" inside ["..."] must match the DESIGNER COLUMN NAMES
                var cellName = dgvUsers.SelectedRows[0].Cells["Username"].Value;
                var cellId = dgvUsers.SelectedRows[0].Cells["UserID"].Value;

                if (cellName != null && cellId != null)
                {
                    string username = cellName.ToString();
                    int userId = Convert.ToInt32(cellId);

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete user '{username}'?\nThis action cannot be undone.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Calling the Repo to delete
                            _userRepo.DeleteUser(userId);

                            MessageBox.Show("User deleted successfully.");

                            // FIX 3: Refresh the grid immediately so the row disappears
                            LoadUsersData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting user: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}