using Student_Assessment_System_with_Item_Analysis.Forms.UserManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Forms.SubjectManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Managers.Admin;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Linq;
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

        // --- DASHBOARD LOAD ---
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                var manager = new AdminDashboardManager();

                // 1. Load Statistics
                lblUsers.Text = manager.GetTotalUsers().ToString();
                lblSubjects.Text = manager.GetTotalSubjects().ToString();

                // Placeholders (Update when Reports module is ready)
                lblReports.Text = "0";
                lblPending.Text = "0";

                // 2. Load Recent Activity Grid
                dataGridView1.DataSource = manager.GetRecentActivity();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        // --- HELPER: VIEW LOADER (USER CONTROLS) ---
        // This is the main function to switch screens inside panel3
        private void LoadView(UserControl view)
        {
            // 1. Hide the Dashboard Widgets (Cards, Graph, etc.)
            if (tlpDashboardContent != null)
            {
                tlpDashboardContent.Visible = false;
            }

            // 2. Remove any PREVIOUS UserControl (Views) from the panel
            foreach (Control c in panel3.Controls.OfType<UserControl>().ToList())
            {
                panel3.Controls.Remove(c);
                c.Dispose(); // Clean up memory
            }

            // 3. Configure the new View to FILL the panel
            view.Dock = DockStyle.Fill;

            // 4. Add and Display
            panel3.Controls.Add(view);
            view.BringToFront();
        }

        // --- HELPER: FORM LOADER (LEGACY) ---
        // Kept in case you still have some popup forms you want to embed
        private void LoadFormIntoPanel(Form form)
        {
            tlpDashboardContent.Visible = false;

            foreach (Control c in panel3.Controls.OfType<Form>().ToList())
            {
                panel3.Controls.Remove(c);
                c.Dispose();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel3.Controls.Add(form);
            panel3.Tag = form;
            form.Show();
            form.BringToFront();
        }

        // --- NAVIGATION: DASHBOARD HOME ---
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // 1. Reset Header Text
            lblAdminDashboard.Text = "DASHBOARD";

            // 2. Remove any active UserControl views
            foreach (Control c in panel3.Controls.OfType<UserControl>().ToList())
            {
                panel3.Controls.Remove(c);
                c.Dispose();
            }

            // 3. Show the Dashboard Widgets again
            if (tlpDashboardContent != null)
            {
                tlpDashboardContent.Visible = true;
            }

            // 4. Refresh Stats to ensure data is up to date
            AdminDashboard_Load(this, EventArgs.Empty);
        }

        // --- NAVIGATION: USERS ---
        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Change Header Text
                lblAdminDashboard.Text = "MANAGE USERS";

                // 2. Load the Users UserControl
                // Ensure UC_ManageUsers constructor accepts 'User' or remove argument if not needed
                var view = new UC_ManageUsers(currentUser);
                LoadView(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading User module: " + ex.Message);
            }
        }

        // --- NAVIGATION: SUBJECTS ---
        private void btnSubjects_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Change Header Text
                lblAdminDashboard.Text = "SUBJECT MANAGEMENT";

                // 2. Load the Subjects UserControl
                var view = new UC_SubjectManagement(currentUser);
                LoadView(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Subject module: " + ex.Message);
            }
        }

        // --- NAVIGATION: REPORTS ---
        private void btnReports_Click(object sender, EventArgs e)
        {
            lblAdminDashboard.Text = "REPORTS";
            MessageBox.Show("Reports Module is under construction.");
            // Eventually: LoadView(new UC_Reports());
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
                // Check if LoginForm is hidden in background
                Form existingLogin = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

                if (existingLogin != null)
                {
                    existingLogin.Show();
                }
                else
                {
                    LoginForm newLogin = new LoginForm();
                    newLogin.Show();
                }

                this.Close(); // Close Dashboard
            }
        }

        // --- CLICK EVENTS FOR CARDS (SHORTCUTS) ---
        private void panelUsersCard_Click(object sender, EventArgs e)
        {
            // Acts exactly like clicking the sidebar button
            btnUsers_Click(sender, e);
        }

        // --- EMPTY EVENT HANDLERS ---
        // DO NOT DELETE THESE. The Designer needs them to exist to avoid crashing.
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