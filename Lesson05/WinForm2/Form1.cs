namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1. Get user's input
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //2. Validate user's input to display login result
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Login succeed !");
            } else
            {
                MessageBox.Show("Login failed !");
            }
        }
    }
}
