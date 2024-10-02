namespace WinForm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //set short-date format for DateTimePicker
            dtpBirthday.Format = DateTimePickerFormat.Short; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //1. retrieve input
            string fullName = tbFullName.Text;
            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            string birthPlace = cmbBirthplace.Text;
            string birthDay = dtpBirthday.Text;
            string graduated = "";
            if (cbGraduated.Checked)
                graduated = "Yes";
            else
                graduated = "No";
 
            //2. display output
            tbFullName_Output.Text = fullName;
            tbGender_Output.Text = gender;
            tbBirthplace_Output.Text = birthPlace;
            tbBirthday_Output.Text = birthDay;
            tbGraduated_Output.Text = graduated;
        }
    }
}
