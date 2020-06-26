namespace LMS_160706300.Menus
{
    partial class SearchFromLibrary
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
            this.dataGVSListedBooks = new System.Windows.Forms.DataGridView();
            this.labelISBN = new MaterialSkin.Controls.MaterialLabel();
            this.labelPublisher = new MaterialSkin.Controls.MaterialLabel();
            this.labelEditionNumber = new MaterialSkin.Controls.MaterialLabel();
            this.labelYear = new MaterialSkin.Controls.MaterialLabel();
            this.labelAuthor = new MaterialSkin.Controls.MaterialLabel();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxISBN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPublisher = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEdition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxYear = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAuthor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolStripSearcFromLibrary = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.labelBorrowed = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBorrowedBooks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSListedBooks)).BeginInit();
            this.toolStripSearcFromLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVSListedBooks
            // 
            this.dataGVSListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVSListedBooks.Location = new System.Drawing.Point(328, 26);
            this.dataGVSListedBooks.Name = "dataGVSListedBooks";
            this.dataGVSListedBooks.Size = new System.Drawing.Size(780, 412);
            this.dataGVSListedBooks.TabIndex = 59;
            this.dataGVSListedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellsClick);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Depth = 0;
            this.labelISBN.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelISBN.Location = new System.Drawing.Point(16, 419);
            this.labelISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(42, 19);
            this.labelISBN.TabIndex = 58;
            this.labelISBN.Text = "ISBN";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Depth = 0;
            this.labelPublisher.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPublisher.Location = new System.Drawing.Point(12, 256);
            this.labelPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(71, 19);
            this.labelPublisher.TabIndex = 57;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Depth = 0;
            this.labelEditionNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEditionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEditionNumber.Location = new System.Drawing.Point(12, 202);
            this.labelEditionNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(56, 19);
            this.labelEditionNumber.TabIndex = 56;
            this.labelEditionNumber.Text = "Edition";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Depth = 0;
            this.labelYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelYear.Location = new System.Drawing.Point(14, 142);
            this.labelYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(39, 19);
            this.labelYear.TabIndex = 55;
            this.labelYear.Text = "Year";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Depth = 0;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAuthor.Location = new System.Drawing.Point(12, 79);
            this.labelAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 19);
            this.labelAuthor.TabIndex = 54;
            this.labelAuthor.Text = "Author";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(14, 26);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 19);
            this.labelTitle.TabIndex = 53;
            this.labelTitle.Text = "Title";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Depth = 0;
            this.textBoxISBN.Hint = "";
            this.textBoxISBN.Location = new System.Drawing.Point(172, 415);
            this.textBoxISBN.MaxLength = 32767;
            this.textBoxISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.PasswordChar = '\0';
            this.textBoxISBN.SelectedText = "";
            this.textBoxISBN.SelectionLength = 0;
            this.textBoxISBN.SelectionStart = 0;
            this.textBoxISBN.Size = new System.Drawing.Size(112, 23);
            this.textBoxISBN.TabIndex = 52;
            this.textBoxISBN.TabStop = false;
            this.textBoxISBN.UseSystemPasswordChar = false;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Depth = 0;
            this.textBoxPublisher.Hint = "";
            this.textBoxPublisher.Location = new System.Drawing.Point(172, 252);
            this.textBoxPublisher.MaxLength = 32767;
            this.textBoxPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.PasswordChar = '\0';
            this.textBoxPublisher.SelectedText = "";
            this.textBoxPublisher.SelectionLength = 0;
            this.textBoxPublisher.SelectionStart = 0;
            this.textBoxPublisher.Size = new System.Drawing.Size(112, 23);
            this.textBoxPublisher.TabIndex = 51;
            this.textBoxPublisher.TabStop = false;
            this.textBoxPublisher.UseSystemPasswordChar = false;
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Depth = 0;
            this.textBoxEdition.Hint = "";
            this.textBoxEdition.Location = new System.Drawing.Point(172, 198);
            this.textBoxEdition.MaxLength = 32767;
            this.textBoxEdition.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.PasswordChar = '\0';
            this.textBoxEdition.SelectedText = "";
            this.textBoxEdition.SelectionLength = 0;
            this.textBoxEdition.SelectionStart = 0;
            this.textBoxEdition.Size = new System.Drawing.Size(112, 23);
            this.textBoxEdition.TabIndex = 50;
            this.textBoxEdition.TabStop = false;
            this.textBoxEdition.UseSystemPasswordChar = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Depth = 0;
            this.textBoxYear.Hint = "";
            this.textBoxYear.Location = new System.Drawing.Point(172, 138);
            this.textBoxYear.MaxLength = 32767;
            this.textBoxYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.PasswordChar = '\0';
            this.textBoxYear.SelectedText = "";
            this.textBoxYear.SelectionLength = 0;
            this.textBoxYear.SelectionStart = 0;
            this.textBoxYear.Size = new System.Drawing.Size(112, 23);
            this.textBoxYear.TabIndex = 49;
            this.textBoxYear.TabStop = false;
            this.textBoxYear.UseSystemPasswordChar = false;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Depth = 0;
            this.textBoxAuthor.Hint = "";
            this.textBoxAuthor.Location = new System.Drawing.Point(172, 79);
            this.textBoxAuthor.MaxLength = 32767;
            this.textBoxAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.PasswordChar = '\0';
            this.textBoxAuthor.SelectedText = "";
            this.textBoxAuthor.SelectionLength = 0;
            this.textBoxAuthor.SelectionStart = 0;
            this.textBoxAuthor.Size = new System.Drawing.Size(112, 23);
            this.textBoxAuthor.TabIndex = 48;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.UseSystemPasswordChar = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Hint = "";
            this.textBoxTitle.Location = new System.Drawing.Point(172, 22);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.Size = new System.Drawing.Size(112, 23);
            this.textBoxTitle.TabIndex = 47;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.UseSystemPasswordChar = false;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Depth = 0;
            this.buttonClear.Icon = null;
            this.buttonClear.Location = new System.Drawing.Point(180, 487);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Primary = false;
            this.buttonClear.Size = new System.Drawing.Size(63, 36);
            this.buttonClear.TabIndex = 64;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ClearFields);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefresh.Depth = 0;
            this.buttonRefresh.Icon = null;
            this.buttonRefresh.Location = new System.Drawing.Point(1029, 475);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Primary = false;
            this.buttonRefresh.Size = new System.Drawing.Size(79, 36);
            this.buttonRefresh.TabIndex = 63;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshDataGridViewCells);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(38, 487);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Primary = false;
            this.buttonSearch.Size = new System.Drawing.Size(73, 36);
            this.buttonSearch.TabIndex = 62;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.SearchBook);
            // 
            // toolStripSearcFromLibrary
            // 
            this.toolStripSearcFromLibrary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripSearcFromLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.toolStripSearcFromLibrary.Location = new System.Drawing.Point(0, 548);
            this.toolStripSearcFromLibrary.Name = "toolStripSearcFromLibrary";
            this.toolStripSearcFromLibrary.Size = new System.Drawing.Size(1129, 25);
            this.toolStripSearcFromLibrary.TabIndex = 65;
            this.toolStripSearcFromLibrary.Text = "toolStrip1";
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
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToTheHomeScreen);
            // 
            // labelBorrowed
            // 
            this.labelBorrowed.AutoSize = true;
            this.labelBorrowed.Depth = 0;
            this.labelBorrowed.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBorrowed.Location = new System.Drawing.Point(14, 369);
            this.labelBorrowed.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBorrowed.Name = "labelBorrowed";
            this.labelBorrowed.Size = new System.Drawing.Size(120, 19);
            this.labelBorrowed.TabIndex = 69;
            this.labelBorrowed.Text = "Borrowed Books";
            // 
            // textBoxBorrowedBooks
            // 
            this.textBoxBorrowedBooks.Depth = 0;
            this.textBoxBorrowedBooks.Hint = "";
            this.textBoxBorrowedBooks.Location = new System.Drawing.Point(172, 365);
            this.textBoxBorrowedBooks.MaxLength = 32767;
            this.textBoxBorrowedBooks.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxBorrowedBooks.Name = "textBoxBorrowedBooks";
            this.textBoxBorrowedBooks.PasswordChar = '\0';
            this.textBoxBorrowedBooks.SelectedText = "";
            this.textBoxBorrowedBooks.SelectionLength = 0;
            this.textBoxBorrowedBooks.SelectionStart = 0;
            this.textBoxBorrowedBooks.Size = new System.Drawing.Size(112, 23);
            this.textBoxBorrowedBooks.TabIndex = 68;
            this.textBoxBorrowedBooks.TabStop = false;
            this.textBoxBorrowedBooks.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 312);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 67;
            this.materialLabel1.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Depth = 0;
            this.textBoxQuantity.Hint = "";
            this.textBoxQuantity.Location = new System.Drawing.Point(172, 308);
            this.textBoxQuantity.MaxLength = 32767;
            this.textBoxQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.SelectionLength = 0;
            this.textBoxQuantity.SelectionStart = 0;
            this.textBoxQuantity.Size = new System.Drawing.Size(112, 23);
            this.textBoxQuantity.TabIndex = 66;
            this.textBoxQuantity.TabStop = false;
            this.textBoxQuantity.UseSystemPasswordChar = false;
            // 
            // SearchFromLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 573);
            this.Controls.Add(this.labelBorrowed);
            this.Controls.Add(this.textBoxBorrowedBooks);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.toolStripSearcFromLibrary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGVSListedBooks);
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
            this.Name = "SearchFromLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search A Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchFromLibraryFormClosing);
            this.Load += new System.EventHandler(this.SearchFromLibraryFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVSListedBooks)).EndInit();
            this.toolStripSearcFromLibrary.ResumeLayout(false);
            this.toolStripSearcFromLibrary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVSListedBooks;
        private MaterialSkin.Controls.MaterialLabel labelISBN;
        private MaterialSkin.Controls.MaterialLabel labelPublisher;
        private MaterialSkin.Controls.MaterialLabel labelEditionNumber;
        private MaterialSkin.Controls.MaterialLabel labelYear;
        private MaterialSkin.Controls.MaterialLabel labelAuthor;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxISBN;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPublisher;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdition;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxYear;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAuthor;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxTitle;
        private MaterialSkin.Controls.MaterialFlatButton buttonClear;
        private MaterialSkin.Controls.MaterialFlatButton buttonRefresh;
        private MaterialSkin.Controls.MaterialFlatButton buttonSearch;
        private System.Windows.Forms.ToolStrip toolStripSearcFromLibrary;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private MaterialSkin.Controls.MaterialLabel labelBorrowed;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxBorrowedBooks;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxQuantity;
    }
}