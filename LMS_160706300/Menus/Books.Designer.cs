namespace LMS_160706300.Menus
{
    partial class Books
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
            this.toolStripBooks = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListedBooks)).BeginInit();
            this.toolStripBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVListedBooks
            // 
            this.dataGVListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListedBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGVListedBooks.Name = "dataGVListedBooks";
            this.dataGVListedBooks.Size = new System.Drawing.Size(908, 451);
            this.dataGVListedBooks.TabIndex = 0;
            // 
            // toolStripBooks
            // 
            this.toolStripBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.toolStripBooks.Location = new System.Drawing.Point(0, 472);
            this.toolStripBooks.Name = "toolStripBooks";
            this.toolStripBooks.Size = new System.Drawing.Size(936, 25);
            this.toolStripBooks.TabIndex = 13;
            this.toolStripBooks.Text = "toolStrip2";
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToReportScreen);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 497);
            this.Controls.Add(this.toolStripBooks);
            this.Controls.Add(this.dataGVListedBooks);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookListFormClosing);
            this.Load += new System.EventHandler(this.ListedBooksLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListedBooks)).EndInit();
            this.toolStripBooks.ResumeLayout(false);
            this.toolStripBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVListedBooks;
        private System.Windows.Forms.ToolStrip toolStripBooks;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
    }
}