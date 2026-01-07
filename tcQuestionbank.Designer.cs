namespace Student_Assessment_System_with_Item_Analysis
{
    partial class tcQuestionbank
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbuildquiz = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblQuestionsinGroup = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnswerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1543, 80);
            this.pnlHeader.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "❔ Question Bank";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblbuildquiz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 80);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblbuildquiz
            // 
            this.lblbuildquiz.AutoSize = true;
            this.lblbuildquiz.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblbuildquiz.Location = new System.Drawing.Point(267, 40);
            this.lblbuildquiz.Name = "lblbuildquiz";
            this.lblbuildquiz.Size = new System.Drawing.Size(212, 13);
            this.lblbuildquiz.TabIndex = 22;
            this.lblbuildquiz.Text = "Build quiz question bank and use in quizzes";
            this.lblbuildquiz.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(79, 139);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(132, 48);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "+ Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(347, 139);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(132, 48);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "🚮 Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // lblQuestionsinGroup
            // 
            this.lblQuestionsinGroup.AutoSize = true;
            this.lblQuestionsinGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsinGroup.Location = new System.Drawing.Point(76, 205);
            this.lblQuestionsinGroup.Name = "lblQuestionsinGroup";
            this.lblQuestionsinGroup.Size = new System.Drawing.Size(238, 15);
            this.lblQuestionsinGroup.TabIndex = 24;
            this.lblQuestionsinGroup.Text = "Questions in Group <Show All Questions>";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colQuestion,
            this.colAnswerType,
            this.colPoints,
            this.colAction});
            this.dataGridView1.Location = new System.Drawing.Point(79, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 377);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "Column1";
            this.colCheck.Name = "colCheck";
            // 
            // colQuestion
            // 
            this.colQuestion.HeaderText = "Question";
            this.colQuestion.Name = "colQuestion";
            // 
            // colAnswerType
            // 
            this.colAnswerType.HeaderText = "AnswerType";
            this.colAnswerType.Name = "colAnswerType";
            // 
            // colPoints
            // 
            this.colPoints.HeaderText = "Points";
            this.colPoints.Name = "colPoints";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Button";
            this.colAction.Name = "colAction";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(76, 110);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(385, 13);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "Store and manage questions that can be reused in the course to assess learners";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // tcQuestionbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 852);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblQuestionsinGroup);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlHeader);
            this.Name = "tcQuestionbank";
            this.Text = "tcQuestionbank";
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblbuildquiz;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblQuestionsinGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.Label lbl;
    }
}