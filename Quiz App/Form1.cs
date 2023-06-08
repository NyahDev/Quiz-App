namespace Quiz_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Welcome hom =  new Welcome();
            hom.MdiParent = this;
            hom.Show();
        }
    }
}