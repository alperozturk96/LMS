namespace LMS_160706300.Menus
{
    partial class UpdateFromLibrary
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
            this.toolStripUpdateFromLibrary = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.buttonSearch = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.dataGVUListedBooks = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonUpdate = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelBorrowed = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxBorrowedBooks = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelId = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripUpdateFromLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUListedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUpdateFromLibrary
            // 
            this.toolStripUpdateFromLibrary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripUpdateFromLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripButton2});
            this.toolStripUpdateFromLibrary.Location = new System.Drawing.Point(0, 536);
            this.toolStripUpdateFromLibrary.Name = "toolStripUpdateFromLibrary";
            this.toolStripUpdateFromLibrary.Size = new System.Drawing.Size(975, 25);
            this.toolStripUpdateFromLibrary.TabIndex = 11;
            this.toolStripUpdateFromLibrary.Text = "toolStrip1";
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
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToTheDbOperations);
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(396, 481);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Primary = false;
            this.buttonSearch.Size = new System.Drawing.Size(73, 36);
            this.buttonSearch.TabIndex = 41;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.SearchBook);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Depth = 0;
            this.labelISBN.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelISBN.Location = new System.Drawing.Point(12, 489);
            this.labelISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(42, 19);
            this.labelISBN.TabIndex = 40;
            this.labelISBN.Text = "ISBN";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Depth = 0;
            this.labelPublisher.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPublisher.Location = new System.Drawing.Point(8, 320);
            this.labelPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(71, 19);
            this.labelPublisher.TabIndex = 39;
            this.labelPublisher.Text = "Publisher";
            // 
            // labelEditionNumber
            // 
            this.labelEditionNumber.AutoSize = true;
            this.labelEditionNumber.Depth = 0;
            this.labelEditionNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEditionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEditionNumber.Location = new System.Drawing.Point(8, 266);
            this.labelEditionNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEditionNumber.Name = "labelEditionNumber";
            this.labelEditionNumber.Size = new System.Drawing.Size(56, 19);
            this.labelEditionNumber.TabIndex = 38;
            this.labelEditionNumber.Text = "Edition";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Depth = 0;
            this.labelYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelYear.Location = new System.Drawing.Point(8, 210);
            this.labelYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(39, 19);
            this.labelYear.TabIndex = 37;
            this.labelYear.Text = "Year";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Depth = 0;
            this.labelAuthor.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAuthor.Location = new System.Drawing.Point(8, 147);
            this.labelAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 19);
            this.labelAuthor.TabIndex = 36;
            this.labelAuthor.Text = "Author";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(8, 90);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 19);
            this.labelTitle.TabIndex = 35;
            this.labelTitle.Text = "Title";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Depth = 0;
            this.textBoxISBN.Hint = "";
            this.textBoxISBN.Location = new System.Drawing.Point(152, 485);
            this.textBoxISBN.MaxLength = 32767;
            this.textBoxISBN.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.PasswordChar = '\0';
            this.textBoxISBN.SelectedText = "";
            this.textBoxISBN.SelectionLength = 0;
            this.textBoxISBN.SelectionStart = 0;
            this.textBoxISBN.Size = new System.Drawing.Size(112, 23);
            this.textBoxISBN.TabIndex = 34;
            this.textBoxISBN.TabStop = false;
            this.textBoxISBN.UseSystemPasswordChar = false;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Depth = 0;
            this.textBoxPublisher.Hint = "";
            this.textBoxPublisher.Location = new System.Drawing.Point(152, 316);
            this.textBoxPublisher.MaxLength = 32767;
            this.textBoxPublisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.PasswordChar = '\0';
            this.textBoxPublisher.SelectedText = "";
            this.textBoxPublisher.SelectionLength = 0;
            this.textBoxPublisher.SelectionStart = 0;
            this.textBoxPublisher.Size = new System.Drawing.Size(112, 23);
            this.textBoxPublisher.TabIndex = 33;
            this.textBoxPublisher.TabStop = false;
            this.textBoxPublisher.UseSystemPasswordChar = false;
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Depth = 0;
            this.textBoxEdition.Hint = "";
            this.textBoxEdition.Location = new System.Drawing.Point(152, 262);
            this.textBoxEdition.MaxLength = 32767;
            this.textBoxEdition.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.PasswordChar = '\0';
            this.textBoxEdition.SelectedText = "";
            this.textBoxEdition.SelectionLength = 0;
            this.textBoxEdition.SelectionStart = 0;
            this.textBoxEdition.Size = new System.Drawing.Size(112, 23);
            this.textBoxEdition.TabIndex = 32;
            this.textBoxEdition.TabStop = false;
            this.textBoxEdition.UseSystemPasswordChar = false;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Depth = 0;
            this.textBoxYear.Hint = "";
            this.textBoxYear.Location = new System.Drawing.Point(152, 206);
            this.textBoxYear.MaxLength = 32767;
            this.textBoxYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.PasswordChar = '\0';
            this.textBoxYear.SelectedText = "";
            this.textBoxYear.SelectionLength = 0;
            this.textBoxYear.SelectionStart = 0;
            this.textBoxYear.Size = new System.Drawing.Size(112, 23);
            this.textBoxYear.TabIndex = 31;
            this.textBoxYear.TabStop = false;
            this.textBoxYear.UseSystemPasswordChar = false;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Depth = 0;
            this.textBoxAuthor.Hint = "";
            this.textBoxAuthor.Location = new System.Drawing.Point(152, 143);
            this.textBoxAuthor.MaxLength = 32767;
            this.textBoxAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.PasswordChar = '\0';
            this.textBoxAuthor.SelectedText = "";
            this.textBoxAuthor.SelectionLength = 0;
            this.textBoxAuthor.SelectionStart = 0;
            this.textBoxAuthor.Size = new System.Drawing.Size(112, 23);
            this.textBoxAuthor.TabIndex = 30;
            this.textBoxAuthor.TabStop = false;
            this.textBoxAuthor.UseSystemPasswordChar = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Hint = "";
            this.textBoxTitle.Location = new System.Drawing.Point(152, 86);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.Size = new System.Drawing.Size(112, 23);
            this.textBoxTitle.TabIndex = 29;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.UseSystemPasswordChar = false;
            // 
            // dataGVUListedBooks
            // 
            this.dataGVUListedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUListedBooks.Location = new System.Drawing.Point(286, 47);
            this.dataGVUListedBooks.Name = "dataGVUListedBooks";
            this.dataGVUListedBooks.Size = new System.Drawing.Size(677, 406);
            this.dataGVUListedBooks.TabIndex = 42;
            this.dataGVUListedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefresh.Depth = 0;
            this.buttonRefresh.Icon = null;
            this.buttonRefresh.Location = new System.Drawing.Point(883, 485);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Primary = false;
            this.buttonRefresh.Size = new System.Drawing.Size(79, 36);
            this.buttonRefresh.TabIndex = 43;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshDataGrid);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.Depth = 0;
            this.buttonUpdate.Icon = null;
            this.buttonUpdate.Location = new System.Drawing.Point(288, 481);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Primary = false;
            this.buttonUpdate.Size = new System.Drawing.Size(73, 36);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.UpdateBookDocument);
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Depth = 0;
            this.buttonClear.Icon = null;
            this.buttonClear.Location = new System.Drawing.Point(513, 481);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Primary = false;
            this.buttonClear.Size = new System.Drawing.Size(63, 36);
            this.buttonClear.TabIndex = 47;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ClearFields);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 377);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 49;
            this.materialLabel1.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Depth = 0;
            this.textBoxQuantity.Hint = "";
            this.textBoxQuantity.Location = new System.Drawing.Point(152, 373);
            this.textBoxQuantity.MaxLength = 32767;
            this.textBoxQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.PasswordChar = '\0';
            this.textBoxQuantity.SelectedText = "";
            this.textBoxQuantity.SelectionLength = 0;
            this.textBoxQuantity.SelectionStart = 0;
            this.textBoxQuantity.Size = new System.Drawing.Size(112, 23);
            this.textBoxQuantity.TabIndex = 48;
            this.textBoxQuantity.TabStop = false;
            this.textBoxQuantity.UseSystemPasswordChar = false;
            // 
            // labelBorrowed
            // 
            this.labelBorrowed.AutoSize = true;
            this.labelBorrowed.Depth = 0;
            this.labelBorrowed.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelBorrowed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBorrowed.Location = new System.Drawing.Point(12, 434);
            this.labelBorrowed.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBorrowed.Name = "labelBorrowed";
            this.labelBorrowed.Size = new System.Drawing.Size(120, 19);
            this.labelBorrowed.TabIndex = 51;
            this.labelBorrowed.Text = "Borrowed Books";
            // 
            // textBoxBorrowedBooks
            // 
            this.textBoxBorrowedBooks.Depth = 0;
            this.textBoxBorrowedBooks.Hint = "";
            this.textBoxBorrowedBooks.Location = new System.Drawing.Point(152, 430);
            this.textBoxBorrowedBooks.MaxLength = 32767;
            this.textBoxBorrowedBooks.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxBorrowedBooks.Name = "textBoxBorrowedBooks";
            this.textBoxBorrowedBooks.PasswordChar = '\0';
            this.textBoxBorrowedBooks.SelectedText = "";
            this.textBoxBorrowedBooks.SelectionLength = 0;
            this.textBoxBorrowedBooks.SelectionStart = 0;
            this.textBoxBorrowedBooks.Size = new System.Drawing.Size(112, 23);
            this.textBoxBorrowedBooks.TabIndex = 50;
            this.textBoxBorrowedBooks.TabStop = false;
            this.textBoxBorrowedBooks.UseSystemPasswordChar = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Depth = 0;
            this.labelId.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelId.Location = new System.Drawing.Point(12, 36);
            this.labelId.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 19);
            this.labelId.TabIndex = 46;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Depth = 0;
            this.textBoxId.Enabled = false;
            this.textBoxId.Hint = "";
            this.textBoxId.Location = new System.Drawing.Point(152, 32);
            this.textBoxId.MaxLength = 32767;
            this.textBoxId.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.SelectedText = "";
            this.textBoxId.SelectionLength = 0;
            this.textBoxId.SelectionStart = 0;
            this.textBoxId.Size = new System.Drawing.Size(112, 23);
            this.textBoxId.TabIndex = 45;
            this.textBoxId.TabStop = false;
            this.textBoxId.UseSystemPasswordChar = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LMS_160706300.Properties.Resources.home;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.ReturnToHomePage);
            // 
            // UpdateFromLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 561);
            this.Controls.Add(this.labelBorrowed);
            this.Controls.Add(this.textBoxBorrowedBooks);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGVUListedBooks);
            this.Controls.Add(this.buttonSearch);
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
            this.Controls.Add(this.toolStripUpdateFromLibrary);
            this.Name = "UpdateFromLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update A Book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFromLibraryFormClosing);
            this.Load += new System.EventHandler(this.UpdateFromLibraryFormLoad);
            this.toolStripUpdateFromLibrary.ResumeLayout(false);
            this.toolStripUpdateFromLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUListedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripUpdateFromLibrary;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private MaterialSkin.Controls.MaterialFlatButton buttonSearch;
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
        private System.Windows.Forms.DataGridView dataGVUListedBooks;
        private MaterialSkin.Controls.MaterialFlatButton buttonRefresh;
        private MaterialSkin.Controls.MaterialFlatButton buttonUpdate;
        private MaterialSkin.Controls.MaterialFlatButton buttonClear;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxQuantity;
        private MaterialSkin.Controls.MaterialLabel labelBorrowed;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxBorrowedBooks;
        private MaterialSkin.Controls.MaterialLabel labelId;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxId;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}