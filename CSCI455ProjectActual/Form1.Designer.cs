namespace CSCI455ProjectActual
{
    partial class homePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            Paitent_Records_Button = new Button();
            MessagePCP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(203, 131);
            label1.Name = "label1";
            label1.Size = new Size(385, 64);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Pateint Records \r\nManagement System";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(213, 394);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 3;
            button3.Text = "Prescriptions";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(349, 324);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 4;
            label2.Text = "Naviagtion";
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(89, 394);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 5;
            button4.Text = "Patient Info";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(623, 394);
            button5.Name = "button5";
            button5.Size = new Size(92, 23);
            button5.TabIndex = 6;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(349, 394);
            Paitent_Records_Button.Name = "Paitent_Records_Button";
            Paitent_Records_Button.Size = new Size(104, 23);
            Paitent_Records_Button.TabIndex = 7;
            Paitent_Records_Button.Text = "Records";
            Paitent_Records_Button.UseVisualStyleBackColor = false;
            Paitent_Records_Button.Click += Paitent_Records_Button_Click;
            // 
            // MessagePCP
            // 
            MessagePCP.BackColor = Color.Green;
            MessagePCP.ForeColor = SystemColors.ButtonHighlight;
            MessagePCP.Location = new Point(484, 394);
            MessagePCP.Name = "MessagePCP";
            MessagePCP.Size = new Size(104, 23);
            MessagePCP.TabIndex = 8;
            MessagePCP.Text = "Message PCP";
            MessagePCP.UseVisualStyleBackColor = false;
            MessagePCP.Click += MessagePCP_Click;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MessagePCP);
            Controls.Add(Paitent_Records_Button);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "homePage";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Label label2;
        private Button button4;
        private Button button5;
        private Button Paitent_Records_Button;
        private Button MessagePCP;
    }
}