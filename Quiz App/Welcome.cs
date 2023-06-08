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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hom = new Home();
            hom.MdiParent=Form1.ActiveForm;
            hom.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.MdiParent=Form1.ActiveForm;
            log.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();  
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Close();
            AdminPage sp = new AdminPage();
            sp.MdiParent = Form1.ActiveForm;
            sp.Show();  
        }
    }
}
