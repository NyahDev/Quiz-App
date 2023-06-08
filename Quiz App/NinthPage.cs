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
    public partial class NinthPage : Form
    {
        public NinthPage()
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage inh = new SecondPage();
            inh.MdiParent = Form1.ActiveForm;
            inh.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage njh = new ThirdPage();
            njh.MdiParent = Form1.ActiveForm;
            njh.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage hmn = new FourthPage();
            hmn.MdiParent = Form1.ActiveForm;
            hmn.Show();
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
            SixthPage ubi = new SixthPage();
            ubi.MdiParent = Form1.ActiveForm;
            ubi.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 bjo = new Question7();
            bjo.MdiParent = Form1.ActiveForm;
            bjo.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage hbjn = new EightPage();
            hbjn.MdiParent = Form1.ActiveForm;
            hbjn.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage utb = new TenthPage();
            utb.MdiParent = Form1.ActiveForm;
            utb.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage ug = new NinthPage();
            ug.MdiParent = Form1.ActiveForm;
            ug.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage jhh = new TenthPage();
            jhh.MdiParent = Form1.ActiveForm;
            jhh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage sp = new EightPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
