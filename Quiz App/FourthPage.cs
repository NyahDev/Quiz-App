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
    public partial class FourthPage : Form
    {
        public FourthPage()
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
            SecondPage bmk = new SecondPage();
            bmk.MdiParent = Form1.ActiveForm;
            bmk.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage nm = new ThirdPage();
            nm.MdiParent = Form1.ActiveForm;
            nm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage mnhju = new FifthPage();
            mnhju.MdiParent = Form1.ActiveForm;
            mnhju.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            SixthPage mkhj = new SixthPage();
            mkhj.MdiParent = Form1.ActiveForm;
            mkhj.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Question7 qolk = new Question7();
            qolk.MdiParent = Form1.ActiveForm;
            qolk.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            EightPage ehbkjnl = new EightPage();
            ehbkjnl.MdiParent = Form1.ActiveForm;
            ehbkjnl.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            NinthPage np = new NinthPage();
            np.MdiParent = Form1.ActiveForm;
            np.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            TenthPage tppp = new TenthPage();
            tppp.MdiParent = Form1.ActiveForm;
            tppp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            FourthPage bhi = new FourthPage();
            bhi.MdiParent = Form1.ActiveForm;
            bhi.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            FifthPage jkn = new FifthPage();
            jkn.MdiParent = Form1.ActiveForm;
            jkn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ThirdPage sp = new ThirdPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
