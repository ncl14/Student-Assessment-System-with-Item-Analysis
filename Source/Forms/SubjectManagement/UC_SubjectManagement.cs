using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Source.Forms.SubjectManagement
{
    public partial class UC_SubjectManagement : UserControl
    {
        private readonly User _currentUser;
        private readonly SubjectRepository _repo;

        // This variable tracks if we are Editing (ID > 0) or Adding (ID = 0)
        private int _currentSubjectId = 0;

        public UC_SubjectManagement(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _repo = new SubjectRepository();

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            this.Load += UC_SubjectManagement_Load;

            // Button Events
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            // Grid Events
            dgvSubjects.CellClick += dgvSubjects_CellClick;

            // Search Event
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void UC_SubjectManagement_Load(object sender, EventArgs e)
        {
            // STOP DOUBLE COLUMNS
            dgvSubjects.AutoGenerateColumns = false;
            LoadSubjects();
        }

        // --- 1. LOAD DATA ---
        private void LoadSubjects()
        {
            try
            {
                DataTable dt = _repo.GetAllSubjects();
                dgvSubjects.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        // --- 2. SAVE (ADD or UPDATE) ---
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) || string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Subject Code and Name are required.");
                return;
            }

            try
            {
                Subject sub = new Subject
                {
                    SubjectID = _currentSubjectId, // 0 for new, ID for existing
                    SubjectCode = txtSubjectCode.Text.Trim(),
                    SubjectName = txtSubjectName.Text.Trim(),
                    Units = (int)numUnits.Value, // Assuming you used a NumericUpDown
                    Description = txtDescription.Text.Trim()
                };

                if (_currentSubjectId == 0)
                {
                    // INSERT
                    _repo.AddSubject(sub);
                    MessageBox.Show("Subject Added Successfully!");
                }
                else
                {
                    // UPDATE
                    _repo.UpdateSubject(sub);
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

        // --- 3. DELETE ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentSubjectId == 0)
            {
                MessageBox.Show("Please select a subject to delete first.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _repo.DeleteSubject(_currentSubjectId);
                    MessageBox.Show("Deleted Successfully.");
                    ClearForm();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message);
                }
            }
        }

        // --- 4. CLEAR ---
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            txtDescription.Clear();
            numUnits.Value = numUnits.Minimum;

            // Reset ID to 0 so the Save button knows we are back to "Add Mode"
            _currentSubjectId = 0;

            // Optional: Change button text back to "Save" if you change it to "Update"
            btnSave.Text = "SAVE";
        }

        // --- 5. GRID SELECTION (Populate TextBoxes) ---
        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];

                // IMPORTANT: Ensure your Designer "DataPropertyName" matches these keys!
                _currentSubjectId = Convert.ToInt32(row.Cells["SubjectID"].Value);

                txtSubjectCode.Text = row.Cells["SubjectCode"].Value.ToString();
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

                // Handle Units (safe conversion)
                if (int.TryParse(row.Cells["Units"].Value.ToString(), out int u))
                {
                    numUnits.Value = u;
                }

                // Change button text to indicate Edit Mode
                btnSave.Text = "UPDATE";
            }
        }

        // --- 6. SEARCH ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = _repo.SearchSubjects(txtSearch.Text.Trim());
                dgvSubjects.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Silent fail or log
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }
    }
}