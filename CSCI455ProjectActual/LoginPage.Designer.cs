/*
 * LoginPage.Designer.cs
 * This file is meant to display LoginPage's GUI.
 * Created by Wyatt Hanson
 * Created on April 30, 2024
 */

namespace CSCI455ProjectActual
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Login_UND = new PictureBox();
            Login_Button = new Button();
            Username_TextBox = new TextBox();
            Password_TextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Login_UND).BeginInit();
            SuspendLayout();
            // 
            // Login_UND
            // 
            Login_UND.Image = (Image)resources.GetObject("Login_UND.Image");
            Login_UND.Location = new Point(1, -2);
            Login_UND.Name = "Login_UND";
            Login_UND.Size = new Size(801, 101);
            Login_UND.SizeMode = PictureBoxSizeMode.StretchImage;
            Login_UND.TabIndex = 0;
            Login_UND.TabStop = false;
            // 
            // Login_Button
            // 
            Login_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login_Button.Location = new Point(357, 325);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(114, 44);
            Login_Button.TabIndex = 1;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Username_TextBox
            // 
            Username_TextBox.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Username_TextBox.Location = new Point(285, 189);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.PlaceholderText = "Username";
            Username_TextBox.Size = new Size(267, 27);
            Username_TextBox.TabIndex = 2;
            Username_TextBox.TextAlign = HorizontalAlignment.Center;
            Username_TextBox.TextChanged += Username_TextBox_TextChanged;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Password_TextBox.Location = new Point(285, 235);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "Password";
            Password_TextBox.Size = new Size(267, 27);
            Password_TextBox.TabIndex = 3;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(225, 279);
            label1.Name = "label1";
            label1.Size = new Size(386, 32);
            label1.TabIndex = 4;
            label1.Text = "Incorrect Username or Password";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_TextBox);
            Controls.Add(Login_Button);
            Controls.Add(Login_UND);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)Login_UND).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Login_UND;
        private Button Login_Button;
        private TextBox Username_TextBox;
        private TextBox Password_TextBox;
        private Label label1;
    }
}