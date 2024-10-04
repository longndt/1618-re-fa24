namespace Calculator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
                //MessageBox.Show("Login succeed !");

                //hide login form
                this.Hide();

                //show calculator form
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.Show();
            }
            else if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("You must input both value");
            }
            else
            {
                MessageBox.Show("Login failed !");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key pressed is Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the Login button
                btnLogin.PerformClick();
            }
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {

        }
    }
}
