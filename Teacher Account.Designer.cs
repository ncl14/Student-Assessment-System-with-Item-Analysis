namespace Student_Assessment_System_with_Item_Analysis
{
    partial class Teacher_Account
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
            this.lblUpcoming = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnTestC = new System.Windows.Forms.Button();
            this.btnTestAd = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblCalc = new System.Windows.Forms.Label();
            this.lblPhys = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lblRTR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpcoming
            // 
            this.lblUpcoming.AutoSize = true;
            this.lblUpcoming.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblUpcoming.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcoming.Location = new System.Drawing.Point(168, 41);
            this.lblUpcoming.Name = "lblUpcoming";
            this.lblUpcoming.Size = new System.Drawing.Size(131, 21);
            this.lblUpcoming.TabIndex = 0;
            this.lblUpcoming.Text = "Upcoming Tests";
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtb1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtb1.Location = new System.Drawing.Point(139, -2);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(804, 469);
            this.txtb1.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(130, 34);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "🏠︎ Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb2
            // 
            this.txtb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtb2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtb2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtb2.Location = new System.Drawing.Point(156, 32);
            this.txtb2.Multiline = true;
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(637, 72);
            this.txtb2.TabIndex = 3;
            this.txtb2.TextChanged += new System.EventHandler(this.txtb2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "👩🏻‍🏫 Teacher Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjects.Location = new System.Drawing.Point(3, 52);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Size = new System.Drawing.Size(130, 52);
            this.btnSubjects.TabIndex = 5;
            this.btnSubjects.Text = "📚 Subjects and Courses";
            this.btnSubjects.UseVisualStyleBackColor = false;
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuestion.Location = new System.Drawing.Point(3, 110);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(130, 53);
            this.btnQuestion.TabIndex = 6;
            this.btnQuestion.Text = "❔ Question Bank";
            this.btnQuestion.UseVisualStyleBackColor = false;
            // 
            // btnTestC
            // 
            this.btnTestC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTestC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestC.Location = new System.Drawing.Point(3, 169);
            this.btnTestC.Name = "btnTestC";
            this.btnTestC.Size = new System.Drawing.Size(130, 61);
            this.btnTestC.TabIndex = 7;
            this.btnTestC.Text = "📝Test Creation";
            this.btnTestC.UseVisualStyleBackColor = false;
            // 
            // btnTestAd
            // 
            this.btnTestAd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTestAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestAd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestAd.Location = new System.Drawing.Point(3, 236);
            this.btnTestAd.Name = "btnTestAd";
            this.btnTestAd.Size = new System.Drawing.Size(130, 55);
            this.btnTestAd.TabIndex = 8;
            this.btnTestAd.Text = "💻 Test Administration";
            this.btnTestAd.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(3, 297);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(130, 39);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "📊 Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(3, 342);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(130, 38);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // lblCalc
            // 
            this.lblCalc.AutoSize = true;
            this.lblCalc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCalc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalc.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCalc.Location = new System.Drawing.Point(169, 70);
            this.lblCalc.Name = "lblCalc";
            this.lblCalc.Size = new System.Drawing.Size(140, 17);
            this.lblCalc.TabIndex = 12;
            this.lblCalc.Text = "Calculus Quiz - DEC 26";
            // 
            // lblPhys
            // 
            this.lblPhys.AutoSize = true;
            this.lblPhys.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblPhys.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhys.Location = new System.Drawing.Point(340, 70);
            this.lblPhys.Name = "lblPhys";
            this.lblPhys.Size = new System.Drawing.Size(158, 17);
            this.lblPhys.TabIndex = 13;
            this.lblPhys.Text = "Physics Midterm - DEC 16";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblRes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(535, 70);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(199, 17);
            this.lblRes.TabIndex = 14;
            this.lblRes.Text = "Research Counsultation - DEC 10";
            // 
            // txt3
            // 
            this.txt3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.ForeColor = System.Drawing.Color.SteelBlue;
            this.txt3.Location = new System.Drawing.Point(156, 139);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(637, 140);
            this.txt3.TabIndex = 15;
            // 
            // lblRTR
            // 
            this.lblRTR.AutoSize = true;
            this.lblRTR.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblRTR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTR.Location = new System.Drawing.Point(168, 152);
            this.lblRTR.Name = "lblRTR";
            this.lblRTR.Size = new System.Drawing.Size(147, 21);
            this.lblRTR.TabIndex = 16;
            this.lblRTR.Text = "Recent Test Result";
            // 
            // Teacher_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRTR);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblPhys);
            this.Controls.Add(this.lblCalc);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnTestAd);
            this.Controls.Add(this.btnTestC);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnSubjects);
            this.Controls.Add(this.lblUpcoming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.txtb1);
            this.Name = "Teacher_Account";
            this.Text = "Teacher_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpcoming;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnTestC;
        private System.Windows.Forms.Button btnTestAd;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblCalc;
        private System.Windows.Forms.Label lblPhys;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lblRTR;
    }
}