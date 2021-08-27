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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFees_Click(object sender, EventArgs e)
        {
            txtResults.Clear();
            txtResults.Text += "*************************************\n";
            txtResults.Text += "******       Fees Receipt       *****\n"; 
            txtResults.Text += "*************************************\n";
            txtResults.Text += "Date: " + DateTime.Now;

            txtResults.Text += "Student Name: "+ txtStuName.Text + "\n\n";
            txtResults.Text += "Icas Number: "+ txtIcasNo.Text + "\n\n";
            txtResults.Text += "Mobile Number: "+ txtMobile.Text + "\n\n";
            txtResults.Text += "Fees R: " + txtFees.Text + "\n\n";

            txtResults.Text += "\n _____________________________ Signature";
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            txtStuName.Text = "";
            txtIcasNo.Text = "";
            txtMobile.Text = "";
            txtFees.Text = "";
            txtResults.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResults.Text, new Font("Consolas" , 16, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void lblBursary_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }
    }
}
