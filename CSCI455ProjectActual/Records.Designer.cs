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
            SuspendLayout();
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(348, 369);
            Paitent_Records_Button.Name = "Paitent_Records_Button";
            Paitent_Records_Button.Size = new Size(104, 23);
            Paitent_Records_Button.TabIndex = 11;
            Paitent_Records_Button.Text = "Records";
            Paitent_Records_Button.UseVisualStyleBackColor = false;
            Paitent_Records_Button.Click += Paitent_Records_Button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(631, 403);
            button5.Name = "button5";
            button5.Size = new Size(81, 23);
            button5.TabIndex = 10;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(86, 403);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 9;
            button4.Text = "Patient Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(348, 403);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
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
            // Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(visitSummeryButton);
            Controls.Add(recordsBox);
            Controls.Add(Paitent_Records_Button);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Records";
            Text = "Records";
            Load += Records_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Paitent_Records_Button;
        private Button button5;
        private Button button4;
        private Button button3;
        private ComboBox recordsBox;
        private Button visitSummeryButton;
    }
}