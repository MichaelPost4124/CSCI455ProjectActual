/*
 * LoginPage.cs
 * This file is meant to handle LoginPage's functionality.
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
    public partial class LoginPage : Form
    {
        /// <summary>
        /// Initializes LoginPage to be viewed
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Enables login of either doctor or patient
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void Login_Button_Click(object sender, EventArgs e)
        {
            if ((Username_TextBox.Text).Equals("John") && (Password_TextBox.Text).Equals("password"))
            {
                homePage homePage = new homePage();
                Program.isPatient = true;
                this.Visible = false;
                homePage.Show();
                label1.Visible = false;
            }
            //Doctor Login
            else if ((Username_TextBox.Text).Equals("Jane") && (Password_TextBox.Text).Equals("password1"))
            {
                homePage homePage = new homePage();
                Program.isPatient = false;
                this.Visible = false;
                homePage.Show();
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
                Username_TextBox.Text = null;
                Password_TextBox.Text = null;
            }
        }

        private void Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
