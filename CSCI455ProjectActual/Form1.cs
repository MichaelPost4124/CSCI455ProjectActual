/*
 * Form1.cs
 * This file is meant to handle Form1's functionality.
 * Created by Michael Post
 * Created on April 30, 2024
 */

namespace CSCI455ProjectActual
{
    public partial class homePage : Form
    {
        /// <summary>
        /// Initializes Homepage to be viewed
        /// </summary>
        public homePage()
        {
            InitializeComponent();
            if (Program.fullscreen)
            { // set fullscreen
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Navigates to patientDataPage from button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void button4_Click(object sender, EventArgs e)
        {
            PatientDataPage patientDataPage = new PatientDataPage();
            this.Close();
            patientDataPage.Show();
        }

        /// <summary>
        /// Navigates to records from button click and closes page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void Paitent_Records_Button_Click(object sender, EventArgs e)
        {
            Records records = new Records();
            this.Close();
            records.Show();
        }

        /// <summary>
        /// Navigates to Prescriptions from button click and closes page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void button3_Click(object sender, EventArgs e)
        {
            Prescriptions prescriptions = new Prescriptions();
            this.Close();
            prescriptions.Show();
        }

        /// <summary>
        /// Navigates to Settings from button click and closes page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void button5_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            this.Close();
            settings.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Navigates to MessageSystem from button click and closes page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void MessagePCP_Click(object sender, EventArgs e)
        {
            MessageSystem messageSystem = new MessageSystem();
            this.Close();
            messageSystem.Show();
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }
    }
}