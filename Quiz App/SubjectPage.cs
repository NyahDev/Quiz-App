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
    public partial class SubjectPage : Form
    {
        public SubjectPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login wel = new Login();
            wel.MdiParent = Form1.ActiveForm;
            wel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            QuestionPage qpg = new QuestionPage();
            qpg.MdiParent = Form1.ActiveForm;
            qpg.Show();
        }
    }
}
