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
    public partial class FifthPage : Form
    {
        public FifthPage()
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
            SecondPage uhg = new SecondPage();
            uhg.MdiParent = Form1.ActiveForm;
            uhg.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage tpp = new ThirdPage();
            tpp.MdiParent = Form1.ActiveForm;
            tpp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage cgvhb = new FourthPage();
            cgvhb.MdiParent = Form1.ActiveForm;
            cgvhb.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage iyg = new SixthPage();
            iyg.MdiParent = Form1.ActiveForm;
            iyg.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 iuytb = new Question7();
            iuytb.MdiParent = Form1.ActiveForm;
            iuytb.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage bjn3 = new EightPage();
            bjn3.MdiParent = Form1.ActiveForm;
            bjn3.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage jgi = new NinthPage();
            jgi.MdiParent = Form1.ActiveForm;
            jgi.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage topp = new TenthPage();
            topp.MdiParent = Form1.ActiveForm;
            topp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage bhi = new FifthPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage ijh = new SixthPage();
            ijh.MdiParent = Form1.ActiveForm;
            ijh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage sp = new FourthPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }
    }
}
