namespace LMS_160706300.Menus
{
    partial class BookBorrowers
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
            this.dataGVListedBooks = new System.Windows.Forms.DataGridView();
            this.toolStripBookBorrowers = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListedBooks)).BeginInit();
            this.toolStripBookBorrowers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVListedBooks
            // 
            this.dataGVListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListedBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGVListedBooks.Name = "dataGVListedBooks";
            this.dataGVListedBooks.Size = new System.Drawing.Size(801, 426);
            this.dataGVListedBooks.TabIndex = 1;
            // 
            // toolStripBookBorrowers
            // 
            this.toolStripBookBorrowers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBookBorrowers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.toolStripBookBorrowers.Location = new System.Drawing.Point(0, 446);
            this.toolStripBookBorrowers.Name = "toolStripBookBorrowers";
            this.toolStripBookBorrowers.Size = new System.Drawing.Size(826, 25);
            this.toolStripBookBorrowers.TabIndex = 12;
            this.toolStripBookBorrowers.Text = "toolStrip2";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToReportScreen);
            // 
            // BookBorrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 471);
            this.Controls.Add(this.toolStripBookBorrowers);
            this.Controls.Add(this.dataGVListedBooks);
            this.Name = "BookBorrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Borrowers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookBorrowersFormClosing);
            this.Load += new System.EventHandler(this.BookBorrowersFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListedBooks)).EndInit();
            this.toolStripBookBorrowers.ResumeLayout(false);
            this.toolStripBookBorrowers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVListedBooks;
        private System.Windows.Forms.ToolStrip toolStripBookBorrowers;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
    }
}