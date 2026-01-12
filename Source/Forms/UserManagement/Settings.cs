using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis.Source.Forms.UserManagement
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Are you sure you want to logout?",
             "Logout Confirmation",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }

}