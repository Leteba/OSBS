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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard a1 = new Dashboard();
            a1.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\leteb\Documents\registration.mdf;Integrated Security=True;Connect Timeout=30");
                con.Open();
                string region = string.Empty;
                if(checkBox1.Checked)
                { region = "Full Time";
                }else if (checkBox1.Checked)
                {
                    region = "Pretoria";
                }
                else if (checkBox2.Checked)
                {
                    region = "Polokwane";
                }else if(checkBox3.Checked)
                {
                    region = "Johannesburg";
                }else
                {
                    region = "Durban";
                }

                String sql = "INSERT INTO student(Course_chc,Course_Lvl,title,intial,FN,Surname,DOB,ID_Number,P_Number,M_status,P_Exp,H_Language,Occup,H_Address,P_Address,Cell,E_mail,P_FN,P_Surname,Relationship,P_HAddress,P_Cell,P_PAddress,S_Name,Grade) VALUES('" + txtFN.Text + "','" + txtEmail.Text + "','" + txtCell.Text + "','" + txtHAddress + "','" + txtHLangu + "','" + cmbCC.Text + "','" + Dtp.Text + "','" + cmbCL.Text + "','" + txtPED.Text + "','" + cmbGrade.Text + "','" + txtIntital.Text + "','" + cmbTitle.Text + "','" + txtSurname.Text + "','" + txtID.Text + "','" + txtOcc.Text + "','" + txtMStatus.Text + "','" + txtPfn.Text + "','" + txtPNumber.Text + "','" + txtSName.Text + "','" + txtSurname.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                String sql1 = "Select max(std_id) from student";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Dear Student, Your Data Inserted Successfully.. ");
                }
                this.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            }
            
        }
    }
}
