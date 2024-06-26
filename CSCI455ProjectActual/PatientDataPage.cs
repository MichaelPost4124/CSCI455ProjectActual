﻿/*
 * PatientDataPage.cs
 * This file is meant to handle PatientDataPage's Functionality.
 * Created by Michael Post
 * Created on April 30, 2024
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CSCI455ProjectActual
{
    public partial class PatientDataPage : Form
    {
        Database database = new Database();
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        int user_id;
        /// <summary>
        /// Initializes PatientDataPage to be viewed
        /// </summary>
        public PatientDataPage()
        {
            InitializeComponent();
            if (Program.dark)
            {
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                Paitent_Records_Button.BackColor = Color.Black;
                panel1.BackColor = Color.DarkGray;
                MessagesButton.BackColor = Color.Black;
            }
            if (Program.isPatient)
            {
                dataGridViewMyAllData.ReadOnly = true;
                nameBox.ReadOnly = true;
                ssnBox.ReadOnly = true;
                dobBox.ReadOnly = true;
                pcpBox.ReadOnly = true;
                lvBox.ReadOnly = true;
                sexBox.ReadOnly = true;
                allergiesBox.ReadOnly = true;
                conditionsBox.ReadOnly = true;
                insertBtn.Visible = false;
                updateBtn.Visible = false;
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
        /// <summary>
        /// loads patient data after button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void PatientDataPage_Load(object sender, EventArgs e)
        {
            loadData();
        }
        /// <summary>
        /// loads patient data from database
        /// </summary>
        /// <returns> void </returns>
        public void loadData()
        {
            if (database.connect_db())
            {
                string query = "SELECT * FROM patientInfo";
                MySqlCommand mySqlCommand = new MySqlCommand(query);
                mySqlCommand.Connection = database.mySqlConnection;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dt;

                dataGridViewMyAllData.DataSource = bindingSource;

                database.close_db();
            }
            else
            {
                MessageBox.Show("Database error");
            }
            // adpt = new MySqlDataAdapter("SELECT * FROM patientInfo", database.mySqlConnection);
            // dt = new DataTable();
            // adpt.Fill(dt);
            // dataGridViewMyAllData.DataSource = dt;

        }
        /// <summary>
        /// Views the patient data into data grid
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">the data grid view n</param>
        /// <returns> void </returns>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            user_id = Convert.ToInt32(dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            ssnBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            dobBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            pcpBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            sexBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
            lvBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[6].Value.ToString();
            allergiesBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[7].Value.ToString();
            conditionsBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[8].Value.ToString();

        }
        /// <summary>
        /// Updates a patients information from button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                database.mySqlConnection.Open();
                cmd = new MySqlCommand("update patientInfo set Name = '" + nameBox.Text + "', SSN = '" + ssnBox.Text + "', DOB = '" +
                    dobBox.Text + "', PCP = '" + pcpBox.Text + "', Sex = '" + sexBox.Text + "', LastVisit = '" + lvBox.Text +
                    "', Allergies = '" + allergiesBox.Text + "', Conditions = '" + conditionsBox.Text + "' where user_id= '" + user_id + "'", database.mySqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record was Successfully Updated");
                database.mySqlConnection.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Inserts a new patient into the database from button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void insertBtn_Click(object sender, EventArgs e)
        {
            database.mySqlConnection.Open();
            cmd = new MySqlCommand("insert into patientInfo values('" + user_id + "','" + nameBox.Text + "','" + ssnBox.Text +
                "','" + dobBox.Text + "','" + pcpBox.Text +
                "','" + sexBox.Text + "','" + lvBox.Text +
                "','" + allergiesBox.Text + "','" + conditionsBox.Text + "')", database.mySqlConnection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data was Saved in Database");
            database.mySqlConnection.Close();
            loadData();
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
