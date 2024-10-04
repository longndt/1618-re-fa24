namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            //clear result label text
            lblResult.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            //validate both input values
            //case 1: not empty => calculate then show result
            if (!String.IsNullOrEmpty(txtNumber1.Text) && !String.IsNullOrEmpty(txtNumber2.Text))
            {
                //convert string (default format of textbox) to number (integer)
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);

                //do calculation: add (plus) operation
                int result = number1 + number2;

                //show result to Result label
                lblResult.Text = result.ToString();
            }
            //case 2: empty value(s) => show error 
            else
            {
                MessageBox.Show("You must input both numbers first");
            }
        }

        private void rbSubtract_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumber1.Text) && !String.IsNullOrEmpty(txtNumber2.Text))
            {
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);
                int result = number1 - number2;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("You must input both numbers first");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumber1.Text) && !String.IsNullOrEmpty(txtNumber2.Text))
            {
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);
                int result = number1 * number2;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("You must input both numbers first");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNumber1.Text) && !String.IsNullOrEmpty(txtNumber2.Text))
            {
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);
                float result = number1 / number2;
                lblResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("You must input both numbers first");
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
