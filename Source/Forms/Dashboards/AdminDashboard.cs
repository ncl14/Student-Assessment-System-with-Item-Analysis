using Student_Assessment_System_with_Item_Analysis.Forms.SubjectManagement;
using Student_Assessment_System_with_Item_Analysis.Forms.UserManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Managers.Admin;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class AdminDashboard : Form
    {
        private readonly User currentUser;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        // --- LOAD DASHBOARD ---
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var manager = new AdminDashboardManager();

                // 1. Load Statistics
                lblUsers.Text = manager.GetTotalUsers().ToString();
                lblSubjects.Text = manager.GetTotalSubjects().ToString();

                // Placeholders (Update these when Reports module is ready)
                lblReports.Text = "0";
                lblPending.Text = "0";

                // 2. Load Recent Activity Grid
                dataGridView1.DataSource = manager.GetRecentActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        // --- NAVIGATION: SUBJECTS ---
        // Matches 'btnSubjects_Click_1' from your Designer
        private void btnSubjects_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SubjectManagementForm subjectForm = new SubjectManagementForm(currentUser);
            subjectForm.ShowDialog();
            this.Show(); // Show dashboard again when Subject form closes
        }

        // --- NAVIGATION: USERS ---
        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersForm userForm = new ManageUsersForm(currentUser);
            userForm.ShowDialog();
            this.Show(); // Show dashboard again when User form closes
        }

        // --- NAVIGATION: REFRESH DASHBOARD ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard_Load(this, EventArgs.Empty);
        }

        // --- NAVIGATION: REPORTS ---
        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Module is under construction.");
        }

        // --- LOGOUT LOGIC ---
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

        // --- CLICK EVENTS FOR CARDS (Optional: Make clicking the card act like the button) ---
        private void panelUsersCard_Click(object sender, EventArgs e)
        {
            btnUsers_Click(sender, e);
        }

        // --- EMPTY EVENT HANDLERS (Required to prevent Designer errors) ---
        // Do not delete these if they are linked in the Designer (the lightning bolt icon)
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
        private void btnSubjects_Click(object sender, EventArgs e) { } // Old event, kept just in case
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
    }
}