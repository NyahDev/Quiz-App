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
    public partial class FirstPage : Form
    {
        string connector = Settings1.Default.Connect;
        public FirstPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage bhi = new FirstPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage qpt = new ThirdPage();
            qpt.MdiParent = Form1.ActiveForm;
            qpt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionPage qp = new QuestionPage();
            qp.MdiParent = Form1.ActiveForm;
            qp.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage qpg = new SecondPage();
            qpg.MdiParent = Form1.ActiveForm;
            qpg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage spp = new SecondPage();
            spp.MdiParent = Form1.ActiveForm;
            spp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage fffp = new FourthPage();
            fffp.MdiParent = Form1.ActiveForm;
            fffp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage ng = new FifthPage();
            ng.MdiParent = Form1.ActiveForm;
            ng.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage sp = new SixthPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 qpp = new Question7();
            qpp.MdiParent = Form1.ActiveForm;
            qpp.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage ep = new EightPage();
            ep.MdiParent = Form1.ActiveForm;
            ep.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage nnp = new NinthPage();
            nnp.MdiParent = Form1.ActiveForm;
            nnp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage otp = new TenthPage();
            otp.MdiParent = Form1.ActiveForm;
            otp.Show();
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connector);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select QuestID, CorrectOption, OptionChoosen from QTable ORDER BY No ASC", cn);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource= dt;
            da.Dispose();
            da = null;

        }
    }
}
