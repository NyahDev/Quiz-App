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
    public partial class AdminQuestionPage : Form
    {
        string connector = Settings1.Default.Connect;
        public AdminQuestionPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage sp = new AdminPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void AdminQuestionPage_Load(object sender, EventArgs e)
        {
            cbno.Items.Add("None");
            cbno.Items.Add("1");
            cbno.Items.Add("2");
            cbno.Items.Add("3");
            cbno.Items.Add("4");
            cbno.Items.Add("5");
            cbno.Items.Add("6");
            cbno.Items.Add("7");
            cbno.Items.Add("8");
            cbno.Items.Add("9");
            cbno.Items.Add("10");
        }

        private void tquest_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbno.Text=="")
            {
                MessageBox.Show("Please Select the Question Number");
                cbno.Focus();
            }
            else if(cbno.Text=="None")
            {
                MessageBox.Show("Please Select the Question Number");
                cbno.Focus();
            }
            else
            {
                SqlConnection cn = new SqlConnection(connector);
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from QTable where QuestID=@QuestID",cn);
                SqlParameter[] jery = new SqlParameter[1];
                jery[0] = new SqlParameter("@QuestID", this.txtquest.Text.Trim());
                cmd.Parameters.Add(jery[0]);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Please this Question ID already Exist ");
                }
                else
                {
                    dr.DisposeAsync();
                    dr=null;
                    SqlCommand icmd = new SqlCommand("Insert into QTable (QuestID, Questions, AOption,BOption,COption,DOption,CorrectOption) values (@QuestID, @Questions,@AOption,@BOption,@COption,@DOption,@CorrectOption)",cn);
                    SqlParameter[] jboy = new SqlParameter[7];  
                    jboy[0] = new SqlParameter("@QuestID",this.cbno.Text.Trim());
                    jboy[1] = new SqlParameter("@Questions", this.txtquest.Text.Trim());
                    jboy[2] = new SqlParameter("@AOption", this.cbA.Text.Trim());
                    jboy[3] = new SqlParameter("@BOption", this.cbB.Text.Trim());
                    jboy[4] = new SqlParameter("@COption", this.cbC.Text.Trim());
                    jboy[5] = new SqlParameter("@DOption", this.cbD.Text.Trim());
                    jboy[6] = new SqlParameter("@CorrectOption", this.cbE.Text.Trim());

                    for( int d=0; d<7; d++)
                    {
                        icmd.Parameters.Add(jboy[d]);
                    }
                    icmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                    icmd.Dispose();
                    icmd = null;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cbno.Text == "")
            {
                MessageBox.Show("Please Select the Question ID");
                cbno.Focus();
            }
            else if (cbno.Text == "None")
            {
                MessageBox.Show("Please Select the Question ID");
                cbno.Focus();
            }
            else if(txtquest.Text=="")
            {
                MessageBox.Show("Please Enter a Questions");
            }
            else
            {
                SqlConnection cn = new SqlConnection(connector);
                cn.Open();
                SqlCommand ccmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] cyber = new SqlParameter[1];
                cyber[0] = new SqlParameter("@QuestID", this.cbno.Text.Trim());
                ccmd.Parameters.Add(cyber[0]);
                SqlDataReader dr = ccmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.DisposeAsync();
                    dr=null;
                    SqlCommand ucmd = new SqlCommand("Update QTable set Questions=@Questions, AOption=@A, BOption=@B, COption=@C, DOption=@D, CorrectOption=@E where QuestID=@QuestID", cn);
                    SqlParameter[] teni = new SqlParameter[7];
                    teni[0] = new SqlParameter("@Questions", this.txtquest.Text.Trim());
                    teni[1] = new SqlParameter("@QuestID", this.cbno.Text.Trim());
                    teni[2] = new SqlParameter("@A", this.cbA.Text.Trim());
                    teni[3] = new SqlParameter("@B", this.cbB.Text.Trim());
                    teni[4] = new SqlParameter("@C", this.cbC.Text.Trim());
                    teni[5] = new SqlParameter("@D", this.cbD.Text.Trim());
                    teni[6] = new SqlParameter("@E", this.cbE.Text.Trim());

                    for (int a = 0; a < 7; a++)
                    {
                        ucmd.Parameters.Add(teni[a]);
                    }
                    ucmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");
                    ucmd.Dispose();
                    ucmd = null;
                }
                else
                {
                    MessageBox.Show("Please this question does not exist");
                }
            }
        }

        private void cbno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cbno.Text == "")
            {
                MessageBox.Show("Please Select the Question Number");
                cbno.Focus();
            }
            else if (cbno.Text == "None")
            {
                MessageBox.Show("Please Select the Question Number");
                cbno.Focus();
            }
            else
            {
                SqlConnection cn = new SqlConnection(connector);
                cn.Open();
                SqlCommand acmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
                SqlParameter[] love = new SqlParameter[1];
                love[0] = new SqlParameter("@QuestID", this.cbno.Text.Trim());
                acmd.Parameters.Add(love[0]);
                SqlDataReader mdr=acmd.ExecuteReader(); 
                if(mdr.HasRows==true)
                {
                    mdr.DisposeAsync();
                    mdr = null;
                    SqlDataAdapter da = new SqlDataAdapter(acmd);
                    //DataSet dss = new DataSet();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //da.Fill(dss, "QTable");
                    dataGridView1.DataSource = dt;

                    SqlCommand scmd= new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                    SqlParameter[] lovy = new SqlParameter[1];
                    lovy[0] = new SqlParameter("@QuestID", this.cbno.Text.Trim());
                    scmd.Parameters.Add(lovy[0]);
                    SqlDataAdapter dv = new SqlDataAdapter(scmd);   
                    DataSet dss = new DataSet();
                    dv.Fill(dss, "QTable");
                    cbA.DataSource = dss.Tables["QTable"];
                    cbA.DisplayMember = "AOption";
                    cbB.DataSource = dss.Tables["QTable"];
                    cbB.DisplayMember = "BOption";
                    cbC.DataSource = dss.Tables["QTable"];
                    cbC.DisplayMember = "COption";
                    cbD.DataSource = dss.Tables["QTable"];
                    cbD.DisplayMember = "DOption";
                    cbE.DataSource = dss.Tables["QTable"];
                    cbE.DisplayMember = "CorrectOption";

                    //SqlConnection cnn = new SqlConnection(connector);
                    //cn.Open();
                    //SqlCommand cmd = new SqlCommand("Select * from Registration where PatientID = @PatientID", cn);
                    //SqlParameter[] chux = new SqlParameter[1];
                    //chux[0] = new SqlParameter("@PatientID", this.txtID.Text.Trim());
                    //cmd.Parameters.Add(chux[0]);
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //if (dr.Read())
                    //{
                    //    dr.Dispose();
                    //    dr = null;
                    //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //    DataSet ds = new DataSet();
                    //    da.Fill(ds, "Registration");
                    //    cbsurname.DataSource = ds.Tables["Registration"];
                    //    cbsurname.DisplayMember = "Surname";
                    //    cbothernames.DataSource = ds.Tables["Registration"];
                    //    cbothernames.DisplayMember = "OtherNames";
                    //    cbsex.DataSource = ds.Tables["Registration"];
                    //    cbsex.DisplayMember = "Sex";
                    //    cbpatient.DataSource = ds.Tables["Registration"];
                    //    cbpatient.DisplayMember = "PatientID";
                    //    cbmarital.DataSource = ds.Tables["Registration"];
                    //    cbmarital.DisplayMember = "MaritalStatus";
                    //    cbphone.DataSource = ds.Tables["Registration"];
                    //    cbphone.DisplayMember = "PhoneNo";






                    {

                    }

                }
                else
                {
                    MessageBox.Show("Please No Data Found");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
