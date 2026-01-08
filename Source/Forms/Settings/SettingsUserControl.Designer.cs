namespace StudentAssessmentSystem
{
    partial class SettingsUserControl
    {
        private System.ComponentModel.IContainer components = null;

        // UI Controls
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabDatabase;
        private System.Windows.Forms.GroupBox grpTerm;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.TextBox txtCurrentTerm;
        private System.Windows.Forms.GroupBox grpGrading;
        private System.Windows.Forms.Label lblPassing;
        private System.Windows.Forms.NumericUpDown numPassingScore;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblBackupInfo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Panel pnlDatabaseContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.grpGrading = new System.Windows.Forms.GroupBox();
            this.numPassingScore = new System.Windows.Forms.NumericUpDown();
            this.lblPassing = new System.Windows.Forms.Label();
            this.grpTerm = new System.Windows.Forms.GroupBox();
            this.txtCurrentTerm = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.tabDatabase = new System.Windows.Forms.TabPage();
            this.pnlDatabaseContent = new System.Windows.Forms.Panel();
            this.lblBackupInfo = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tabSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.grpGrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).BeginInit();
            this.grpTerm.SuspendLayout();
            this.tabDatabase.SuspendLayout();
            this.pnlDatabaseContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabDatabase);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.ItemSize = new System.Drawing.Size(120, 30);
            this.tabSettings.Location = new System.Drawing.Point(20, 80);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(760, 500);
            this.tabSettings.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controls.Add(this.btnSaveConfig);
            this.tabGeneral.Controls.Add(this.grpGrading);
            this.tabGeneral.Controls.Add(this.grpTerm);
            this.tabGeneral.Location = new System.Drawing.Point(4, 34);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(20);
            this.tabGeneral.Size = new System.Drawing.Size(752, 462);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General Config";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSaveConfig.FlatAppearance.BorderSize = 0;
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfig.Location = new System.Drawing.Point(20, 320);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(180, 45);
            this.btnSaveConfig.TabIndex = 2;
            this.btnSaveConfig.Text = "Save Changes";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.BtnSaveConfig_Click);
            // 
            // grpGrading
            // 
            this.grpGrading.Controls.Add(this.numPassingScore);
            this.grpGrading.Controls.Add(this.lblPassing);
            this.grpGrading.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpGrading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpGrading.Location = new System.Drawing.Point(20, 160);
            this.grpGrading.Name = "grpGrading";
            this.grpGrading.Padding = new System.Windows.Forms.Padding(15);
            this.grpGrading.Size = new System.Drawing.Size(500, 120);
            this.grpGrading.TabIndex = 1;
            this.grpGrading.TabStop = false;
            this.grpGrading.Text = "Grading Standards";
            // 
            // numPassingScore
            // 
            this.numPassingScore.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numPassingScore.Location = new System.Drawing.Point(20, 65);
            this.numPassingScore.Name = "numPassingScore";
            this.numPassingScore.Size = new System.Drawing.Size(120, 27);
            this.numPassingScore.TabIndex = 1;
            // 
            // lblPassing
            // 
            this.lblPassing.AutoSize = true;
            this.lblPassing.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPassing.Location = new System.Drawing.Point(17, 35);
            this.lblPassing.Name = "lblPassing";
            this.lblPassing.Size = new System.Drawing.Size(161, 17);
            this.lblPassing.TabIndex = 0;
            this.lblPassing.Text = "Default Passing Score (%):";
            // 
            // grpTerm
            // 
            this.grpTerm.Controls.Add(this.txtCurrentTerm);
            this.grpTerm.Controls.Add(this.lblTerm);
            this.grpTerm.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpTerm.Location = new System.Drawing.Point(20, 20);
            this.grpTerm.Name = "grpTerm";
            this.grpTerm.Padding = new System.Windows.Forms.Padding(15);
            this.grpTerm.Size = new System.Drawing.Size(500, 120);
            this.grpTerm.TabIndex = 0;
            this.grpTerm.TabStop = false;
            this.grpTerm.Text = "Academic Settings";
            // 
            // txtCurrentTerm
            // 
            this.txtCurrentTerm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCurrentTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentTerm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentTerm.Location = new System.Drawing.Point(20, 65);
            this.txtCurrentTerm.Name = "txtCurrentTerm";
            this.txtCurrentTerm.Size = new System.Drawing.Size(400, 27);
            this.txtCurrentTerm.TabIndex = 1;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTerm.Location = new System.Drawing.Point(17, 35);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(130, 17);
            this.lblTerm.TabIndex = 0;
            this.lblTerm.Text = "Current Term Name:";
            // 
            // tabDatabase
            // 
            this.tabDatabase.BackColor = System.Drawing.Color.White;
            this.tabDatabase.Controls.Add(this.pnlDatabaseContent);
            this.tabDatabase.Location = new System.Drawing.Point(4, 34);
            this.tabDatabase.Name = "tabDatabase";
            this.tabDatabase.Padding = new System.Windows.Forms.Padding(40);
            this.tabDatabase.Size = new System.Drawing.Size(752, 462);
            this.tabDatabase.TabIndex = 1;
            this.tabDatabase.Text = "Database Maintenance";
            // 
            // pnlDatabaseContent
            // 
            this.pnlDatabaseContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDatabaseContent.Controls.Add(this.lblBackupInfo);
            this.pnlDatabaseContent.Controls.Add(this.btnBackup);
            this.pnlDatabaseContent.Location = new System.Drawing.Point(40, 40);
            this.pnlDatabaseContent.Name = "pnlDatabaseContent";
            this.pnlDatabaseContent.Size = new System.Drawing.Size(600, 200);
            this.pnlDatabaseContent.TabIndex = 2;
            // 
            // lblBackupInfo
            // 
            this.lblBackupInfo.AutoSize = true;
            this.lblBackupInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBackupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBackupInfo.Location = new System.Drawing.Point(30, 30);
            this.lblBackupInfo.Name = "lblBackupInfo";
            this.lblBackupInfo.Size = new System.Drawing.Size(465, 20);
            this.lblBackupInfo.TabIndex = 0;
            this.lblBackupInfo.Text = "Create a secure backup of the entire system database (.bak file format).";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(34, 80);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(220, 50);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "⤓  Backup Database";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(227, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "System Configuration";
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.pnlHeader);
            this.Name = "SettingsUserControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.Size = new System.Drawing.Size(800, 600);
            this.tabSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.grpGrading.ResumeLayout(false);
            this.grpGrading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPassingScore)).EndInit();
            this.grpTerm.ResumeLayout(false);
            this.grpTerm.PerformLayout();
            this.tabDatabase.ResumeLayout(false);
            this.pnlDatabaseContent.ResumeLayout(false);
            this.pnlDatabaseContent.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}