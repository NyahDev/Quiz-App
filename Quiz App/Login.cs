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
    public partial class Login : Form
    {
        string connector = Settings1.Default.Connect;
        public Login()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Please enter your UserName");
                txtuser.Focus();
            }
            else if(txtpass.Text == "")
            {
                MessageBox.Show("Please enter your password");
                txtpass.Focus();
            }
            else
            {
                try
                {

                    SqlConnection com = new SqlConnection(connector);
                    com.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Login where UserName=@UserName and Password=@Password", com);
                    SqlParameter[] dad = new SqlParameter[2];
                    dad[0] = new SqlParameter("@UserName", this.txtuser.Text.Trim());
                    dad[1] = new SqlParameter("@Password", this.txtpass.Text.Trim());
                    for (int s = 0; s < 2; s++)
                    {
                        cmd.Parameters.Add(dad[s]);
                    }
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        this.Close();
                        SubjectPage spg = new SubjectPage();
                        spg.MdiParent = Form1.ActiveForm;
                        spg.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Contact the System Manager");
                        txtuser.Clear();
                        txtpass.Clear();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
