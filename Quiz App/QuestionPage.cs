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
    public partial class QuestionPage : Form
    {
        string connector = Settings1.Default.Connect;
        public QuestionPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubjectPage sp = new SubjectPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {






        }

        private void QuestionPage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            SubjectPage sp = new SubjectPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lb1.Text = "4";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lb1.Text = "5";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("You are About Ending this Session", "End Session", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                FirstPage fp = new FirstPage();
                fp.MdiParent = Form1.ActiveForm;
                fp.Show();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lb1.Text = "1";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lb1.Text = "2";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lb1.Text = "3";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lb1.Text = "6";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lb1.Text = "7";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lb1.Text = "8";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lb1.Text = "9";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lb1.Text = "10";

            //cbop.Items.Add("A");
            //cbop.Items.Add("B");
            //cbop.Items.Add("C");
            //cbop.Items.Add("D");

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }
            //this.Close();
            //SecondPage sp = new SecondPage();
            //sp.MdiParent = Form1.ActiveForm;
            //sp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            EleventhPage eep = new EleventhPage();
            eep.MdiParent = Form1.ActiveForm;
            eep.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirtenthPage ottp = new ThirtenthPage();
            ottp.MdiParent = Form1.ActiveForm;
            ottp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            FourteenPage wfp = new FourteenPage();
            wfp.MdiParent = Form1.ActiveForm;
            wfp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            FifteenPage lffp = new FifteenPage();
            lffp.MdiParent = Form1.ActiveForm;
            lffp.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            TwelfthPage fttp = new TwelfthPage();
            fttp.MdiParent = Form1.ActiveForm;
            fttp.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if(cbop.Text=="")
            {
                MessageBox.Show("Please Select your Option");
                cbop.Focus();
            }
            else
            {
                SqlConnection icn = new SqlConnection(connector);
                icn.Open();
                SqlCommand cmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", icn);
                SqlParameter[] teni = new SqlParameter[1];
                teni[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
                cmd.Parameters.Add(teni[0]);
                SqlDataReader dr = cmd.ExecuteReader();
                if( dr.Read())
                {
                    dr.DisposeAsync();
                    dr = null;
                    SqlCommand ucmd = new SqlCommand("Update QTable set OptionChoosen=@optionChoosen where QuestID=@QuestID",icn);
                    SqlParameter[] nike = new SqlParameter[2];  
                    nike[0] = new SqlParameter("@OptionChoosen",this.cbop.Text.Trim());
                    nike[1] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
                    for( int i=0; i<2; i++ )
                    {
                        ucmd.Parameters.Add(nike[i]);
                    }
                    dr = ucmd.ExecuteReader();
                    MessageBox.Show("Submitted");
                }
                else
                {
                    dr.DisposeAsync();
                    dr = null;
                    SqlCommand ucmd = new SqlCommand("Update QTable set OptionChoosen=@optionChoosen where QuestID=@QuestID", icn);
                    SqlParameter[] Oge = new SqlParameter[2];
                    Oge[0] = new SqlParameter("@OptionChoosen", this.cbop.Text.Trim());
                    Oge[1] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
                    for (int i = 0; i < 2; i++)
                    {
                        ucmd.Parameters.Add(Oge[i]);
                    }
                    dr = ucmd.ExecuteReader();
                    MessageBox.Show("Submitted");
                }
            }
        }

        private void QuestionPage_Load_1(object sender, EventArgs e)
        {
            cbop.Items.Add("A");
            cbop.Items.Add("B");
            cbop.Items.Add("C");    
            cbop.Items.Add("D");    

            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select Questions from QTable where QuestID=@QuestID", cn);
            SqlParameter[] jerry = new SqlParameter[1];
            jerry[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
            cmd.Parameters.Add(jerry[0]);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.DisposeAsync();
                dr = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);    
                dataGridView1.DataSource = dt;


                SqlCommand scmd = new SqlCommand("Select * from QTable where QuestID=@QuestID", cn);
                SqlParameter[] lovy = new SqlParameter[1];
                lovy[0] = new SqlParameter("@QuestID", this.lb1.Text.Trim());
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
                //cbE.DataSource = dss.Tables["QTable"];
            }

        }
    }
}
