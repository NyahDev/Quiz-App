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
    public partial class ThirdPage : Form
    {
        public ThirdPage()
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
            SecondPage spp = new SecondPage();
            spp.MdiParent = Form1.ActiveForm;
            spp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage fghj = new FourthPage();
            fghj.MdiParent = Form1.ActiveForm;
            fghj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage bnm = new FifthPage();
            bnm.MdiParent = Form1.ActiveForm;
            bnm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage lk = new SixthPage();
            lk.MdiParent = Form1.ActiveForm;
            lk.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 qhj = new Question7();
            qhj.MdiParent = Form1.ActiveForm;
            qhj.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage epfo = new EightPage();
            epfo.MdiParent = Form1.ActiveForm;
            epfo.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage oijhn = new NinthPage();
            oijhn.MdiParent = Form1.ActiveForm;
            oijhn.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage mnv = new TenthPage();
            mnv.MdiParent = Form1.ActiveForm;
            mnv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage bhi = new ThirdPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage fgc = new FourthPage();
            fgc.MdiParent = Form1.ActiveForm;
            fgc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage sp = new SecondPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }
    }
}
