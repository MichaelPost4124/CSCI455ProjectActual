﻿/*
 * Settings.cs
 * This file is meant to handle Records's functionality.
 * Created by Wyatt Hanson
 * Created on April 30, 2024
 */

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
        /// <summary>
        /// Initializes Settings to be viewed
        /// </summary>
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
                MessagesButton.BackColor = Color.Black;
                fullscreenButton.BackColor = Color.Black;
            }
            if (Program.fullscreen)
            { // set fullscreen
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

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
        /// Makes the current Settings page into dark mode
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
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
                MessagesButton.BackColor = Color.Black;
                fullscreenButton.BackColor = Color.Black;
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
                MessagesButton.BackColor = Color.Green;
                fullscreenButton.BackColor = Color.Green;
            }
        }
        /// <summary>
        /// Navigates to login page and logs out
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Close();
            loginPage.Show();
        }
        /// <summary>
        /// Closes the application to desktop
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void desktopButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        /// <summary>
        /// Toggles to FullScreen view
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void fullscreenButton_Click(object sender, EventArgs e)
        { // Button to toggle fullscreen

            if (Program.fullscreen)
            {
                Program.fullscreen = false;
            }
            else
            {
                Program.fullscreen = true;
            }

            if (Program.fullscreen)
            { // set fullscreen
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            { // set windowed
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
        }

        private void Settings_Load_1(object sender, EventArgs e)
        {

        }
    }
}
