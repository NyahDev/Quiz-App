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

namespace Quiz_App
{
    public partial class Home : Form
    {
        string connector = Settings1.Default.Connect;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfirst.Text == "")
            {
                MessageBox.Show("Please enter your First Name");
                txtfirst.Focus();
            }
            else if (txtlast.Text == "")
            {
                MessageBox.Show("Please enter your Last Name");
                txtlast.Focus();
            }
            else if (cbgender.Text == "")
            {
                MessageBox.Show("Please Select your Gender");
                cbgender.Focus();
            }
            else if (cbgender.Text == "None")
            {
                MessageBox.Show("Please Select your Gender");
                cbgender.Focus();
            }
            else if (txtuser.Text == "")
            {
                MessageBox.Show("Please Enter your User Name");
                txtuser.Focus();
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Please Enter your Password");
                txtpass.Focus();
            }
            else
            {
                SqlConnection cn = new SqlConnection(connector);
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Login where UserName=@UserName", cn);
                SqlParameter[] jerry = new SqlParameter[1];
                jerry[0] = new SqlParameter("@UserName", this.txtuser.Text.Trim());
                cmd.Parameters.Add(jerry[0]);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Please Users Already Exist");
                }
                else
                {
                    dr.DisposeAsync();
                    dr= null;   

                    SqlCommand icmd = new SqlCommand("Insert into Login(FirstName, LastName, Gender, UserName, Password) Values(@FirstName, @LastName, @Gender, @UserName, @Password)",cn);
                    SqlParameter[] chux = new SqlParameter[5];
                    chux[0] = new SqlParameter("@FirstName", this.txtfirst.Text.Trim());
                    chux[1] = new SqlParameter("@LastName", this.txtlast.Text.Trim());
                    chux[2] = new SqlParameter("@Gender",this.cbgender.Text.Trim());
                    chux[3] = new SqlParameter("@UserName", this.txtuser.Text.Trim());
                    chux[4] = new SqlParameter("@Password", this.txtpass.Text.Trim());
                    for( int i=0; i<5; i++ )
                    {
                        icmd.Parameters.Add(chux[i]);   
                    }
                    icmd.ExecuteNonQuery();
                    MessageBox.Show("Submitted Successfully");
                }

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            cbgender.Items.Add("None");
            cbgender.Items.Add("Male");
            cbgender.Items.Add("Female");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Welcome wel = new Welcome();
            wel.MdiParent = Form1.ActiveForm;
            wel.Show();
        }

        private void txtfirst_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
