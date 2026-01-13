namespace Student_Assessment_System_with_Item_Analysis.Source.Forms.TestAssessment
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblCognitive = new System.Windows.Forms.Label();
            this.cmbCognitive = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.grpChoices = new System.Windows.Forms.GroupBox();
            this.dgvChoices = new System.Windows.Forms.DataGridView();
            this.colChoiceText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsCorrect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.grpChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(20, 20);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(96, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question Text:";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuestionText.Location = new System.Drawing.Point(23, 40);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionText.Size = new System.Drawing.Size(540, 80);
            this.txtQuestionText.TabIndex = 1;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(20, 140);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(39, 13);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "Points:";
            // 
            // numPoints
            // 
            this.numPoints.DecimalPlaces = 1;
            this.numPoints.Location = new System.Drawing.Point(23, 156);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(80, 20);
            this.numPoints.TabIndex = 3;
            this.numPoints.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(130, 140);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] { "Easy", "Average", "Difficult" });
            this.cmbDifficulty.Location = new System.Drawing.Point(133, 155);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(120, 21);
            this.cmbDifficulty.TabIndex = 5;
            // 
            // lblCognitive
            // 
            this.lblCognitive.AutoSize = true;
            this.lblCognitive.Location = new System.Drawing.Point(270, 140);
            this.lblCognitive.Name = "lblCognitive";
            this.lblCognitive.Size = new System.Drawing.Size(83, 13);
            this.lblCognitive.TabIndex = 6;
            this.lblCognitive.Text = "Cognitive Level:";
            // 
            // cmbCognitive
            // 
            this.cmbCognitive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCognitive.FormattingEnabled = true;
            this.cmbCognitive.Items.AddRange(new object[] { "Remember", "Understand", "Apply", "Analyze", "Evaluate", "Create" });
            this.cmbCognitive.Location = new System.Drawing.Point(273, 155);
            this.cmbCognitive.Name = "cmbCognitive";
            this.cmbCognitive.Size = new System.Drawing.Size(120, 21);
            this.cmbCognitive.TabIndex = 7;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(410, 140);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(37, 13);
            this.lblTopic.TabIndex = 8;
            this.lblTopic.Text = "Topic:";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(413, 156);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(150, 20);
            this.txtTopic.TabIndex = 9;
            // 
            // grpChoices
            // 
            this.grpChoices.Controls.Add(this.dgvChoices);
            this.grpChoices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoices.Location = new System.Drawing.Point(23, 200);
            this.grpChoices.Name = "grpChoices";
            this.grpChoices.Size = new System.Drawing.Size(540, 200);
            this.grpChoices.TabIndex = 10;
            this.grpChoices.TabStop = false;
            this.grpChoices.Text = "Choices (Check the correct answer)";
            // 
            // dgvChoices
            // 
            this.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChoiceText,
            this.colIsCorrect});
            this.dgvChoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoices.Location = new System.Drawing.Point(3, 19);
            this.dgvChoices.Name = "dgvChoices";
            this.dgvChoices.Size = new System.Drawing.Size(534, 178);
            this.dgvChoices.TabIndex = 0;
            // 
            // colChoiceText
            // 
            this.colChoiceText.HeaderText = "Choice Text";
            this.colChoiceText.Name = "colChoiceText";
            this.colChoiceText.Width = 400;
            // 
            // colIsCorrect
            // 
            this.colIsCorrect.HeaderText = "Initial";
            this.colIsCorrect.Name = "colIsCorrect";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(383, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(480, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpChoices);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.cmbCognitive);
            this.Controls.Add(this.lblCognitive);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.lblQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Question";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.grpChoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblCognitive;
        private System.Windows.Forms.ComboBox cmbCognitive;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.GroupBox grpChoices;
        private System.Windows.Forms.DataGridView dgvChoices;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChoiceText;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCorrect;
    }
}
