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
    public partial class AdminPage : Form
    {
        string connector = Settings1.Default.Connect;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Welcome sp = new Welcome();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Admin where AdminUser=@AdminUser and AdminPassword=@AdminPassword", cn);
            SqlParameter[] jerry = new SqlParameter[2];
            jerry[0] = new SqlParameter("@AdminUser", this.txtuser.Text.Trim());
            jerry[1] = new SqlParameter("@AdminPassword",this.txtpass.Text.Trim());
            for(int i = 0; i<2; i++)
            {
                cmd.Parameters.Add(jerry[i]);
            }
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                MessageBox.Show("Welcome");
                this.Close();
                AdminQuestionPage dvc = new AdminQuestionPage();
                dvc.MdiParent = Form1.ActiveForm;
                dvc.Show();
            }
            else
            {
                MessageBox.Show("Please you are not an Administrator");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
