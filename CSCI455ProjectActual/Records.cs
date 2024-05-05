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

        private void Records_Load(object sender, EventArgs e)
        {

        }

        private void visitSummeryButton_Click(object sender, EventArgs e)
        {
            viewable_pdf viewable_Pdf = new viewable_pdf();
            viewable_Pdf.Show();
            //string path = Path.GetDirectoryName(OpenFileDialog.03_01_2024.pdf);
            //WebBrowserBase.           
            //string filename = "03_01_2024 Visit Summery.pdf";
            //System.Diagnostics.Process.Start(filename);
        }

        private void recordsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Messages_Click(object sender, EventArgs e)
        {
            MessageSystem messageSystem = new MessageSystem();
            this.Close();
            messageSystem.Show();
        }
    }
}
