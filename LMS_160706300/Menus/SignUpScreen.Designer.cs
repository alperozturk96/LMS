namespace LMS_160706300.Menus
{
    partial class SignUpScreen
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
            this.labelName = new MaterialSkin.Controls.MaterialLabel();
            this.labelSurname = new MaterialSkin.Controls.MaterialLabel();
            this.labelAge = new MaterialSkin.Controls.MaterialLabel();
            this.labelEmail = new MaterialSkin.Controls.MaterialLabel();
            this.labelPassword = new MaterialSkin.Controls.MaterialLabel();
            this.labelPasswordRepeat = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPasswordRepeat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonSignUp1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.SingUpToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.SingUpToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Depth = 0;
            this.labelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(26, 35);
            this.labelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Depth = 0;
            this.labelSurname.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSurname.Location = new System.Drawing.Point(26, 80);
            this.labelSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(68, 19);
            this.labelSurname.TabIndex = 14;
            this.labelSurname.Text = "Surname";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Depth = 0;
            this.labelAge.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAge.Location = new System.Drawing.Point(26, 163);
            this.labelAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 19);
            this.labelAge.TabIndex = 15;
            this.labelAge.Text = "Age";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Depth = 0;
            this.labelEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmail.Location = new System.Drawing.Point(26, 124);
            this.labelEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 19);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Depth = 0;
            this.labelPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(26, 201);
            this.labelPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(75, 19);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // labelPasswordRepeat
            // 
            this.labelPasswordRepeat.AutoSize = true;
            this.labelPasswordRepeat.Depth = 0;
            this.labelPasswordRepeat.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPasswordRepeat.Location = new System.Drawing.Point(26, 243);
            this.labelPasswordRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPasswordRepeat.Name = "labelPasswordRepeat";
            this.labelPasswordRepeat.Size = new System.Drawing.Size(133, 19);
            this.labelPasswordRepeat.TabIndex = 18;
            this.labelPasswordRepeat.Text = "Confirm Password";
            // 
            // textBoxName
            // 
            this.textBoxName.Depth = 0;
            this.textBoxName.Hint = "";
            this.textBoxName.Location = new System.Drawing.Point(194, 35);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.SelectedText = "";
            this.textBoxName.SelectionLength = 0;
            this.textBoxName.SelectionStart = 0;
            this.textBoxName.Size = new System.Drawing.Size(125, 23);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.TabStop = false;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Depth = 0;
            this.textBoxSurname.Hint = "";
            this.textBoxSurname.Location = new System.Drawing.Point(194, 80);
            this.textBoxSurname.MaxLength = 32767;
            this.textBoxSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.SelectedText = "";
            this.textBoxSurname.SelectionLength = 0;
            this.textBoxSurname.SelectionStart = 0;
            this.textBoxSurname.Size = new System.Drawing.Size(125, 23);
            this.textBoxSurname.TabIndex = 20;
            this.textBoxSurname.TabStop = false;
            this.textBoxSurname.UseSystemPasswordChar = false;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Depth = 0;
            this.textBoxAge.Hint = "";
            this.textBoxAge.Location = new System.Drawing.Point(194, 163);
            this.textBoxAge.MaxLength = 32767;
            this.textBoxAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.PasswordChar = '\0';
            this.textBoxAge.SelectedText = "";
            this.textBoxAge.SelectionLength = 0;
            this.textBoxAge.SelectionStart = 0;
            this.textBoxAge.Size = new System.Drawing.Size(125, 23);
            this.textBoxAge.TabIndex = 21;
            this.textBoxAge.TabStop = false;
            this.textBoxAge.UseSystemPasswordChar = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Depth = 0;
            this.textBoxEmail.Hint = "";
            this.textBoxEmail.Location = new System.Drawing.Point(194, 124);
            this.textBoxEmail.MaxLength = 32767;
            this.textBoxEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.PasswordChar = '\0';
            this.textBoxEmail.SelectedText = "";
            this.textBoxEmail.SelectionLength = 0;
            this.textBoxEmail.SelectionStart = 0;
            this.textBoxEmail.Size = new System.Drawing.Size(125, 23);
            this.textBoxEmail.TabIndex = 22;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "";
            this.textBoxPassword.Location = new System.Drawing.Point(194, 197);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(125, 23);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // textBoxPasswordRepeat
            // 
            this.textBoxPasswordRepeat.Depth = 0;
            this.textBoxPasswordRepeat.Hint = "";
            this.textBoxPasswordRepeat.Location = new System.Drawing.Point(194, 239);
            this.textBoxPasswordRepeat.MaxLength = 32767;
            this.textBoxPasswordRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPasswordRepeat.Name = "textBoxPasswordRepeat";
            this.textBoxPasswordRepeat.PasswordChar = '*';
            this.textBoxPasswordRepeat.SelectedText = "";
            this.textBoxPasswordRepeat.SelectionLength = 0;
            this.textBoxPasswordRepeat.SelectionStart = 0;
            this.textBoxPasswordRepeat.Size = new System.Drawing.Size(125, 23);
            this.textBoxPasswordRepeat.TabIndex = 24;
            this.textBoxPasswordRepeat.TabStop = false;
            this.textBoxPasswordRepeat.UseSystemPasswordChar = false;
            // 
            // buttonSignUp1
            // 
            this.buttonSignUp1.AutoSize = true;
            this.buttonSignUp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignUp1.Depth = 0;
            this.buttonSignUp1.Icon = null;
            this.buttonSignUp1.Location = new System.Drawing.Point(75, 294);
            this.buttonSignUp1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSignUp1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignUp1.Name = "buttonSignUp1";
            this.buttonSignUp1.Primary = false;
            this.buttonSignUp1.Size = new System.Drawing.Size(73, 36);
            this.buttonSignUp1.TabIndex = 25;
            this.buttonSignUp1.Text = "Sign Up";
            this.buttonSignUp1.UseVisualStyleBackColor = true;
            this.buttonSignUp1.Click += new System.EventHandler(this.CreateNewUser);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.Depth = 0;
            this.buttonClear.Icon = null;
            this.buttonClear.Location = new System.Drawing.Point(209, 294);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Primary = false;
            this.buttonClear.Size = new System.Drawing.Size(110, 36);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearTextBoxes);
            // 
            // SingUpToolStrip
            // 
            this.SingUpToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SingUpToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.SingUpToolStrip.Location = new System.Drawing.Point(0, 363);
            this.SingUpToolStrip.Name = "SingUpToolStrip";
            this.SingUpToolStrip.Size = new System.Drawing.Size(366, 25);
            this.SingUpToolStrip.TabIndex = 27;
            this.SingUpToolStrip.Text = "toolStrip1";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Text = "Back";
            this.toolStripBackButton.ToolTipText = "Back";
            this.toolStripBackButton.Click += new System.EventHandler(this.BackHomeScreen);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 388);
            this.Controls.Add(this.SingUpToolStrip);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSignUp1);
            this.Controls.Add(this.textBoxPasswordRepeat);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelPasswordRepeat);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "SignUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpScreenFormClosing);
            this.SingUpToolStrip.ResumeLayout(false);
            this.SingUpToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel labelName;
        private MaterialSkin.Controls.MaterialLabel labelSurname;
        private MaterialSkin.Controls.MaterialLabel labelAge;
        private MaterialSkin.Controls.MaterialLabel labelEmail;
        private MaterialSkin.Controls.MaterialLabel labelPassword;
        private MaterialSkin.Controls.MaterialLabel labelPasswordRepeat;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxName;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAge;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPasswordRepeat;
        private MaterialSkin.Controls.MaterialFlatButton buttonSignUp1;
        private MaterialSkin.Controls.MaterialFlatButton buttonClear;
        private System.Windows.Forms.ToolStrip SingUpToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
    }
}