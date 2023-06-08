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
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage uhv = new FirstPage();
            uhv.MdiParent = Form1.ActiveForm;
            uhv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage ofnbk = new SecondPage();
            ofnbk.MdiParent = Form1.ActiveForm;
            ofnbk.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage nhgu = new ThirdPage();
            nhgu.MdiParent = Form1.ActiveForm;
            nhgu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage inh = new FourthPage();
            inh.MdiParent = Form1.ActiveForm;
            inh.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage yg = new FifthPage();
            yg.MdiParent = Form1.ActiveForm;
            yg.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage hbn = new SixthPage();
            hbn.MdiParent = Form1.ActiveForm;
            hbn.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage nb = new EightPage();
            nb.MdiParent = Form1.ActiveForm;
            nb.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage njh = new NinthPage();
            njh.MdiParent = Form1.ActiveForm;
            njh.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage al = new TenthPage();
            al.MdiParent = Form1.ActiveForm;
            al.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 bhi = new Question7();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage jolj = new EightPage();
            jolj.MdiParent = Form1.ActiveForm;
            jolj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage sp = new SixthPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
