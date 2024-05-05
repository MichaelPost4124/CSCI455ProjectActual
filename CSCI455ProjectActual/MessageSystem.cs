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
    public partial class MessageSystem : Form
    {
        public MessageSystem()
        {
            InitializeComponent();
            if (Program.dark)
            {
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                Paitent_Records_Button.BackColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                sendMessageButton.BackColor = Color.Black;
                viewMessageButton.BackColor = Color.Black;
                MessagesButton.BackColor = Color.Black;
            }
            if (Program.isPatient)
            {
                readLogs();
                viewMessageButton.Visible = false;
                PatientComboBox.Visible = false;
            }
            if (Program.fullscreen) { // set fullscreen
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }

        }
        //reads the text file for the doctor
        private void readLogs()
        {
            string content = File.ReadAllText(@"John_Doe.txt");
            richTextBox1.Text = content;
        }
        //adds to the text file for conversation
        private void updateLogs(string text)
        {
            String toBeAdded;
            using (StreamWriter writer = new StreamWriter(@"John_Doe.txt", true))
            {
                if (Program.isPatient)
                {
                    toBeAdded = "\nJohn: " + text;
                }
                else
                {
                    toBeAdded = "\nJane: " + text;
                }
                writer.WriteLine(toBeAdded);
            }
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

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            updateLogs(newMessageBox.Text);
            readLogs();
            newMessageBox.Text = "";
        }

        private void viewMessageButton_Click(object sender, EventArgs e)
        {
            if (PatientComboBox.SelectedIndex == 1)
            {
                readLogs();
            }
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            MessageSystem messageSystem = new MessageSystem();
            this.Close();
            messageSystem.Show();
        }
    }
}
