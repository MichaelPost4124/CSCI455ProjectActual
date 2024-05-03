namespace CSCI455ProjectActual
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        // test comment
        //patient data button click
        private void button4_Click(object sender, EventArgs e)
        {
            PatientDataPage patientDataPage = new PatientDataPage();
            this.Close();
            patientDataPage.Show();
        }

        //Records page button click
        private void Paitent_Records_Button_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            this.Close();
            records.Show();
        }

        //Prescriptions page button click
        private void button3_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            this.Close();
            prescriptions.Show();
        }

        //Settings button click
        private void button5_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Close();
            settings.Show();
        }
    }
}