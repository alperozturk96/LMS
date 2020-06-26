namespace LMS_160706300.Menus
{
    partial class BorrowFromLibrary
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
            this.dataGVBListedBooks = new System.Windows.Forms.DataGridView();
            this.textBoxQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonBorrow = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelID = new MaterialSkin.Controls.MaterialLabel();
            this.labelQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.buttonReturnBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolStripBorrowScreen = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBListedBooks)).BeginInit();
            this.toolStripBorrowScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVBListedBooks
            // 
            this.dataGVBListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVBListedBooks.Location = new System.Drawing.Point(12, 12);
            this.dataGVBListedBooks.MultiSelect = false;
            this.dataGVBListedBooks.Name = "dataGVBListedBooks";
            this.dataGVBListedBooks.Size = new System.Drawing.Size(940, 372);
            this.dataGVBListedBooks.TabIndex = 43;
            this.dataGVBListedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellClick);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Depth = 0;
            this.textBoxQuantity.Enabled = false;
            this.textBoxQuantity.Hint = "";
            this.textBoxQuantity.Location = new System.Drawing.Point(174, 483);
            this.textBoxQuantity.MaxLength = 32767;
            this.textBoxQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.SelectionLength = 0;
            this.textBoxQuantity.SelectionStart = 0;
            this.textBoxQuantity.Size = new System.Drawing.Size(138, 23);
            this.textBoxQuantity.TabIndex = 44;
            this.textBoxQuantity.TabStop = false;
            this.textBoxQuantity.UseSystemPasswordChar = false;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.AutoSize = true;
            this.buttonBorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBorrow.Depth = 0;
            this.buttonBorrow.Icon = null;
            this.buttonBorrow.Location = new System.Drawing.Point(63, 524);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Primary = false;
            this.buttonBorrow.Size = new System.Drawing.Size(78, 36);
            this.buttonBorrow.TabIndex = 45;
            this.buttonBorrow.Text = "Borrow";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.BorrowABook);
            // 
            // textBoxId
            // 
            this.textBoxId.Depth = 0;
            this.textBoxId.Enabled = false;
            this.textBoxId.Hint = "";
            this.textBoxId.Location = new System.Drawing.Point(174, 431);
            this.textBoxId.MaxLength = 32767;
            this.textBoxId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.SelectedText = "";
            this.textBoxId.SelectionLength = 0;
            this.textBoxId.SelectionStart = 0;
            this.textBoxId.Size = new System.Drawing.Size(246, 23);
            this.textBoxId.TabIndex = 46;
            this.textBoxId.TabStop = false;
            this.textBoxId.UseSystemPasswordChar = false;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Depth = 0;
            this.labelID.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelID.Location = new System.Drawing.Point(118, 431);
            this.labelID.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 19);
            this.labelID.TabIndex = 47;
            this.labelID.Text = "ID";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Depth = 0;
            this.labelQuantity.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelQuantity.Location = new System.Drawing.Point(12, 479);
            this.labelQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(129, 19);
            this.labelQuantity.TabIndex = 48;
            this.labelQuantity.Text = "Available Quantity";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.AutoSize = true;
            this.buttonReturnBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReturnBook.Depth = 0;
            this.buttonReturnBook.Icon = null;
            this.buttonReturnBook.Location = new System.Drawing.Point(614, 524);
            this.buttonReturnBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonReturnBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Primary = false;
            this.buttonReturnBook.Size = new System.Drawing.Size(125, 36);
            this.buttonReturnBook.TabIndex = 49;
            this.buttonReturnBook.Text = "Return A Book";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.ReturnABook);
            // 
            // toolStripBorrowScreen
            // 
            this.toolStripBorrowScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBorrowScreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripButton2});
            this.toolStripBorrowScreen.Location = new System.Drawing.Point(0, 623);
            this.toolStripBorrowScreen.Name = "toolStripBorrowScreen";
            this.toolStripBorrowScreen.Size = new System.Drawing.Size(964, 25);
            this.toolStripBorrowScreen.TabIndex = 50;
            this.toolStripBorrowScreen.Text = "toolStrip1";
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
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToTheDatabaseOperations);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LMS_160706300.Properties.Resources.home;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ReturnHomePage);
            // 
            // BorrowFromLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 648);
            this.Controls.Add(this.toolStripBorrowScreen);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dataGVBListedBooks);
            this.Name = "BorrowFromLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow A Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BorrowFromLibraryFormClosing);
            this.Load += new System.EventHandler(this.BorrowABookFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBListedBooks)).EndInit();
            this.toolStripBorrowScreen.ResumeLayout(false);
            this.toolStripBorrowScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVBListedBooks;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxQuantity;
        private MaterialSkin.Controls.MaterialFlatButton buttonBorrow;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxId;
        private MaterialSkin.Controls.MaterialLabel labelID;
        private MaterialSkin.Controls.MaterialLabel labelQuantity;
        private MaterialSkin.Controls.MaterialFlatButton buttonReturnBook;
        private System.Windows.Forms.ToolStrip toolStripBorrowScreen;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}