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
    public partial class EightPage : Form
    {
        public EightPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage uhb = new FirstPage();
            uhb.MdiParent = Form1.ActiveForm;
            uhb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage bgy = new SecondPage();
            bgy.MdiParent = Form1.ActiveForm;
            bgy.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage jb = new ThirdPage();
            jb.MdiParent = Form1.ActiveForm;
            jb.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage gvb = new FourthPage();
            gvb.MdiParent = Form1.ActiveForm;
            gvb.Show();
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
            SixthPage hbg = new SixthPage();
            hbg.MdiParent = Form1.ActiveForm;
            hbg.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 bhi = new Question7();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage ihn = new NinthPage();
            ihn.MdiParent = Form1.ActiveForm;
            ihn.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage jb = new TenthPage();
            jb.MdiParent = Form1.ActiveForm;
            jb.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage hbjn = new EightPage();
            hbjn.MdiParent = Form1.ActiveForm;
            hbjn.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage uv = new NinthPage();
            uv.MdiParent = Form1.ActiveForm;
            uv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 sp = new Question7();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
