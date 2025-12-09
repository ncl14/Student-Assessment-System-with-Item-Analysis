namespace Student_Assessment_System_with_Item_Analysis.Forms.SubjectManagement
{
    partial class SubjectManagementForm
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
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.Color.SteelBlue;
            this.txtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtb1.Location = new System.Drawing.Point(-2, -11);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(208, 469);
            this.txtb1.TabIndex = 3;
            // 
            // SubjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb1);
            this.Name = "SubjectManagementForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb1;
    }
}