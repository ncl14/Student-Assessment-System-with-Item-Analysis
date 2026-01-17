using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Forms.Dashboards
{
    public partial class TeacherDashboard : Form
    {
        private User currentUser;

        public TeacherDashboard(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        // --- NAVIGATION BUTTONS ---

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Logic to return to home dashboard view
            ResetButtonColors();
            btnDashboard.BackColor = Color.FromArgb(52, 73, 94); // Highlight active
            MessageBox.Show("Dashboard Clicked");
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSubjects.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Subjects & Courses Clicked");
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnQuestion.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Question Bank Clicked");
        }

        private void btnTestC_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnTestC.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Test Creation Clicked");
        }

        private void btnTestAd_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnTestAd.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Test Administration Clicked");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnReports.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Reports Clicked");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            btnSettings.BackColor = Color.FromArgb(52, 73, 94);
            MessageBox.Show("Settings Clicked");
        }

        // --- HELPER METHODS ---

        private void ResetButtonColors()
        {
            Color defaultColor = Color.FromArgb(44, 62, 80);
            btnDashboard.BackColor = defaultColor;
            btnSubjects.BackColor = defaultColor;
            btnQuestion.BackColor = defaultColor;
            btnTestC.BackColor = defaultColor;
            btnTestAd.BackColor = defaultColor;
            btnReports.BackColor = defaultColor;
            btnSettings.BackColor = defaultColor;
        }

        // --- EMPTY EVENT HANDLERS (Required by Designer to prevent crashes) ---
        // Do not delete these unless you remove the Event link in the Properties window

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void lblRes_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void lbl9_Click(object sender, EventArgs e) { }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {

        }

        // These might be extra depending on your exact designer setup, 
        // but keeping them prevents "Definition not found" errors.
    }
}