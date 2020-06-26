namespace LMS_160706300.Menus
{
    partial class Login
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
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonSignUp = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "";
            this.textBoxEmail.Location = new System.Drawing.Point(66, 192);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(171, 23);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.Text = "test@outlook.com";
            this.textBoxEmail.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(66, 240);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(171, 23);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.Text = "bababa14";
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLogin.Depth = 0;
            this.buttonLogin.Icon = null;
            this.buttonLogin.Location = new System.Drawing.Point(77, 309);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Primary = false;
            this.buttonLogin.Size = new System.Drawing.Size(61, 36);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.LoginIntoLMS);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.AutoSize = true;
            this.buttonSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignUp.Depth = 0;
            this.buttonSignUp.Icon = null;
            this.buttonSignUp.Location = new System.Drawing.Point(176, 309);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Primary = false;
            this.buttonSignUp.Size = new System.Drawing.Size(73, 36);
            this.buttonSignUp.TabIndex = 9;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.SignUp);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::LMS_160706300.Properties.Resources.loginuser;
            this.pictureBoxLogin.Location = new System.Drawing.Point(99, 76);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(121, 91);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 10;
            this.pictureBoxLogin.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialFlatButton buttonLogin;
        private MaterialSkin.Controls.MaterialFlatButton buttonSignUp;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
    }
}