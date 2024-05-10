/*
 * Records.cs
 * This file is meant to handle Records's functionality.
 * Created by Wyatt Hanson
 * Created on April 30, 2024
 */

using Mysqlx.Crud;
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
    public partial class Records : Form
    {
        /// <summary>
        /// Initializes Records to be viewed
        /// </summary>
        public Records()
        {
            InitializeComponent();
            if (Program.dark)
            {
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                Paitent_Records_Button.BackColor = Color.Black;
                visitSummeryButton.BackColor = Color.Black;
                MessagesButton.BackColor = Color.Black;
            }
            if (Program.fullscreen) { // set fullscreen
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

        private void Records_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Views the current pdf from a button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void visitSummeryButton_Click(object sender, EventArgs e)
        {
            viewable_pdf viewable_Pdf = new viewable_pdf();
            viewable_Pdf.Show();
        }

        private void recordsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
