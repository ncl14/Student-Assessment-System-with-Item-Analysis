using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Source.Forms.Reports
{
    public partial class UC_Reports : UserControl
    {
        private ReportRepository _repo;
        private User currentUser; // FIXED: Added this missing field

        // --- CONSTRUCTORS ---

        // Default Constructor (Required for Visual Studio Designer)
        public UC_Reports()
        {
            InitializeComponent();
            SetupView();
        }

        // Main Constructor (Used by AdminDashboard)
        public UC_Reports(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            SetupView(); // FIXED: Ensure data loads when this constructor is used
        }

        // Helper method to avoid duplicate code in constructors
        private void SetupView()
        {
            _repo = new ReportRepository();
            ApplyModernGridStyle();
            LoadData();
        }

        // --- 1. DATA LOADING ---
        private void LoadData()
        {
            try
            {
                var data = _repo.GetAllReports();
                dgvReports.DataSource = data;
            }
            catch (Exception ex)
            {
                // Optional: Handle error if database is empty or connection fails
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        // --- 2. SEARCH LOGIC ---
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                dgvReports.DataSource = _repo.SearchReports(keyword);
            }
        }

        // --- 3. REFRESH BUTTON ---
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }

        // --- 4. MODERN STYLING ---
        private void ApplyModernGridStyle()
        {
            dgvReports.BorderStyle = BorderStyle.None;
            dgvReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvReports.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReports.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvReports.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvReports.BackgroundColor = Color.White;

            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReports.ColumnHeadersHeight = 40;

            dgvReports.RowHeadersVisible = false;
            dgvReports.RowTemplate.Height = 35;
            dgvReports.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}