using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Assessment_System_with_Item_Analysis
{
    public partial class tcQuestionbank : Form
    {
        public tcQuestionbank()
        {

            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(false, "convert 1110010101 to denary", "Open Question", 5);
            dataGridView1.Rows.Add(false, "convert 127 to binary", "Open Question", 5);
            dataGridView1.Rows.Add(false, "convert 17 to binary", "Open Question", 5);
            dataGridView1.Rows.Add(false, "convert 10000101010 to denary", "Open Question", 5);
            dataGridView1.Rows.Add(false, "Describe the FDE (fetch-decode-execute) cycle", "Open Question", 10);
            dataGridView1.Rows.Add(false, "The first human life to set foot in North America is most likely from...", "Select One", 10);
            dataGridView1.Rows.Add(false, "Which historical event took place in 1982, December 3rd", "Open Question", 10);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colAnswerType")
            {
                if (e.Value.ToString() == "Open Question")
                {
                    e.CellStyle.BackColor = Color.DodgerBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.SeaGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

      
 
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colAction")
            {
                MessageBox.Show("Edit Question clicked");
            }
        }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
