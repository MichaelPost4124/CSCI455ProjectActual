namespace CSCI455ProjectActual
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            Paitent_Records_Button = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            darkButton = new Button();
            logOutButton = new Button();
            panel1 = new Panel();
            MessagesButton = new Button();
            label1 = new Label();
            desktopButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(3, 112);
            Paitent_Records_Button.Name = "Paitent_Records_Button";
            Paitent_Records_Button.Size = new Size(104, 23);
            Paitent_Records_Button.TabIndex = 15;
            Paitent_Records_Button.Text = "Records";
            Paitent_Records_Button.UseVisualStyleBackColor = false;
            Paitent_Records_Button.Click += Paitent_Records_Button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(3, 170);
            button5.Name = "button5";
            button5.Size = new Size(102, 23);
            button5.TabIndex = 14;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(3, 54);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 13;
            button4.Text = "Patient Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(3, 83);
            button3.Name = "button3";
            button3.Size = new Size(102, 23);
            button3.TabIndex = 12;
            button3.Text = "Prescriptions";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // darkButton
            // 
            darkButton.BackColor = Color.Green;
            darkButton.ForeColor = SystemColors.ButtonHighlight;
            darkButton.Location = new Point(393, 301);
            darkButton.Name = "darkButton";
            darkButton.Size = new Size(135, 26);
            darkButton.TabIndex = 16;
            darkButton.Text = "Toggle Dark/Light Mode";
            darkButton.UseVisualStyleBackColor = false;
            darkButton.Click += darkButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Green;
            logOutButton.ForeColor = SystemColors.ButtonHighlight;
            logOutButton.Location = new Point(393, 221);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(135, 26);
            logOutButton.TabIndex = 17;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(MessagesButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(Paitent_Records_Button);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 438);
            panel1.TabIndex = 18;
            // 
            // MessagesButton
            // 
            MessagesButton.BackColor = Color.Green;
            MessagesButton.ForeColor = SystemColors.ButtonHighlight;
            MessagesButton.Location = new Point(1, 141);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(104, 23);
            MessagesButton.TabIndex = 35;
            MessagesButton.Text = "Messages";
            MessagesButton.UseVisualStyleBackColor = false;
            MessagesButton.Click += Messages_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Settings";
            // 
            // desktopButton
            // 
            desktopButton.BackColor = Color.Green;
            desktopButton.ForeColor = SystemColors.ButtonHighlight;
            desktopButton.Location = new Point(393, 141);
            desktopButton.Name = "desktopButton";
            desktopButton.Size = new Size(135, 26);
            desktopButton.TabIndex = 19;
            desktopButton.Text = "Exit To Desktop";
            desktopButton.UseVisualStyleBackColor = false;
            desktopButton.Click += desktopButton_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(desktopButton);
            Controls.Add(panel1);
            Controls.Add(logOutButton);
            Controls.Add(darkButton);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button Paitent_Records_Button;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button darkButton;
        private Button logOutButton;
        private Panel panel1;
        private Label label1;
        private Button desktopButton;
        private Button MessagesButton;
    }
}