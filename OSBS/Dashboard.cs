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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Information a1 = new Student_Information();
            a1.ShowDialog();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounts a1 = new Accounts();
            a1.ShowDialog();
        }

        private void lblAccess_Click(object sender, EventArgs e)
        {
            this.Hide();
            Access a1 = new Access();
            a1.ShowDialog();
        }

        private void lblRegist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration a1 = new Registration();
            a1.ShowDialog();
        }

        private void lblModules_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course a1 = new Course();
            a1.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 a1 = new Form1();
            a1.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
