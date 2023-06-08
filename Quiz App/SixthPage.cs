using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_App
{
    public partial class SixthPage : Form
    {
        public SixthPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage fp = new FirstPage();
            fp.MdiParent = Form1.ActiveForm;
            fp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage fctvygbu = new SecondPage();
            fctvygbu.MdiParent = Form1.ActiveForm;
            fctvygbu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage uhebf = new ThirdPage();
            uhebf.MdiParent = Form1.ActiveForm;
            uhebf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage ijv = new FourthPage();
            ijv.MdiParent = Form1.ActiveForm;
            ijv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage yg = new FifthPage();
            yg.MdiParent = Form1.ActiveForm;
            yg.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 nv = new Question7();
            nv.MdiParent = Form1.ActiveForm;
            nv.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage kbo = new EightPage();
            kbo.MdiParent = Form1.ActiveForm;
            kbo.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage om = new NinthPage();
            om.MdiParent = Form1.ActiveForm;
            om.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage gnl = new TenthPage();
            gnl.MdiParent = Form1.ActiveForm;
            gnl.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage bhi = new SixthPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 ggu = new Question7();
            ggu.MdiParent = Form1.ActiveForm;
            ggu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage sp = new FifthPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
