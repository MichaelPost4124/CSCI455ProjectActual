using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI455ProjectActual
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Program.dark)
            {
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                Paitent_Records_Button.BackColor = Color.Black;
                darkButton.BackColor = Color.Black;
                logOutButton.BackColor = Color.Black;
                desktopButton.BackColor = Color.Black;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

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

        private void darkButton_Click(object sender, EventArgs e)
        {
            if (Program.dark)
            {
                Program.dark = false;
            }
            else
            {
                Program.dark = true;
            }
            if (Program.dark)
            {
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                Paitent_Records_Button.BackColor = Color.Black;
                darkButton.BackColor = Color.Black;
                logOutButton.BackColor = Color.Black;
                desktopButton.BackColor = Color.Black;
            }
            if (!Program.dark)
            {
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Green;
                panel1.BackColor = Color.Green;
                Paitent_Records_Button.BackColor = Color.Green;
                darkButton.BackColor = Color.Green;
                logOutButton.BackColor = Color.Green;
                desktopButton.BackColor = Color.Green;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Close();
            loginPage.Show();
        }

        private void desktopButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
