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
    public partial class SecondPage : Form
    {
        public SecondPage()
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage top = new ThirdPage();
            top.MdiParent = Form1.ActiveForm;
            top.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage ghj = new FourthPage();
            ghj.MdiParent = Form1.ActiveForm;
            ghj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage yu = new FifthPage();
            yu.MdiParent = Form1.ActiveForm;
            yu.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage spp = new SixthPage();
            spp.MdiParent = Form1.ActiveForm;
            spp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 rq = new Question7();
            rq.MdiParent = Form1.ActiveForm;
            rq.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage eep = new EightPage();
            eep.MdiParent = Form1.ActiveForm;
            eep.Show();
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
            TenthPage ttp = new TenthPage();
            ttp.MdiParent = Form1.ActiveForm;
            ttp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage bhi = new SecondPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage utfv = new ThirdPage();
            utfv.MdiParent = Form1.ActiveForm;
            utfv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage sp = new FirstPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }
    }
}
