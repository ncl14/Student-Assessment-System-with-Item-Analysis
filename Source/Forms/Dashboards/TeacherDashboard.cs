using Student_Assessment_System_with_Item_Analysis.Source.Forms;
using Student_Assessment_System_with_Item_Analysis.Source.Forms.UserManagement;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void TeacherDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void lblNotif_Click(object sender, EventArgs e)
        {

        }

        private void pbNotif_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e) //Question bank
        {
            tcQuestionbank tcQuestionbank = new tcQuestionbank();
            tcQuestionbank.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Teacher Reports
        {
            tcReports tcReports = new tcReports();
            tcReports.Show();

            this.Close();

        }

        private void button6_Click(object sender, EventArgs e) //Subject Courses
        {
            lblSubjectcourses subjectcourses = new lblSubjectcourses();
            subjectcourses.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Test Administration
        {
            Testadministration testadministration = new Testadministration();   
            testadministration.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) //Settings
        {
            Settings settings = new Settings(); 
            settings.Show();

            this.Close();
        }
    }
}