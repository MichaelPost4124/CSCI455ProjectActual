namespace CSCI455ProjectActual
{
    partial class Prescriptions
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
            dataGridViewMyAllData = new DataGridView();
            panel1 = new Panel();
            MessagesButton = new Button();
            label1 = new Label();
            updateBtn = new Button();
            insertBtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            effectsBox = new TextBox();
            refillsBox = new TextBox();
            instructionsBox = new TextBox();
            amountBox = new TextBox();
            dateBox = new TextBox();
            nameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Paitent_Records_Button
            // 
            Paitent_Records_Button.BackColor = Color.Green;
            Paitent_Records_Button.ForeColor = SystemColors.ButtonHighlight;
            Paitent_Records_Button.Location = new Point(0, 163);
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
            button5.Location = new Point(0, 105);
            button5.Name = "button5";
            button5.Size = new Size(105, 23);
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
            button3.Location = new Point(1, 76);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 8;
            button3.Text = "Prescriptions";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridViewMyAllData
            // 
            dataGridViewMyAllData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMyAllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyAllData.Location = new Point(142, 185);
            dataGridViewMyAllData.Name = "dataGridViewMyAllData";
            dataGridViewMyAllData.RowTemplate.Height = 25;
            dataGridViewMyAllData.Size = new Size(630, 241);
            dataGridViewMyAllData.TabIndex = 12;
            dataGridViewMyAllData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(MessagesButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Paitent_Records_Button);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 438);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // MessagesButton
            // 
            MessagesButton.BackColor = Color.Green;
            MessagesButton.ForeColor = SystemColors.ButtonHighlight;
            MessagesButton.Location = new Point(0, 134);
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
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 14;
            label1.Text = "Prescriptions";
            label1.Click += label1_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(474, 144);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 51;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(380, 144);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 50;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(482, 101);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 47;
            label6.Text = "Side Effects";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 59);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 46;
            label5.Text = "Refills";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 101);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 45;
            label4.Text = "How Much Prescribed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 59);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 43;
            label3.Text = "Date Prescribed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 24);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 44;
            label2.Text = "Instructions";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 19);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 42;
            label9.Text = "Prescription Name";
            // 
            // effectsBox
            // 
            effectsBox.Location = new Point(555, 98);
            effectsBox.Name = "effectsBox";
            effectsBox.Size = new Size(100, 23);
            effectsBox.TabIndex = 39;
            // 
            // refillsBox
            // 
            refillsBox.Location = new Point(555, 56);
            refillsBox.Name = "refillsBox";
            refillsBox.Size = new Size(100, 23);
            refillsBox.TabIndex = 38;
            // 
            // instructionsBox
            // 
            instructionsBox.Location = new Point(555, 16);
            instructionsBox.Name = "instructionsBox";
            instructionsBox.Size = new Size(100, 23);
            instructionsBox.TabIndex = 37;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(317, 98);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(100, 23);
            amountBox.TabIndex = 36;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(317, 56);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(100, 23);
            dateBox.TabIndex = 35;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(317, 16);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 34;
            // 
            // Prescriptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(effectsBox);
            Controls.Add(refillsBox);
            Controls.Add(instructionsBox);
            Controls.Add(amountBox);
            Controls.Add(dateBox);
            Controls.Add(nameBox);
            Controls.Add(panel1);
            Controls.Add(dataGridViewMyAllData);
            Name = "Prescriptions";
            Text = "Prescriptions";
            Load += Prescriptions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Paitent_Records_Button;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridViewMyAllData;
        private Panel panel1;
        private Label label1;
        private Button updateBtn;
        private Button insertBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private TextBox effectsBox;
        private TextBox refillsBox;
        private TextBox instructionsBox;
        private TextBox amountBox;
        private TextBox dateBox;
        private TextBox nameBox;
        private Button MessagesButton;
    }
}