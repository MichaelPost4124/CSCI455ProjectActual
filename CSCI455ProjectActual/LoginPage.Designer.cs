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
            Login_Button.Location = new Point(349, 338);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(114, 44);
            Login_Button.TabIndex = 1;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login_Button);
            Controls.Add(Login_UND);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)Login_UND).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Login_UND;
        private Button Login_Button;
    }
}