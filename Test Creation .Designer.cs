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
            this.lblTestAd = new System.Windows.Forms.Label();
            this.lblTestSetup = new System.Windows.Forms.Label();
            this.lblConfig = new System.Windows.Forms.Label();
            this.radioButtonRandomQues = new System.Windows.Forms.RadioButton();
            this.radioButton2RandomChoices = new System.Windows.Forms.RadioButton();
            this.radioButtonShow = new System.Windows.Forms.RadioButton();
            this.radioButtonAllow = new System.Windows.Forms.RadioButton();
            this.lblTestName = new System.Windows.Forms.Label();
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSub = new System.Windows.Forms.Label();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTestAd
            // 
            this.lblTestAd.AutoSize = true;
            this.lblTestAd.BackColor = System.Drawing.Color.White;
            this.lblTestAd.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAd.ForeColor = System.Drawing.Color.Black;
            this.lblTestAd.Location = new System.Drawing.Point(58, 25);
            this.lblTestAd.Name = "lblTestAd";
            this.lblTestAd.Size = new System.Drawing.Size(270, 37);
            this.lblTestAd.TabIndex = 0;
            this.lblTestAd.Text = "Test Administration";
            this.lblTestAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTestSetup
            // 
            this.lblTestSetup.AutoSize = true;
            this.lblTestSetup.BackColor = System.Drawing.Color.White;
            this.lblTestSetup.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestSetup.ForeColor = System.Drawing.Color.Black;
            this.lblTestSetup.Location = new System.Drawing.Point(96, 92);
            this.lblTestSetup.Name = "lblTestSetup";
            this.lblTestSetup.Size = new System.Drawing.Size(114, 30);
            this.lblTestSetup.TabIndex = 3;
            this.lblTestSetup.Text = "Test Setup";
            this.lblTestSetup.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.BackColor = System.Drawing.Color.White;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.ForeColor = System.Drawing.Color.Black;
            this.lblConfig.Location = new System.Drawing.Point(486, 32);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(231, 30);
            this.lblConfig.TabIndex = 11;
            this.lblConfig.Text = "⛯ Configure Settings ";
            // 
            // radioButtonRandomQues
            // 
            this.radioButtonRandomQues.AutoSize = true;
            this.radioButtonRandomQues.BackColor = System.Drawing.Color.White;
            this.radioButtonRandomQues.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRandomQues.ForeColor = System.Drawing.Color.Black;
            this.radioButtonRandomQues.Location = new System.Drawing.Point(429, 92);
            this.radioButtonRandomQues.Name = "radioButtonRandomQues";
            this.radioButtonRandomQues.Size = new System.Drawing.Size(177, 24);
            this.radioButtonRandomQues.TabIndex = 12;
            this.radioButtonRandomQues.TabStop = true;
            this.radioButtonRandomQues.Text = "Randomize questions";
            this.radioButtonRandomQues.UseVisualStyleBackColor = false;
            this.radioButtonRandomQues.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2RandomChoices
            // 
            this.radioButton2RandomChoices.AutoSize = true;
            this.radioButton2RandomChoices.BackColor = System.Drawing.Color.White;
            this.radioButton2RandomChoices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2RandomChoices.ForeColor = System.Drawing.Color.Black;
            this.radioButton2RandomChoices.Location = new System.Drawing.Point(429, 122);
            this.radioButton2RandomChoices.Name = "radioButton2RandomChoices";
            this.radioButton2RandomChoices.Size = new System.Drawing.Size(160, 24);
            this.radioButton2RandomChoices.TabIndex = 13;
            this.radioButton2RandomChoices.TabStop = true;
            this.radioButton2RandomChoices.Text = "Randomize choices";
            this.radioButton2RandomChoices.UseVisualStyleBackColor = false;
            this.radioButton2RandomChoices.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonShow
            // 
            this.radioButtonShow.AutoSize = true;
            this.radioButtonShow.BackColor = System.Drawing.Color.White;
            this.radioButtonShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShow.ForeColor = System.Drawing.Color.Black;
            this.radioButtonShow.Location = new System.Drawing.Point(429, 152);
            this.radioButtonShow.Name = "radioButtonShow";
            this.radioButtonShow.Size = new System.Drawing.Size(216, 44);
            this.radioButtonShow.TabIndex = 14;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "Show/hide correct answers\r\n after submission";
            this.radioButtonShow.UseVisualStyleBackColor = false;
            // 
            // radioButtonAllow
            // 
            this.radioButtonAllow.AutoSize = true;
            this.radioButtonAllow.BackColor = System.Drawing.Color.White;
            this.radioButtonAllow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAllow.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAllow.Location = new System.Drawing.Point(429, 202);
            this.radioButtonAllow.Name = "radioButtonAllow";
            this.radioButtonAllow.Size = new System.Drawing.Size(117, 24);
            this.radioButtonAllow.TabIndex = 15;
            this.radioButtonAllow.TabStop = true;
            this.radioButtonAllow.Text = "Allow review";
            this.radioButtonAllow.UseVisualStyleBackColor = false;
            this.radioButtonAllow.CheckedChanged += new System.EventHandler(this.radioButtonAllow_CheckedChanged);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(29, 144);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(92, 20);
            this.lblTestName.TabIndex = 16;
            this.lblTestName.Text = "Test Name: ";
            this.lblTestName.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbTestName
            // 
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(127, 143);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(182, 21);
            this.cmbTestName.TabIndex = 17;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(30, 413);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(22, 14);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "1/2";
            this.lbl1.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(676, 392);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 35);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.White;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.Location = new System.Drawing.Point(29, 187);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(68, 20);
            this.lblSub.TabIndex = 21;
            this.lblSub.Text = "Subject: ";
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Items.AddRange(new object[] {
            "IT 12",
            "IT 13"});
            this.cmbSub.Location = new System.Drawing.Point(127, 191);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(182, 21);
            this.cmbSub.TabIndex = 22;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(29, 234);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(79, 20);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Duration: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 423);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 15);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(364, 423);
            this.textBox2.TabIndex = 25;
            // 
            // lblPassing
            // 
            this.lblPassing.AutoSize = true;
            this.lblPassing.BackColor = System.Drawing.Color.White;
            this.lblPassing.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassing.Location = new System.Drawing.Point(29, 274);
            this.lblPassing.Name = "lblPassing";
            this.lblPassing.Size = new System.Drawing.Size(108, 20);
            this.lblPassing.TabIndex = 26;
            this.lblPassing.Text = "Passing Score:";
            // 
            // Test_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassing);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.cmbSub);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbTestName);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.radioButtonAllow);
            this.Controls.Add(this.radioButtonShow);
            this.Controls.Add(this.radioButton2RandomChoices);
            this.Controls.Add(this.radioButtonRandomQues);
            this.Controls.Add(this.lblConfig);
            this.Controls.Add(this.lblTestSetup);
            this.Controls.Add(this.lblTestAd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Name = "Test_Administration";
            this.Text = "Test_Creation";
            this.Load += new System.EventHandler(this.Test_Administration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestAd;
        private System.Windows.Forms.Label lblTestSetup;
        private System.Windows.Forms.Label lblConfig;
        private System.Windows.Forms.RadioButton radioButtonRandomQues;
        private System.Windows.Forms.RadioButton radioButton2RandomChoices;
        private System.Windows.Forms.RadioButton radioButtonShow;
        private System.Windows.Forms.RadioButton radioButtonAllow;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassing;
    }
}