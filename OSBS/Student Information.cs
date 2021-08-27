using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OSBS
{
    public partial class Student_Information : Form
    {
        public Student_Information()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
               
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        
        }
    }
}
