namespace LMS_160706300.Menus
{
    partial class ReportScreen
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
            this.buttonListBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonBookBorrowers = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxBookBorrowers = new System.Windows.Forms.PictureBox();
            this.pictureBoxListAllBook = new System.Windows.Forms.PictureBox();
            this.toolStripReportScreen = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookBorrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListAllBook)).BeginInit();
            this.toolStripReportScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonListBook
            // 
            this.buttonListBook.AutoSize = true;
            this.buttonListBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonListBook.Depth = 0;
            this.buttonListBook.Icon = null;
            this.buttonListBook.Location = new System.Drawing.Point(60, 222);
            this.buttonListBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonListBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonListBook.Name = "buttonListBook";
            this.buttonListBook.Primary = false;
            this.buttonListBook.Size = new System.Drawing.Size(97, 36);
            this.buttonListBook.TabIndex = 1;
            this.buttonListBook.Text = "List Books";
            this.buttonListBook.UseVisualStyleBackColor = true;
            this.buttonListBook.Click += new System.EventHandler(this.GoToBookScreen);
            // 
            // buttonBookBorrowers
            // 
            this.buttonBookBorrowers.AutoSize = true;
            this.buttonBookBorrowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBookBorrowers.Depth = 0;
            this.buttonBookBorrowers.Icon = null;
            this.buttonBookBorrowers.Location = new System.Drawing.Point(253, 222);
            this.buttonBookBorrowers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBookBorrowers.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBookBorrowers.Name = "buttonBookBorrowers";
            this.buttonBookBorrowers.Primary = false;
            this.buttonBookBorrowers.Size = new System.Drawing.Size(185, 36);
            this.buttonBookBorrowers.TabIndex = 3;
            this.buttonBookBorrowers.Text = "Show Book Borrowers";
            this.buttonBookBorrowers.UseVisualStyleBackColor = true;
            this.buttonBookBorrowers.Click += new System.EventHandler(this.GoToBookBorrowersScreen);
            // 
            // pictureBoxBookBorrowers
            // 
            this.pictureBoxBookBorrowers.Image = global::LMS_160706300.Properties.Resources.borrowedbook;
            this.pictureBoxBookBorrowers.Location = new System.Drawing.Point(291, 43);
            this.pictureBoxBookBorrowers.Name = "pictureBoxBookBorrowers";
            this.pictureBoxBookBorrowers.Size = new System.Drawing.Size(101, 157);
            this.pictureBoxBookBorrowers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBookBorrowers.TabIndex = 2;
            this.pictureBoxBookBorrowers.TabStop = false;
            // 
            // pictureBoxListAllBook
            // 
            this.pictureBoxListAllBook.Image = global::LMS_160706300.Properties.Resources.clipboard;
            this.pictureBoxListAllBook.Location = new System.Drawing.Point(60, 43);
            this.pictureBoxListAllBook.Name = "pictureBoxListAllBook";
            this.pictureBoxListAllBook.Size = new System.Drawing.Size(101, 157);
            this.pictureBoxListAllBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxListAllBook.TabIndex = 0;
            this.pictureBoxListAllBook.TabStop = false;
            // 
            // toolStripReportScreen
            // 
            this.toolStripReportScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripReportScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.toolStripReportScreen.Location = new System.Drawing.Point(0, 277);
            this.toolStripReportScreen.Name = "toolStripReportScreen";
            this.toolStripReportScreen.Size = new System.Drawing.Size(470, 25);
            this.toolStripReportScreen.TabIndex = 13;
            this.toolStripReportScreen.Text = "toolStrip2";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // ReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 302);
            this.Controls.Add(this.toolStripReportScreen);
            this.Controls.Add(this.buttonBookBorrowers);
            this.Controls.Add(this.pictureBoxBookBorrowers);
            this.Controls.Add(this.buttonListBook);
            this.Controls.Add(this.pictureBoxListAllBook);
            this.Name = "ReportScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookBorrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListAllBook)).EndInit();
            this.toolStripReportScreen.ResumeLayout(false);
            this.toolStripReportScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxListAllBook;
        private MaterialSkin.Controls.MaterialFlatButton buttonListBook;
        private System.Windows.Forms.PictureBox pictureBoxBookBorrowers;
        private MaterialSkin.Controls.MaterialFlatButton buttonBookBorrowers;
        private System.Windows.Forms.ToolStrip toolStripReportScreen;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
    }
}