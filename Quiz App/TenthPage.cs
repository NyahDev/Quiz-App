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
    public partial class TenthPage : Form
    {
        public TenthPage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FirstPage inh = new FirstPage();
            inh.MdiParent = Form1.ActiveForm;
            inh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            SecondPage dbn = new SecondPage();
            dbn.MdiParent = Form1.ActiveForm;
            dbn.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage oksc = new ThirdPage();
            oksc.MdiParent = Form1.ActiveForm;
            oksc.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage vk = new FourthPage();
            vk.MdiParent = Form1.ActiveForm;
            vk.Show();
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
            SixthPage bj = new SixthPage();
            bj.MdiParent = Form1.ActiveForm;
            bj.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 fivi = new Question7();
            fivi.MdiParent = Form1.ActiveForm;
            fivi.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage dvd = new EightPage();
            dvd.MdiParent = Form1.ActiveForm;
            dvd.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage fxf = new NinthPage();
            fxf.MdiParent = Form1.ActiveForm;
            fxf.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage gjb = new TenthPage();
            gjb.MdiParent = Form1.ActiveForm;
            gjb.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage ug = new FifthPage();
            ug.MdiParent = Form1.ActiveForm;
            ug.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage sp = new NinthPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
