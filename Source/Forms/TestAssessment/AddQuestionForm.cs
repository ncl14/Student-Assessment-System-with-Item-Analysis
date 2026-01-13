using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Assessment_System_with_Item_Analysis.Source.Models;

namespace Student_Assessment_System_with_Item_Analysis.Source.Forms.TestAssessment
{
    public partial class AddQuestionForm : Form
    {
        public MultipleChoiceQuestion CreatedQuestion { get; private set; }

        public AddQuestionForm(MultipleChoiceQuestion existingQuestion = null)
        {
            InitializeComponent();
            
            // Initialize Grid rows if new
            if (existingQuestion == null)
            {
                for (int i = 0; i < 4; i++)
                {
                    dgvChoices.Rows.Add();
                }
                cmbDifficulty.SelectedIndex = 1; // Average
                cmbCognitive.SelectedIndex = 0; // Remember
            }
            else
            {
                LoadQuestion(existingQuestion);
            }
        }

        private void LoadQuestion(MultipleChoiceQuestion q)
        {
            txtQuestionText.Text = q.QuestionText;
            numPoints.Value = (decimal)q.Points;
            txtTopic.Text = q.Topic;
            
            if (cmbDifficulty.Items.Contains(q.DifficultyLevel))
                cmbDifficulty.SelectedItem = q.DifficultyLevel;
                
            if (cmbCognitive.Items.Contains(q.CognitiveLevel))
                cmbCognitive.SelectedItem = q.CognitiveLevel;

            dgvChoices.Rows.Clear();
            if (q.Choices != null)
            {
                foreach (var choice in q.Choices)
                {
                    int idx = dgvChoices.Rows.Add();
                    dgvChoices.Rows[idx].Cells[0].Value = choice.ChoiceText;
                    dgvChoices.Rows[idx].Cells[1].Value = choice.IsCorrect;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            CreatedQuestion = new MultipleChoiceQuestion
            {
                QuestionText = txtQuestionText.Text.Trim(),
                Points = numPoints.Value,
                DifficultyLevel = cmbDifficulty.SelectedItem?.ToString(),
                CognitiveLevel = cmbCognitive.SelectedItem?.ToString(),
                Topic = txtTopic.Text.Trim(),
                Choices = new List<QuestionChoice>()
            };

            foreach (DataGridViewRow row in dgvChoices.Rows)
            {
                if (row.IsNewRow) continue;
                
                string text = row.Cells[0].Value?.ToString();
                if (string.IsNullOrWhiteSpace(text)) continue;

                bool isCorrect = (bool)(row.Cells[1].Value ?? false);

                CreatedQuestion.Choices.Add(new QuestionChoice
                {
                    ChoiceText = text,
                    IsCorrect = isCorrect
                });
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtQuestionText.Text))
            {
                MessageBox.Show("Please enter the question text.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int correctCount = 0;
            int choiceCount = 0;

            foreach (DataGridViewRow row in dgvChoices.Rows)
            {
                if (row.IsNewRow) continue;
                string text = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(text))
                {
                    choiceCount++;
                    if ((bool)(row.Cells[1].Value ?? false))
                        correctCount++;
                }
            }

            if (choiceCount < 2)
            {
                MessageBox.Show("Please provide at least 2 choices.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (correctCount != 1)
            {
                MessageBox.Show("Please mark exactly one choice as correct.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
