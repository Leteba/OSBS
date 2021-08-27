using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSBS
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void lblCT1_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtResults.Text += "*************************************\n";
            txtResults.Text += "******       Access Cards       *****\n";
            txtResults.Text += "**   Continues Assessment test 1   **\n";
            txtResults.Text += "*************************************\n";
            txtResults.Text += "Date: " + DateTime.Now;

            txtResults.Text += "Student Name: " + txtNS.Text + "\n\n";
            txtResults.Text += "Icas Number: " + txtIcas.Text + "\n\n";
            txtResults.Text += "Mobile Number: " + txtID.Text + "\n\n";
            txtResults.Text += "Fees R: " + txtModule.Text + "\n\n";
;
            txtResults.Text += "*************************************\n";
            txtResults.Text += "************Access Code**************\n";
            txtResults.Text += "*********1123_5443_7488_4341*********\n";
            txtResults.Text += "*************************************\n";
        }

        private void lblCT2_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtResults.Text += "*************************************\n";
            txtResults.Text += "******       Access Cards       *****\n";
            txtResults.Text += "**   Continues Assessment test 2   **\n";
            txtResults.Text += "*************************************\n";
            txtResults.Text += "Date: " + DateTime.Now + "\n\n";

            txtResults.Text += "Student Name: " + txtNS.Text + "\n\n";
            txtResults.Text += "Icas Number: " + txtIcas.Text + "\n\n";
            txtResults.Text += "Mobile Number: " + txtID.Text + "\n\n";
            txtResults.Text += "Fees R: " + txtModule.Text + "\n\n";

            txtResults.Text += "*************************************\n";
            txtResults.Text += "************Access Code**************\n";
            txtResults.Text += "*********1124_5443_7497_4342*********\n";
            txtResults.Text += "*************************************\n";
        }

        private void lblFE_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtResults.Text += "*************************************\n";
            txtResults.Text += "******       Access Cards       *****\n";
            txtResults.Text += "****    Semester 1 Examination   ****\n";
            txtResults.Text += "*************************************\n";
            txtResults.Text += "Date: " + DateTime.Now;

            txtResults.Text += "Student Name: " + txtNS.Text + "\n\n";
            txtResults.Text += "Icas Number: " + txtIcas.Text + "\n\n";
            txtResults.Text += "Mobile Number: " + txtID.Text + "\n\n";
            txtResults.Text += "Fees R: " + txtModule.Text + "\n\n";

            txtResults.Text += "*************************************\n";
            txtResults.Text += "************Access Code**************\n";
            txtResults.Text += "*********1122_5443_7477_8981*********\n";
            txtResults.Text += "*************************************\n";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            txtNS.Text = "";
            txtIcas.Text = "";
            txtModule.Text = "";
            txtIcas.Text = "";
            txtResults.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResults.Text, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void lblFE2_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtResults.Text += "*************************************\n";
            txtResults.Text += "******       Access Cards       *****\n";
            txtResults.Text += "****    Semester 2 Examination   ****\n";
            txtResults.Text += "*************************************\n";
            txtResults.Text += "Date: " + DateTime.Now;

            txtResults.Text += "Student Name: " + txtNS.Text + "\n\n";
            txtResults.Text += "Icas Number: " + txtIcas.Text + "\n\n";
            txtResults.Text += "Mobile Number: " + txtID.Text + "\n\n";
            txtResults.Text += "Fees R: " + txtModule.Text + "\n\n";
       
            txtResults.Text += "*************************************\n";
            txtResults.Text += "********      Access Code    ********\n";
            txtResults.Text += "*******  1122_5443_7488_8982  *******\n";
            txtResults.Text += "*************************************\n";

            
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
           
        }

        private void lblBackk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void lblNextt_Click(object sender, EventArgs e)
        {

        }
    }
}
