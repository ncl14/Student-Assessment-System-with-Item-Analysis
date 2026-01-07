using Student_Assessment_System_with_Item_Analysis.Forms.UserManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Forms.Reports;
using Student_Assessment_System_with_Item_Analysis.Source.Forms.SubjectManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Managers.Admin;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using StudentAssessmentSystem;
using System;
using System.Drawing; // Required for Color/Fonts
using System.Linq;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class AdminDashboard : Form
    {
        private readonly User currentUser;

        public AdminDashboard(User user)
        {
            InitializeComponent(); // This runs the Designer.cs code
            currentUser = user;

            // Apply styles immediately after initialization
            ApplyRecentGridStyle();
        }

        // --- 1. DASHBOARD LOAD ---
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var manager = new AdminDashboardManager();

                // Load Statistics
                lblUsers.Text = manager.GetTotalUsers().ToString();
                lblSubjects.Text = manager.GetTotalSubjects().ToString();

                // Placeholders
                lblReports.Text = "0";
                lblPending.Text = "0";

                // Load Recent Activity Grid
                // NOTE: Make sure your Manager returns a DataTable, not null
                dataGridView1.DataSource = manager.GetRecentActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        // --- 2. GRID STYLING METHOD ---
        // Keeps your Constructor clean and safe from Designer overwrites
        private void ApplyRecentGridStyle()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
        }

        // --- HELPER: VIEW LOADER (USER CONTROLS) ---
        private void LoadView(UserControl view)
        {
            // 1. Hide the Dashboard Widgets
            if (tlpDashboardContent != null) tlpDashboardContent.Visible = false;

            // 2. Remove previous views
            foreach (Control c in panel3.Controls.OfType<UserControl>().ToList())
            {
                panel3.Controls.Remove(c);
                c.Dispose();
            }

            // 3. Add new View
            view.Dock = DockStyle.Fill;
            panel3.Controls.Add(view);
            view.BringToFront();
        }

        // --- NAVIGATION BUTTONS ---

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblAdminDashboard.Text = "DASHBOARD";

            // Remove active views
            foreach (Control c in panel3.Controls.OfType<UserControl>().ToList())
            {
                panel3.Controls.Remove(c);
                c.Dispose();
            }

            // Show Widgets
            if (tlpDashboardContent != null) tlpDashboardContent.Visible = true;

            // Refresh Data
            AdminDashboard_Load(this, EventArgs.Empty);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                lblAdminDashboard.Text = "MANAGE USERS";
                var view = new UC_ManageUsers(currentUser);
                LoadView(view);
            }
            catch (Exception ex) { MessageBox.Show("Error loading User module: " + ex.Message); }
        }

        private void btnSubjects_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblAdminDashboard.Text = "SUBJECT MANAGEMENT";
                var view = new UC_SubjectManagement(currentUser);
                LoadView(view);
            }
            catch (Exception ex) { MessageBox.Show("Error loading Subject module: " + ex.Message); }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                lblAdminDashboard.Text = "MANAGE REPORTS";
                var view = new UC_Reports(currentUser);
                LoadView(view);
            }
            catch (Exception ex) { MessageBox.Show("Error loading Reports module: " + ex.Message); }
        }

        // --- FIXED LOGOUT LOGIC ---
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
                // Create a NEW Login window
                LoginForm login = new LoginForm();
                login.Show();

                // Close the Dashboard completely
                this.Close();
            }
        }

        // --- SHORTCUTS & EMPTY HANDLERS ---
        private void panelUsersCard_Click(object sender, EventArgs e)
        {
            btnUsers_Click(sender, e);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Update the Header Title
                lblAdminDashboard.Text = "SYSTEM SETTINGS";

                // 2. Initialize the Settings Control
                // Ensure SettingsUserControl matches the class name you created earlier
                var view = new SettingsUserControl();

                // 3. Load it into the main panel using your helper method
                LoadView(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Settings module: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Required for Designer stability - Do not remove
        private void label1_Click(object sender, EventArgs e) { }
        private void lbl3_Click(object sender, EventArgs e) { }
        private void lbl4_Click(object sender, EventArgs e) { }
        private void lblDashboard_Click(object sender, EventArgs e) { }
        private void lblUser_Click(object sender, EventArgs e) { }
        private void lblSubject_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void lblRecent_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void lblAdminDashboard_Click(object sender, EventArgs e) { }
        private void txtb1_TextChanged(object sender, EventArgs e) { }
        private void lbl1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void btnSubjects_Click(object sender, EventArgs e) { }
        private void lbl1_Click_1(object sender, EventArgs e) { }
        private void lbl2_Click(object sender, EventArgs e) { }
        private void lbl1_Click_2(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblAdminDashboard_Click_1(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void picboxProfile_Click(object sender, EventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lblPendingSub_Click(object sender, EventArgs e) { }
        private void panelUsersCard_Paint(object sender, PaintEventArgs e) { }
        private void tlpDashboardContent_Paint(object sender, PaintEventArgs e) { }
    }
}
