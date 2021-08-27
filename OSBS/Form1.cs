using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace OSBS

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\leteb\Documents\Login.mdf;Integrated Security=True;User Instance=True");
            DataTable dt = new DataTable();
            con.Open();
            string str = "SELECT emp_id FROM Employee WHERE emp_username = '" + txtUser.Text + "' and emp_password = '" + txtPass.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Visible = false;
                Dashboard obj2 = new Dashboard();
                obj2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter correct username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
                

                                                                                                                                                                                                                                                                                                                                                                                    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
