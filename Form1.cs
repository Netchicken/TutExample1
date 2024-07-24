namespace TutExample1
{
    public partial class Form1 : Form
    {
        int intAge = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //DRY = do not repeat yourself
            string firstName, lastName, outPut, age;


            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            age = txtAge.Text;


            intAge = Convert.ToInt32(age);
            intAge++;


            outPut = "Welcome to the Work " + firstName + " " + lastName + " you are " + intAge + " old";
            lblOutput.Text = outPut;

            MessageBox.Show(outPut);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            intAge = intAge + 10;
            MessageBox.Show(intAge.ToString());
        }
    }
}
