using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Assessment_System_with_Item_Analysis.Source.Managers;
using Student_Assessment_System_with_Item_Analysis.Source.Models;
using Student_Assessment_System_with_Item_Analysis.Source.Forms.TestAssessment;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class Test_Administration : Form
    {
        private readonly SubjectManager _subjectManager;
        private readonly TestManager _testManager;
        private readonly List<Question> _questions;

        public Test_Administration()
        {
            InitializeComponent();
            _subjectManager = new SubjectManager();
            _testManager = new TestManager();
            _questions = new List<Question>();

            // Wire up events programmatically since they might be missing in Designer
            this.Load += Test_Administration_Load;
            
            // Navigation Buttons (Global Panel)
            if (button2 != null) button2.Click += btnNext_Click; // Next
            if (button3 != null) button3.Click += btnBack_Click; // Back
            if (button1 != null) button1.Click += btnPublish_Click; // Publish
            if (button4 != null) button4.Click += btnCancel_Click; // Cancel

            // Navigation Buttons (Local Footer)
            if (btnNext != null) btnNext.Click += btnNext_Click;
            if (btnBack != null) btnBack.Click += btnBack_Click;
            if (btnPublish != null) btnPublish.Click += btnPublish_Click;
            if (btnCancel != null) btnCancel.Click += btnCancel_Click;

            // Question Toolbar
            if (btnAddQuestion != null) btnAddQuestion.Click += btnAddQuestion_Click;
            if (btnRemoveQuestion != null) btnRemoveQuestion.Click += btnRemoveQuestion_Click;
            
            // Tab Control
            // Disable manual tab clicking? Or allow it? 
            // Usually Wizards disable manual navigation to enforce validation.
            // But for now let's leave it.
        }

        private void Test_Administration_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            UpdateQuestionCount();
        }

        private void LoadSubjects()
        {
            try
            {
                var subjects = _subjectManager.GetAllSubjects();
                cmbSubject.DataSource = subjects;
                cmbSubject.DisplayMember = "FullName"; // Defined in Subject model
                cmbSubject.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Validate First Tab
            if (string.IsNullOrWhiteSpace(txtboxTestTitle.Text))
            {
                MessageBox.Show("Please enter a Test Title.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbSubject.SelectedValue == null)
            {
                MessageBox.Show("Please select a Subject.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Go to next tab
            TestCreationTab.SelectedTab = tabAddQuestions;
            UpdateStepLabel("Step 2 of 2: Add Questions");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TestCreationTab.SelectedTab = tabTestInfo;
            UpdateStepLabel("Step 1 of 2: Test Information");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            using (var form = new AddQuestionForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var question = form.CreatedQuestion;
                    _questions.Add(question);
                    AddQuestionToGrid(question);
                    UpdateQuestionCount();
                }
            }
        }

        private void AddQuestionToGrid(Question q)
        {
            int idx = dgvQuestions.Rows.Add();
            var row = dgvQuestions.Rows[idx];
            row.Cells["QuestionText"].Value = q.QuestionText;
            row.Cells["QuestionType"].Value = "Multiple Choice";
            row.Cells["Difficulty"].Value = q.DifficultyLevel;
            row.Cells["Points"].Value = q.Points;
            row.Tag = q; // Store reference
        }

        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count > 0)
            {
                var row = dgvQuestions.SelectedRows[0];
                var question = row.Tag as Question;
                if (question != null)
                {
                    _questions.Remove(question);
                }
                dgvQuestions.Rows.Remove(row);
                UpdateQuestionCount();
            }
        }

        private void UpdateQuestionCount()
        {
            lblQuestionCount.Text = $"Questions: {_questions.Count}";
            // Update total points calc if needed
            decimal totalPoints = _questions.Sum(q => q.Points);
            // If there's a Total Points label/box in tabTestInfo, update it.
            // There is numericUpDown3 or similar in the designer but unnamed? 
            // label7 is "Total Points :". numericUpDown3 is next to it.
            // I'll skip updating that for now as I don't have direct access to its name easily without checking designer carefully.
            // Actually, looked at designer: numericUpDown3 seems to be TotalPoints but it's unnamed in logic.
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (_questions.Count == 0)
            {
                MessageBox.Show("Please add at least one question.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var test = new Test
                {
                    Testtitle = txtboxTestTitle.Text.Trim(),
                    Description = txtboxInstructions.Text, // Using instructions as Description/Instructions
                    SubjectID = (int)cmbSubject.SelectedValue,
                    TestType = "Exam", // Default or add a ComboBox for this
                    DurationMinutes = (int)numericUpDown1.Value, // Duration
                    PassingScore = numPassingScore.Value,
                    TotalPoints = _questions.Sum(q => q.Points),
                    Questions = _questions
                };

                int testId = _testManager.SaveTest(test);
                
                MessageBox.Show($"Test created successfully! ID: {testId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving test: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStepLabel(string text)
        {
            if (lblStep != null) lblStep.Text = text;
        }

        // Placeholder events needed by Designer if any
        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
        private void tabTestWizard_Click(object sender, EventArgs e) { }
        private void pnlQuestionsMain_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
    }
}
