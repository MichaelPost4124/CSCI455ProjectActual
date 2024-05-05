namespace CSCI455ProjectActual
{
    partial class PatientDataPage
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Paitent_Records_Button = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            MessagesButton = new Button();
            label1 = new Label();
            dataGridViewMyAllData = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            conditionsBox = new TextBox();
            allergiesBox = new TextBox();
            lvBox = new TextBox();
            sexBox = new TextBox();
            pcpBox = new TextBox();
            dobBox = new TextBox();
            ssnBox = new TextBox();
            nameBox = new TextBox();
            insertBtn = new Button();
            updateBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).BeginInit();
            SuspendLayout();
            // 
            // Paitent_Records_Button
            // 
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
            // button5
            // 
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
            // button4
            // 
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
            // button3
            // 
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
            panel1.Size = new Size(108, 438);
            panel1.TabIndex = 14;
            // 
            // MessagesButton
            // 
            MessagesButton.BackColor = Color.Green;
            MessagesButton.ForeColor = SystemColors.ButtonHighlight;
            MessagesButton.Location = new Point(0, 136);
            MessagesButton.Name = "MessagesButton";
            MessagesButton.Size = new Size(104, 23);
            MessagesButton.TabIndex = 34;
            MessagesButton.Text = "Messages";
            MessagesButton.UseVisualStyleBackColor = false;
            MessagesButton.Click += Messages_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 15;
            label1.Text = "Patient Info";
            // 
            // dataGridViewMyAllData
            // 
            dataGridViewMyAllData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMyAllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMyAllData.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMyAllData.Location = new Point(137, 272);
            dataGridViewMyAllData.Name = "dataGridViewMyAllData";
            dataGridViewMyAllData.RowTemplate.Height = 25;
            dataGridViewMyAllData.Size = new Size(618, 121);
            dataGridViewMyAllData.TabIndex = 15;
            dataGridViewMyAllData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 174);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 31;
            label8.Text = "Conditions";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 126);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 30;
            label7.Text = "Allergies";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 82);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 29;
            label6.Text = "Last Visit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 36);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 28;
            label5.Text = "Sex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 130);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 27;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 85);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 25;
            label3.Text = "SSN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 177);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 26;
            label2.Text = "PCP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 36);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 24;
            label9.Text = "Name";
            // 
            // conditionsBox
            // 
            conditionsBox.Location = new Point(564, 168);
            conditionsBox.Name = "conditionsBox";
            conditionsBox.Size = new Size(100, 23);
            conditionsBox.TabIndex = 23;
            // 
            // allergiesBox
            // 
            allergiesBox.Location = new Point(564, 118);
            allergiesBox.Name = "allergiesBox";
            allergiesBox.Size = new Size(100, 23);
            allergiesBox.TabIndex = 22;
            // 
            // lvBox
            // 
            lvBox.Location = new Point(564, 75);
            lvBox.Name = "lvBox";
            lvBox.Size = new Size(100, 23);
            lvBox.TabIndex = 21;
            // 
            // sexBox
            // 
            sexBox.Location = new Point(564, 33);
            sexBox.Name = "sexBox";
            sexBox.Size = new Size(100, 23);
            sexBox.TabIndex = 20;
            // 
            // pcpBox
            // 
            pcpBox.Location = new Point(314, 169);
            pcpBox.Name = "pcpBox";
            pcpBox.Size = new Size(100, 23);
            pcpBox.TabIndex = 19;
            // 
            // dobBox
            // 
            dobBox.Location = new Point(314, 122);
            dobBox.Name = "dobBox";
            dobBox.Size = new Size(100, 23);
            dobBox.TabIndex = 18;
            // 
            // ssnBox
            // 
            ssnBox.Location = new Point(314, 79);
            ssnBox.Name = "ssnBox";
            ssnBox.Size = new Size(100, 23);
            ssnBox.TabIndex = 17;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(314, 33);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 16;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(380, 225);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(75, 23);
            insertBtn.TabIndex = 32;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(474, 225);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 33;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // PatientDataPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(conditionsBox);
            Controls.Add(allergiesBox);
            Controls.Add(lvBox);
            Controls.Add(sexBox);
            Controls.Add(pcpBox);
            Controls.Add(dobBox);
            Controls.Add(ssnBox);
            Controls.Add(nameBox);
            Controls.Add(dataGridViewMyAllData);
            Controls.Add(panel1);
            Name = "PatientDataPage";
            Text = "PatientDataPage";
            Load += PatientDataPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Paitent_Records_Button;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridViewMyAllData;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private TextBox conditionsBox;
        private TextBox allergiesBox;
        private TextBox lvBox;
        private TextBox sexBox;
        private TextBox pcpBox;
        private TextBox dobBox;
        private TextBox ssnBox;
        private TextBox nameBox;
        private Button insertBtn;
        private Button updateBtn;
        private Button MessagesButton;
    }
}