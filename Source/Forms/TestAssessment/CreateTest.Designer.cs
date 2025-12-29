namespace Student_Assessment_System_with_Item_Analysis
{
    partial class Test_Administration
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TestCreationTab = new System.Windows.Forms.TabControl();
            this.tabTestInfo = new System.Windows.Forms.TabPage();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.txtboxInstructions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTestDetails = new System.Windows.Forms.Panel();
            this.numPassingScore = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtboxTestTitle = new System.Windows.Forms.TextBox();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.txtTestTitle = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.tabAddQuestions = new System.Windows.Forms.TabPage();
            this.pnlQuestionsMain = new System.Windows.Forms.Panel();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuestionToolbar = new System.Windows.Forms.Panel();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.TestCreationTab.SuspendLayout();
            this.tabTestInfo.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.pnlTestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabAddQuestions.SuspendLayout();
            this.pnlQuestionsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.pnlQuestionToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblStep);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(984, 80);
            this.pnlHeader.TabIndex = 20;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblStep
            // 
            this.lblStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStep.AutoSize = true;
            this.lblStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep.ForeColor = System.Drawing.Color.LightGray;
            this.lblStep.Location = new System.Drawing.Point(800, 30);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(76, 19);
            this.lblStep.TabIndex = 19;
            this.lblStep.Text = "Step 1 of 4";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Test Creation Wizard";
            // 
            // TestCreationTab
            // 
            this.TestCreationTab.Controls.Add(this.tabTestInfo);
            this.TestCreationTab.Controls.Add(this.tabAddQuestions);
            this.TestCreationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestCreationTab.ItemSize = new System.Drawing.Size(0, 1);
            this.TestCreationTab.Location = new System.Drawing.Point(0, 80);
            this.TestCreationTab.Name = "TestCreationTab";
            this.TestCreationTab.SelectedIndex = 0;
            this.TestCreationTab.Size = new System.Drawing.Size(984, 531);
            this.TestCreationTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TestCreationTab.TabIndex = 22;
            // 
            // tabTestInfo
            // 
            this.tabTestInfo.Controls.Add(this.pnlFooter);
            this.tabTestInfo.Controls.Add(this.pnlInstructions);
            this.tabTestInfo.Controls.Add(this.pnlTestDetails);
            this.tabTestInfo.Location = new System.Drawing.Point(4, 5);
            this.tabTestInfo.Name = "tabTestInfo";
            this.tabTestInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTestInfo.Size = new System.Drawing.Size(976, 522);
            this.tabTestInfo.TabIndex = 0;
            this.tabTestInfo.Text = "1. Test Information";
            this.tabTestInfo.UseVisualStyleBackColor = true;
            this.tabTestInfo.Click += new System.EventHandler(this.tabTestWizard_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnPublish);
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Controls.Add(this.btnBack);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(3, 459);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(970, 60);
            this.pnlFooter.TabIndex = 12;
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.Color.Green;
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.Location = new System.Drawing.Point(817, 14);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(100, 35);
            this.btnPublish.TabIndex = 3;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(668, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(518, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(37, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.White;
            this.pnlInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstructions.Controls.Add(this.txtboxInstructions);
            this.pnlInstructions.Controls.Add(this.label2);
            this.pnlInstructions.Location = new System.Drawing.Point(500, 40);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(420, 380);
            this.pnlInstructions.TabIndex = 5;
            // 
            // txtboxInstructions
            // 
            this.txtboxInstructions.Location = new System.Drawing.Point(20, 53);
            this.txtboxInstructions.Multiline = true;
            this.txtboxInstructions.Name = "txtboxInstructions";
            this.txtboxInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxInstructions.Size = new System.Drawing.Size(380, 300);
            this.txtboxInstructions.TabIndex = 3;
            this.txtboxInstructions.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instructions";
            // 
            // pnlTestDetails
            // 
            this.pnlTestDetails.BackColor = System.Drawing.Color.White;
            this.pnlTestDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTestDetails.Controls.Add(this.numPassingScore);
            this.pnlTestDetails.Controls.Add(this.label1);
            this.pnlTestDetails.Controls.Add(this.numericUpDown1);
            this.pnlTestDetails.Controls.Add(this.lblDuration);
            this.pnlTestDetails.Controls.Add(this.lblSubject);
            this.pnlTestDetails.Controls.Add(this.txtboxTestTitle);
            this.pnlTestDetails.Controls.Add(this.lblTestTitle);
            this.pnlTestDetails.Controls.Add(this.txtTestTitle);
            this.pnlTestDetails.Controls.Add(this.cmbSubject);
            this.pnlTestDetails.Location = new System.Drawing.Point(40, 40);
            this.pnlTestDetails.Name = "pnlTestDetails";
            this.pnlTestDetails.Size = new System.Drawing.Size(420, 380);
            this.pnlTestDetails.TabIndex = 4;
            // 
            // numPassingScore
            // 
            this.numPassingScore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPassingScore.Location = new System.Drawing.Point(19, 316);
            this.numPassingScore.Name = "numPassingScore";
            this.numPassingScore.Size = new System.Drawing.Size(120, 25);
            this.numPassingScore.TabIndex = 10;
            this.numPassingScore.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Passing Score (%)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(19, 241);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(15, 219);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(115, 17);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration (minutes)";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(15, 145);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(50, 17);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject";
            // 
            // txtboxTestTitle
            // 
            this.txtboxTestTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTestTitle.Location = new System.Drawing.Point(20, 91);
            this.txtboxTestTitle.Name = "txtboxTestTitle";
            this.txtboxTestTitle.Size = new System.Drawing.Size(360, 25);
            this.txtboxTestTitle.TabIndex = 5;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.Location = new System.Drawing.Point(16, 69);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(59, 17);
            this.lblTestTitle.TabIndex = 4;
            this.lblTestTitle.Text = "Test Title";
            // 
            // txtTestTitle
            // 
            this.txtTestTitle.AutoSize = true;
            this.txtTestTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTestTitle.Location = new System.Drawing.Point(15, 15);
            this.txtTestTitle.Name = "txtTestTitle";
            this.txtTestTitle.Size = new System.Drawing.Size(97, 21);
            this.txtTestTitle.TabIndex = 1;
            this.txtTestTitle.Text = "Test Details";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(19, 167);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(360, 25);
            this.cmbSubject.TabIndex = 3;
            // 
            // tabAddQuestions
            // 
            this.tabAddQuestions.Controls.Add(this.pnlQuestionsMain);
            this.tabAddQuestions.Location = new System.Drawing.Point(4, 5);
            this.tabAddQuestions.Name = "tabAddQuestions";
            this.tabAddQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddQuestions.Size = new System.Drawing.Size(976, 522);
            this.tabAddQuestions.TabIndex = 1;
            this.tabAddQuestions.Text = "2. Add Questions";
            this.tabAddQuestions.UseVisualStyleBackColor = true;
            // 
            // pnlQuestionsMain
            // 
            this.pnlQuestionsMain.BackColor = System.Drawing.Color.White;
            this.pnlQuestionsMain.Controls.Add(this.dgvQuestions);
            this.pnlQuestionsMain.Controls.Add(this.pnlQuestionToolbar);
            this.pnlQuestionsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestionsMain.Location = new System.Drawing.Point(3, 3);
            this.pnlQuestionsMain.Name = "pnlQuestionsMain";
            this.pnlQuestionsMain.Size = new System.Drawing.Size(970, 516);
            this.pnlQuestionsMain.TabIndex = 0;
            this.pnlQuestionsMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuestionsMain_Paint);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionText,
            this.QuestionType,
            this.Difficulty,
            this.Points});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 60);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(970, 456);
            this.dgvQuestions.TabIndex = 1;
            // 
            // QuestionText
            // 
            this.QuestionText.HeaderText = "Question";
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            // 
            // QuestionType
            // 
            this.QuestionType.HeaderText = "Type";
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.ReadOnly = true;
            // 
            // Difficulty
            // 
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            // 
            // pnlQuestionToolbar
            // 
            this.pnlQuestionToolbar.BackColor = System.Drawing.Color.LightGray;
            this.pnlQuestionToolbar.Controls.Add(this.lblQuestionCount);
            this.pnlQuestionToolbar.Controls.Add(this.btnRemoveQuestion);
            this.pnlQuestionToolbar.Controls.Add(this.btnEditQuestion);
            this.pnlQuestionToolbar.Controls.Add(this.btnAddQuestion);
            this.pnlQuestionToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionToolbar.Name = "pnlQuestionToolbar";
            this.pnlQuestionToolbar.Size = new System.Drawing.Size(970, 60);
            this.pnlQuestionToolbar.TabIndex = 0;
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionCount.Location = new System.Drawing.Point(794, 21);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(85, 17);
            this.lblQuestionCount.TabIndex = 1;
            this.lblQuestionCount.Text = "Questions: 0";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.BackColor = System.Drawing.Color.Red;
            this.btnRemoveQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuestion.ForeColor = System.Drawing.Color.White;
            this.btnRemoveQuestion.Location = new System.Drawing.Point(440, 13);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(90, 35);
            this.btnRemoveQuestion.TabIndex = 2;
            this.btnRemoveQuestion.Text = "Remove";
            this.btnRemoveQuestion.UseVisualStyleBackColor = false;
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.BackColor = System.Drawing.Color.Gray;
            this.btnEditQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuestion.ForeColor = System.Drawing.Color.White;
            this.btnEditQuestion.Location = new System.Drawing.Point(248, 13);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(90, 35);
            this.btnEditQuestion.TabIndex = 1;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = false;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.Blue;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(29, 13);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(130, 35);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "+ Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(817, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Publish";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(668, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(518, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(37, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Test_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestCreationTab);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Test_Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Test";
            this.Load += new System.EventHandler(this.Test_Administration_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.TestCreationTab.ResumeLayout(false);
            this.tabTestInfo.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.pnlTestDetails.ResumeLayout(false);
            this.pnlTestDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabAddQuestions.ResumeLayout(false);
            this.pnlQuestionsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.pnlQuestionToolbar.ResumeLayout(false);
            this.pnlQuestionToolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl TestCreationTab;
        private System.Windows.Forms.TabPage tabTestInfo;
        private System.Windows.Forms.TabPage tabAddQuestions;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label txtTestTitle;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel pnlTestDetails;
        private System.Windows.Forms.TextBox txtboxTestTitle;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.NumericUpDown numPassingScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtboxInstructions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Panel pnlQuestionsMain;
        private System.Windows.Forms.Panel pnlQuestionToolbar;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}