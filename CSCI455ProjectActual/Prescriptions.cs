/*
 * Prescriptions.cs
 * This file is meant to handle Prescriptions's functionality.
 * Created by Michael Post
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
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSCI455ProjectActual
{
    public partial class Prescriptions : Form
    {
        Database database = new Database();
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        int prescription_id;
        public static readonly string[] notAllowed = { "saquinavir", "cimetidine", "fentanyl",
            "oxycodone", "desmopressin", "morphine" };
        /// <summary>
        /// Initializes Prescriptions to be viewed
        /// </summary>
        public Prescriptions()
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
                dateBox.ReadOnly = true;
                amountBox.ReadOnly = true;
                instructionsBox.ReadOnly = true;
                refillsBox.ReadOnly = true;
                effectsBox.ReadOnly = true;
                insertBtn.Visible = false;
                updateBtn.Visible = false;
            }
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
        /// <summary>
        /// Loads Prescription info from database
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void Prescriptions_Load(object sender, EventArgs e)
        {
            loadData();
        }
        /// <summary>
        /// connects to database to retrive information
        /// </summary>
        /// <returns> void </returns>
        public void loadData()
        {
            if (database.connect_db())
            {
                string query = "SELECT * FROM prescriptionInfo";
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
        }
        /// <summary>
        /// Views Database into grid format for page
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The data view grid to be updated</param>
        /// <returns> void </returns>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prescription_id = Convert.ToInt32(dataGridViewMyAllData.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[2].Value.ToString();
            amountBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[3].Value.ToString();
            instructionsBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[4].Value.ToString();
            refillsBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[5].Value.ToString();
            effectsBox.Text = dataGridViewMyAllData.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Updates the database from button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void updateBtn_Click(object sender, EventArgs e)
        {
            int pos = Array.IndexOf(notAllowed, nameBox.Text.ToLower());
            if (pos > -1)
            {
                MessageBox.Show("This Drug Interacts with Currently Prescribed Drugs.");
            }
            else
            {
                try
                {
                    database.mySqlConnection.Open();
                    cmd = new MySqlCommand("update prescriptionInfo set PrescriptionName = '" + nameBox.Text + "', DatePrescribed = '" + dateBox.Text + "', AmountPrescribed = '" +
                        amountBox.Text + "', Instructions = '" + instructionsBox.Text + "', Refills = '" + refillsBox.Text + "', SideEffects = '" + effectsBox.Text +
                         "' where prescription_id = '" + prescription_id + "'", database.mySqlConnection);
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
        }
        /// <summary>
        /// Inserts a new drug into the data base from button click
        /// </summary>
        /// <param name="sender">The button clicked.</param>
        /// <param name="e">The click of the button</param>
        /// <returns> void </returns>
        private void insertBtn_Click(object sender, EventArgs e)
        {
            int pos = Array.IndexOf(notAllowed, nameBox.Text.ToLower());
            if (pos > -1)
            {
                MessageBox.Show("This Drug Interacts with Currently Prescribed Drugs.");
            }
            else
            {
                database.mySqlConnection.Open();
                cmd = new MySqlCommand("insert into prescriptionInfo values('" + prescription_id + "','" + nameBox.Text + "','" + dateBox.Text +
                    "','" + amountBox.Text + "','" + instructionsBox.Text +
                    "','" + refillsBox.Text + "','" + effectsBox.Text +
                     "')", database.mySqlConnection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data was Saved in Database");
                database.mySqlConnection.Close();
                loadData();
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
    }
}
