namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            //show popup dialog
            MessageBox.Show("Welcome to Greenwich Vietnam");
        }
    }
}
