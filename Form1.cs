namespace TutExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //DRY = do not repeat yourself
            string firstName, lastName, outPut;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            outPut = "Welcome to the Work " + firstName + " " + lastName;
            lblOutput.Text = outPut;

            MessageBox.Show(outPut);




        }


    }
}
