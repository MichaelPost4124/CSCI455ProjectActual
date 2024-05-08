/*
 * MessageSystem.Designer.cs
 * This file is meant to display MessageSystem's GUI.
 * Created by Wyatt Hanson
 * Created on April 30, 2024
 */

namespace CSCI455ProjectActual {
    partial class MessageSystem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            MessagesButton = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            Paitent_Records_Button = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            sendMessageButton = new Button();
            newMessageBox = new TextBox();
            PatientComboBox = new ComboBox();
            viewMessageButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(MessagesButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Paitent_Records_Button);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 9000);
            panel1.TabIndex = 15;
            // 
            // MessagesButton
            // 
            MessagesButton.Anchor = AnchorStyles.None;
            MessagesButton.BackColor = Color.Green;
            MessagesButton.ForeColor = SystemColors.ButtonHighlight;
            MessagesButton.Location = new Point(1, 136);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(104, 23);
            MessagesButton.TabIndex = 35;
            MessagesButton.Text = "Messages";
            MessagesButton.UseVisualStyleBackColor = false;
            MessagesButton.Click += Messages_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 15;
            label1.Text = "Message System";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Green;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(0, 49);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 9;
            button4.Text = "Patient Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Green;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(0, 165);
            button5.Name = "button5";
            button5.Size = new Size(104, 23);
            button5.TabIndex = 10;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.Anchor = AnchorStyles.None;
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(1, 107);
            Paitent_Records_Button.Name = "Paitent_Records_Button";
            Paitent_Records_Button.Size = new Size(104, 23);
            Paitent_Records_Button.TabIndex = 11;
            Paitent_Records_Button.Text = "Records";
            Paitent_Records_Button.UseVisualStyleBackColor = false;
            Paitent_Records_Button.Click += Paitent_Records_Button_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(0, 78);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 8;
            button3.Text = "Prescriptions";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.None;
            richTextBox1.BackColor = SystemColors.ButtonHighlight;
            richTextBox1.Location = new Point(168, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(526, 281);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(369, 15);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 17;
            label2.Text = "Messages";
            // 
            // sendMessageButton
            // 
            sendMessageButton.Anchor = AnchorStyles.None;
            sendMessageButton.BackColor = Color.Green;
            sendMessageButton.ForeColor = SystemColors.ButtonHighlight;
            sendMessageButton.Location = new Point(583, 335);
            sendMessageButton.Name = "sendMessageButton";
            sendMessageButton.Size = new Size(111, 25);
            sendMessageButton.TabIndex = 18;
            sendMessageButton.Text = "Send Message";
            sendMessageButton.UseVisualStyleBackColor = false;
            sendMessageButton.Click += sendMessageButton_Click;
            // 
            // newMessageBox
            // 
            newMessageBox.Anchor = AnchorStyles.None;
            newMessageBox.Location = new Point(168, 337);
            newMessageBox.Name = "newMessageBox";
            newMessageBox.PlaceholderText = "Enter Your Message Here";
            newMessageBox.Size = new Size(409, 23);
            newMessageBox.TabIndex = 19;
            // 
            // PatientComboBox
            // 
            PatientComboBox.Anchor = AnchorStyles.None;
            PatientComboBox.FormattingEnabled = true;
            PatientComboBox.Items.AddRange(new object[] { "Abigal Wrongstaid", "John Doe", "Jackie Robinson", "Toby Mendle" });
            PatientComboBox.Location = new Point(255, 382);
            PatientComboBox.Name = "PatientComboBox";
            PatientComboBox.Size = new Size(158, 23);
            PatientComboBox.TabIndex = 20;
            PatientComboBox.Text = "Patient Name";
            // 
            // viewMessageButton
            // 
            viewMessageButton.Anchor = AnchorStyles.None;
            viewMessageButton.BackColor = Color.Green;
            viewMessageButton.ForeColor = SystemColors.ButtonHighlight;
            viewMessageButton.Location = new Point(430, 382);
            viewMessageButton.Name = "viewMessageButton";
            viewMessageButton.Size = new Size(111, 25);
            viewMessageButton.TabIndex = 21;
            viewMessageButton.Text = "View Messages";
            viewMessageButton.UseVisualStyleBackColor = false;
            viewMessageButton.Click += viewMessageButton_Click;
            // 
            // MessageSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewMessageButton);
            Controls.Add(PatientComboBox);
            Controls.Add(newMessageBox);
            Controls.Add(sendMessageButton);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "MessageSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageSystem";
            Load += MessageSystem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button Paitent_Records_Button;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button sendMessageButton;
        private TextBox newMessageBox;
        private ComboBox PatientComboBox;
        private Button viewMessageButton;
        private Button MessagesButton;
    }
}
