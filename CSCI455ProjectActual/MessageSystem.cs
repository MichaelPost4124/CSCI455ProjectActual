﻿/*
 * MessageSystem.cs
 * This file is meant to handle MessageSystem's functionality.
 * Created by Wyatt Hanson
 * Created on April 30, 2024
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI455ProjectActual
{
    public partial class MessageSystem : Form
    {
        /// <summary>
        /// Initializes MessageSystem to be viewed
        /// </summary>
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
            if (Program.fullscreen)
            { // set fullscreen
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }

        }
        /// <summary>
        /// reads the patient log for the doctor
        /// </summary>
        /// <returns> void </returns>
        private void readLogs()
        {
            string content = File.ReadAllText(@"John_Doe.txt");
            richTextBox1.Text = content;
        }
        /// <summary>
        /// Updates the text logs from either the doctor or patient
        /// </summary>
        /// <param name="text">The text to be sent to the log</param>
        /// <returns> void </returns>
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
        /// <summary>
        /// sends message to patient or doctor
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (PatientComboBox.SelectedIndex == 1 || viewMessageButton.Visible == false)
            {
                updateLogs(newMessageBox.Text);
                readLogs();
            }
            newMessageBox.Text = "";
        }
        /// <summary>
        /// Views mesage after selecting the patient
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void viewMessageButton_Click(object sender, EventArgs e)
        {
            if (PatientComboBox.SelectedIndex == 1)
            {
                readLogs();
            }
            else
            {
                richTextBox1.Text = "";
            }
        }
        /// <summary>
        /// Navigates to MessageSystem from button click and closes page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void Messages_Click(object sender, EventArgs e)
        {
            MessageSystem messageSystem = new MessageSystem();
            this.Close();
            messageSystem.Show();
        }

        private void MessageSystem_Load(object sender, EventArgs e)
        {

        }
    }
}
