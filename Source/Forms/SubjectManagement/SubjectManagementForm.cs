using Student_Assessment_System_with_Item_Analysis.Forms.UserManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.SubjectManagement
{
    public partial class SubjectManagementForm : Form
    {
        private readonly SubjectRepository _subjectRepo;
        private readonly User _currentUser; // To keep the session alive
        private int _subjectId = 0; // 0 = Add Mode, >0 = Edit Mode

        // Constructor accepting the logged-in user
        public SubjectManagementForm(User currentUser)
        {
            InitializeComponent();
            _subjectRepo = new SubjectRepository();
            _currentUser = currentUser;

            this.WindowState = FormWindowState.Maximized;

            // --- KEEP THIS CODE (Option 1) ---
            dgvSubjects.Columns.Clear();
            dgvSubjects.Columns.Add("colCode", "Subject Code"); // Nice header names
            dgvSubjects.Columns.Add("colName", "Subject Name");
            dgvSubjects.Columns.Add("colUnits", "Units");
            dgvSubjects.Columns.Add("colDesc", "Description");

            // Formatting
            dgvSubjects.Columns["colDesc"].Width = 250;
        }

        // --- 1. LOAD DATA ON START ---
        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        // --- 2. FETCH & DISPLAY DATA ---
        private void LoadSubjects()
        {
            try
            {
                DataTable dt = _subjectRepo.GetAllSubjects();
                dgvSubjects.Rows.Clear();

                string searchText = txtSearch.Text.Trim().ToLower();

                foreach (DataRow row in dt.Rows)
                {
                    // Search Filter
                    string code = row["SubjectCode"].ToString().ToLower();
                    string name = row["SubjectName"].ToString().ToLower();

                    if (!string.IsNullOrEmpty(searchText) && !code.Contains(searchText) && !name.Contains(searchText))
                    {
                        continue;
                    }

                    // Add row to grid
                    int rowIndex = dgvSubjects.Rows.Add(
                        row["SubjectCode"],
                        row["SubjectName"],
                        row["Units"],
                        row["Description"]
                    );

                    // Store ID in Tag for Editing/Deleting
                    dgvSubjects.Rows[rowIndex].Tag = row["SubjectID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message);
            }
        }

        // --- 3. SAVE BUTTON (ADD / UPDATE) ---
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) || string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Subject Code and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string code = txtSubjectCode.Text.Trim();
                string name = txtSubjectName.Text.Trim();
                string description = txtDescription.Text.Trim();
                int units = (int)numUnits.Value;

                if (_subjectId == 0)
                {
                    // ADD NEW
                    _subjectRepo.AddSubject(code, name, description, units);
                    MessageBox.Show("Subject Added Successfully!");
                }
                else
                {
                    // UPDATE EXISTING
                    _subjectRepo.UpdateSubject(_subjectId, code, name, description, units);
                    MessageBox.Show("Subject Updated Successfully!");
                }

                ClearForm();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        // --- 4. DELETE BUTTON ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_subjectId == 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this subject?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _subjectRepo.DeleteSubject(_subjectId);
                    ClearForm();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message);
                }
            }
        }

        // --- 5. CLEAR FORM ---
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            txtDescription.Clear();
            numUnits.Value = 3; // Default units
            _subjectId = 0; // Reset to Add Mode
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
        }

        // --- 6. GRID SELECTION (POPULATE INPUTS) ---
        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSubjects.CurrentRow.Tag != null)
            {
                DataGridViewRow row = dgvSubjects.CurrentRow;

                // Set Global ID for Edit/Delete
                _subjectId = Convert.ToInt32(row.Tag);

                // Populate Fields
                txtSubjectCode.Text = row.Cells[0].Value.ToString();
                txtSubjectName.Text = row.Cells[1].Value.ToString();
                numUnits.Value = Convert.ToDecimal(row.Cells[2].Value);
                txtDescription.Text = row.Cells[3].Value.ToString();

                // UI Changes
                btnSave.Text = "UPDATE";
                btnDelete.Enabled = true;
            }
        }

        // --- 7. SEARCH LOGIC ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSubjects(); // Reloads and applies filter
        }

        // --- NAVIGATION ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
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


        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm userForm = new ManageUsersForm(_currentUser);
            userForm.ShowDialog();
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