namespace CSCI455ProjectActual
{
    partial class Records
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
            recordsBox = new ComboBox();
            visitSummeryButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(3, 105);
            Paitent_Records_Button.Name = "Paitent_Records_Button";
            Paitent_Records_Button.Size = new Size(102, 23);
            Paitent_Records_Button.TabIndex = 11;
            Paitent_Records_Button.Text = "Records";
            Paitent_Records_Button.UseVisualStyleBackColor = false;
            Paitent_Records_Button.Click += Paitent_Records_Button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(4, 134);
            button5.Name = "button5";
            button5.Size = new Size(101, 23);
            button5.TabIndex = 10;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(3, 47);
            button4.Name = "button4";
            button4.Size = new Size(102, 23);
            button4.TabIndex = 9;
            button4.Text = "Patient Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(4, 76);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 8;
            button3.Text = "Prescriptions";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // recordsBox
            // 
            recordsBox.AllowDrop = true;
            recordsBox.FormattingEnabled = true;
            recordsBox.Items.AddRange(new object[] { "03-01-2024" });
            recordsBox.Location = new Point(338, 205);
            recordsBox.Name = "recordsBox";
            recordsBox.Size = new Size(114, 23);
            recordsBox.TabIndex = 12;
            recordsBox.Text = "MM-DD-YYYY";
            recordsBox.SelectedIndexChanged += recordsBox_SelectedIndexChanged;
            // 
            // visitSummeryButton
            // 
            visitSummeryButton.BackColor = Color.Green;
            visitSummeryButton.ForeColor = SystemColors.ButtonHighlight;
            visitSummeryButton.Location = new Point(319, 250);
            visitSummeryButton.Name = "visitSummeryButton";
            visitSummeryButton.Size = new Size(162, 23);
            visitSummeryButton.TabIndex = 13;
            visitSummeryButton.Text = "View Visit Summery";
            visitSummeryButton.UseVisualStyleBackColor = false;
            visitSummeryButton.Click += visitSummeryButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(Paitent_Records_Button);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 438);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Records";
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(visitSummeryButton);
            Controls.Add(recordsBox);
            Name = "Records";
            Text = "Records";
            Load += Records_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Paitent_Records_Button;
        private Button button5;
        private Button button4;
        private Button button3;
        private ComboBox recordsBox;
        private Button visitSummeryButton;
        private Panel panel1;
        private Label label1;
    }
}