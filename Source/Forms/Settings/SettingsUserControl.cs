using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAssessmentSystem
{
    public partial class SettingsUserControl : UserControl
    {
        // Connection string - typically stored in App.config
        private string connectionString = "Data Source=.;Initial Catalog=AssessmentDB;Integrated Security=True";

        public SettingsUserControl()
        {
            InitializeComponent();
            LoadCurrentSettings();
        }

        // Load existing settings when the control opens
        private void LoadCurrentSettings()
        {
            // In a real app, fetch these from the database or Properties.Settings
            txtCurrentTerm.Text = "1st Semester 2025-2026";
            numPassingScore.Value = 60;
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL Server Backup|*.bak";
                sfd.FileName = $"AssessmentDB_Backup_{DateTime.Now:yyyyMMdd}";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PerformBackup(sfd.FileName);
                        MessageBox.Show("Database backup completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Backup failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void PerformBackup(string path)
        {
            // SQL Command to backup the database
            string backupQuery = $"BACKUP DATABASE [AssessmentDB] TO DISK = '{path}' WITH FORMAT, MEDIANAME = 'Z_SQLServerBackups', NAME = 'Full Backup of AssessmentDB';";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(backupQuery, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void BtnSaveConfig_Click(object sender, EventArgs e)
        {
            // Logic to save Academic Term and Grading Rules to DB
            string newTerm = txtCurrentTerm.Text;
            int passingScore = (int)numPassingScore.Value;

            // Save logic here (e.g., Update Database Table 'SystemConfig')
            MessageBox.Show("System configuration updated.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This allows admins to adjust how scores convert to grades
        private void BtnUpdateGrading_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading scale weights updated successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}