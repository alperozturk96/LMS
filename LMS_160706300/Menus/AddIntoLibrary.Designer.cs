namespace LMS_160706300.MainMenu
{
    partial class AddIntoLibrary
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
            this.textBoxTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAuthor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxYear = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEdition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPublisher = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxISBN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.labelAuthor = new MaterialSkin.Controls.MaterialLabel();
            this.labelYear = new MaterialSkin.Controls.MaterialLabel();
            this.labelEditionNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelPublisher = new MaterialSkin.Controls.MaterialLabel();
            this.labelISBN = new MaterialSkin.Controls.MaterialLabel();
            this.buttonAddBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolStripAddIntoLibrary = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.dataGVAListedBooks = new System.Windows.Forms.DataGridView();
            this.labelBorrowed = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBorrowedBooks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddIntoLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAListedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Hint = "";
            this.textBoxTitle.Location = new System.Drawing.Point(171, 24);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.Size = new System.Drawing.Size(112, 23);
            this.textBoxTitle.TabIndex = 16;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.UseSystemPasswordChar = false;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Depth = 0;
            this.textBoxAuthor.Hint = "";
            this.textBoxAuthor.Location = new System.Drawing.Point(171, 81);
            this.textBoxAuthor.MaxLength = 32767;
            this.textBoxAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.PasswordChar = '\0';
            this.textBoxAuthor.SelectedText = "";
            this.textBoxAuthor.SelectionLength = 0;
            this.textBoxAuthor.SelectionStart = 0;
            this.textBoxAuthor.Size = new System.Drawing.Size(112, 23);
            this.textBoxAuthor.TabIndex = 17;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.UseSystemPasswordChar = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Depth = 0;
            this.textBoxYear.Hint = "";
            this.textBoxYear.Location = new System.Drawing.Point(171, 144);
            this.textBoxYear.MaxLength = 32767;
            this.textBoxYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.PasswordChar = '\0';
            this.textBoxYear.SelectedText = "";
            this.textBoxYear.SelectionLength = 0;
            this.textBoxYear.SelectionStart = 0;
            this.textBoxYear.Size = new System.Drawing.Size(112, 23);
            this.textBoxYear.TabIndex = 18;
            this.textBoxYear.TabStop = false;
            this.textBoxYear.UseSystemPasswordChar = false;
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Depth = 0;
            this.textBoxEdition.Hint = "";
            this.textBoxEdition.Location = new System.Drawing.Point(171, 200);
            this.textBoxEdition.MaxLength = 32767;
            this.textBoxEdition.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.PasswordChar = '\0';
            this.textBoxEdition.SelectedText = "";
            this.textBoxEdition.SelectionLength = 0;
            this.textBoxEdition.SelectionStart = 0;
            this.textBoxEdition.Size = new System.Drawing.Size(112, 23);
            this.textBoxEdition.TabIndex = 19;
            this.textBoxEdition.TabStop = false;
            this.textBoxEdition.UseSystemPasswordChar = false;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Depth = 0;
            this.textBoxPublisher.Hint = "";
            this.textBoxPublisher.Location = new System.Drawing.Point(171, 254);
            this.textBoxPublisher.MaxLength = 32767;
            this.textBoxPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.PasswordChar = '\0';
            this.textBoxPublisher.SelectedText = "";
            this.textBoxPublisher.SelectionLength = 0;
            this.textBoxPublisher.SelectionStart = 0;
            this.textBoxPublisher.Size = new System.Drawing.Size(112, 23);
            this.textBoxPublisher.TabIndex = 20;
            this.textBoxPublisher.TabStop = false;
            this.textBoxPublisher.UseSystemPasswordChar = false;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Depth = 0;
            this.textBoxISBN.Hint = "";
            this.textBoxISBN.Location = new System.Drawing.Point(171, 418);
            this.textBoxISBN.MaxLength = 13;
            this.textBoxISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.PasswordChar = '\0';
            this.textBoxISBN.SelectedText = "";
            this.textBoxISBN.SelectionLength = 0;
            this.textBoxISBN.SelectionStart = 0;
            this.textBoxISBN.Size = new System.Drawing.Size(112, 23);
            this.textBoxISBN.TabIndex = 21;
            this.textBoxISBN.TabStop = false;
            this.textBoxISBN.UseSystemPasswordChar = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(15, 28);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 19);
            this.labelTitle.TabIndex = 22;
            this.labelTitle.Text = "Title";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Depth = 0;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAuthor.Location = new System.Drawing.Point(12, 85);
            this.labelAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 19);
            this.labelAuthor.TabIndex = 23;
            this.labelAuthor.Text = "Author";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Depth = 0;
            this.labelYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelYear.Location = new System.Drawing.Point(14, 148);
            this.labelYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(39, 19);
            this.labelYear.TabIndex = 24;
            this.labelYear.Text = "Year";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Depth = 0;
            this.labelEditionNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEditionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEditionNumber.Location = new System.Drawing.Point(14, 204);
            this.labelEditionNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(56, 19);
            this.labelEditionNumber.TabIndex = 25;
            this.labelEditionNumber.Text = "Edition";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Depth = 0;
            this.labelPublisher.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPublisher.Location = new System.Drawing.Point(14, 258);
            this.labelPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(71, 19);
            this.labelPublisher.TabIndex = 26;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Depth = 0;
            this.labelISBN.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelISBN.Location = new System.Drawing.Point(12, 422);
            this.labelISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(42, 19);
            this.labelISBN.TabIndex = 27;
            this.labelISBN.Text = "ISBN";
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.AutoSize = true;
            this.buttonAddBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddBook.Depth = 0;
            this.buttonAddBook.Icon = null;
            this.buttonAddBook.Location = new System.Drawing.Point(55, 502);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Primary = false;
            this.buttonAddBook.Size = new System.Drawing.Size(88, 36);
            this.buttonAddBook.TabIndex = 28;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.AddBook);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.Depth = 0;
            this.buttonClear.Icon = null;
            this.buttonClear.Location = new System.Drawing.Point(171, 502);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Primary = false;
            this.buttonClear.Size = new System.Drawing.Size(63, 36);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearFields);
            // 
            // toolStripAddIntoLibrary
            // 
            this.toolStripAddIntoLibrary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripAddIntoLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.toolStripButton2});
            this.toolStripAddIntoLibrary.Location = new System.Drawing.Point(0, 561);
            this.toolStripAddIntoLibrary.Name = "toolStripAddIntoLibrary";
            this.toolStripAddIntoLibrary.Size = new System.Drawing.Size(1043, 25);
            this.toolStripAddIntoLibrary.TabIndex = 30;
            this.toolStripAddIntoLibrary.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 22);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackToTheDbOperations);
            // 
            // dataGVAListedBooks
            // 
            this.dataGVAListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVAListedBooks.Location = new System.Drawing.Point(313, 24);
            this.dataGVAListedBooks.Name = "dataGVAListedBooks";
            this.dataGVAListedBooks.Size = new System.Drawing.Size(718, 444);
            this.dataGVAListedBooks.TabIndex = 43;
            this.dataGVAListedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellClick);
            // 
            // labelBorrowed
            // 
            this.labelBorrowed.AutoSize = true;
            this.labelBorrowed.Depth = 0;
            this.labelBorrowed.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBorrowed.Location = new System.Drawing.Point(12, 363);
            this.labelBorrowed.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBorrowed.Name = "labelBorrowed";
            this.labelBorrowed.Size = new System.Drawing.Size(120, 19);
            this.labelBorrowed.TabIndex = 55;
            this.labelBorrowed.Text = "Borrowed Books";
            // 
            // textBoxBorrowedBooks
            // 
            this.textBoxBorrowedBooks.Depth = 0;
            this.textBoxBorrowedBooks.Hint = "";
            this.textBoxBorrowedBooks.Location = new System.Drawing.Point(171, 359);
            this.textBoxBorrowedBooks.MaxLength = 32767;
            this.textBoxBorrowedBooks.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxBorrowedBooks.Name = "textBoxBorrowedBooks";
            this.textBoxBorrowedBooks.PasswordChar = '\0';
            this.textBoxBorrowedBooks.SelectedText = "";
            this.textBoxBorrowedBooks.SelectionLength = 0;
            this.textBoxBorrowedBooks.SelectionStart = 0;
            this.textBoxBorrowedBooks.Size = new System.Drawing.Size(112, 23);
            this.textBoxBorrowedBooks.TabIndex = 54;
            this.textBoxBorrowedBooks.TabStop = false;
            this.textBoxBorrowedBooks.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 306);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 53;
            this.materialLabel1.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Depth = 0;
            this.textBoxQuantity.Hint = "";
            this.textBoxQuantity.Location = new System.Drawing.Point(171, 302);
            this.textBoxQuantity.MaxLength = 32767;
            this.textBoxQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.SelectionLength = 0;
            this.textBoxQuantity.SelectionStart = 0;
            this.textBoxQuantity.Size = new System.Drawing.Size(112, 23);
            this.textBoxQuantity.TabIndex = 52;
            this.textBoxQuantity.TabStop = false;
            this.textBoxQuantity.UseSystemPasswordChar = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LMS_160706300.Properties.Resources.home;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ReturnToHomeScreen);
            // 
            // AddIntoLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 586);
            this.Controls.Add(this.labelBorrowed);
            this.Controls.Add(this.textBoxBorrowedBooks);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dataGVAListedBooks);
            this.Controls.Add(this.toolStripAddIntoLibrary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelEditionNumber);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddIntoLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddIntoLibraryFormClosing);
            this.Load += new System.EventHandler(this.AddIntoLibraryFormLoad);
            this.toolStripAddIntoLibrary.ResumeLayout(false);
            this.toolStripAddIntoLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVAListedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxTitle;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAuthor;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxYear;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdition;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPublisher;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxISBN;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel labelAuthor;
        private MaterialSkin.Controls.MaterialLabel labelYear;
        private MaterialSkin.Controls.MaterialLabel labelEditionNumber;
        private MaterialSkin.Controls.MaterialLabel labelPublisher;
        private MaterialSkin.Controls.MaterialLabel labelISBN;
        private MaterialSkin.Controls.MaterialFlatButton buttonAddBook;
        private MaterialSkin.Controls.MaterialFlatButton buttonClear;
        private System.Windows.Forms.ToolStrip toolStripAddIntoLibrary;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.DataGridView dataGVAListedBooks;
        private MaterialSkin.Controls.MaterialLabel labelBorrowed;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxBorrowedBooks;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxQuantity;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}