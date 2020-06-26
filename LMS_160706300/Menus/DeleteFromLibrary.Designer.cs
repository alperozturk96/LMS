namespace LMS_160706300.Menus
{
    partial class DeleteFromLibrary
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
            this.toolStripDeleteFromLibrary = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.labelTitle = new MaterialSkin.Controls.MaterialLabel();
            this.labelEdition = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxEdition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.buttonDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonListAllBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGVD = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteFromLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripDeleteFromLibrary
            // 
            this.toolStripDeleteFromLibrary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripDeleteFromLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton,
            this.toolStripButton2});
            this.toolStripDeleteFromLibrary.Location = new System.Drawing.Point(0, 341);
            this.toolStripDeleteFromLibrary.Name = "toolStripDeleteFromLibrary";
            this.toolStripDeleteFromLibrary.Size = new System.Drawing.Size(929, 25);
            this.toolStripDeleteFromLibrary.TabIndex = 11;
            this.toolStripDeleteFromLibrary.Text = "toolStrip1";
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Depth = 0;
            this.labelTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(44, 48);
            this.labelTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(39, 19);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Title";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Depth = 0;
            this.labelEdition.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelEdition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEdition.Location = new System.Drawing.Point(44, 102);
            this.labelEdition.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(56, 19);
            this.labelEdition.TabIndex = 13;
            this.labelEdition.Text = "Edition";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Hint = "";
            this.textBoxTitle.Location = new System.Drawing.Point(126, 44);
            this.textBoxTitle.MaxLength = 32767;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PasswordChar = '\0';
            this.textBoxTitle.SelectedText = "";
            this.textBoxTitle.SelectionLength = 0;
            this.textBoxTitle.SelectionStart = 0;
            this.textBoxTitle.Size = new System.Drawing.Size(130, 23);
            this.textBoxTitle.TabIndex = 14;
            this.textBoxTitle.TabStop = false;
            this.textBoxTitle.UseSystemPasswordChar = false;
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Depth = 0;
            this.textBoxEdition.Hint = "";
            this.textBoxEdition.Location = new System.Drawing.Point(126, 95);
            this.textBoxEdition.MaxLength = 32767;
            this.textBoxEdition.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.PasswordChar = '\0';
            this.textBoxEdition.SelectedText = "";
            this.textBoxEdition.SelectionLength = 0;
            this.textBoxEdition.SelectionStart = 0;
            this.textBoxEdition.Size = new System.Drawing.Size(130, 23);
            this.textBoxEdition.TabIndex = 15;
            this.textBoxEdition.TabStop = false;
            this.textBoxEdition.UseSystemPasswordChar = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Depth = 0;
            this.buttonDelete.Icon = null;
            this.buttonDelete.Location = new System.Drawing.Point(7, 155);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Primary = false;
            this.buttonDelete.Size = new System.Drawing.Size(109, 36);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete Book";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.DeleteBook);
            // 
            // buttonListAllBook
            // 
            this.buttonListAllBook.AutoSize = true;
            this.buttonListAllBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonListAllBook.Depth = 0;
            this.buttonListAllBook.Icon = null;
            this.buttonListAllBook.Location = new System.Drawing.Point(140, 155);
            this.buttonListAllBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonListAllBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonListAllBook.Name = "buttonListAllBook";
            this.buttonListAllBook.Primary = false;
            this.buttonListAllBook.Size = new System.Drawing.Size(116, 36);
            this.buttonListAllBook.TabIndex = 17;
            this.buttonListAllBook.Text = "List All Book";
            this.buttonListAllBook.UseVisualStyleBackColor = true;
            this.buttonListAllBook.Click += new System.EventHandler(this.BackToListAllBookPage);
            // 
            // dataGVD
            // 
            this.dataGVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVD.Location = new System.Drawing.Point(331, 25);
            this.dataGVD.Name = "dataGVD";
            this.dataGVD.Size = new System.Drawing.Size(585, 251);
            this.dataGVD.TabIndex = 18;
            this.dataGVD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCellContentClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.AutoSize = true;
            this.buttonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefresh.Depth = 0;
            this.buttonRefresh.Icon = null;
            this.buttonRefresh.Location = new System.Drawing.Point(837, 285);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Primary = false;
            this.buttonRefresh.Size = new System.Drawing.Size(79, 36);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshButtonClick);
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
            // DeleteFromLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 366);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGVD);
            this.Controls.Add(this.buttonListAllBook);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxEdition);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.toolStripDeleteFromLibrary);
            this.Name = "DeleteFromLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete From Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteFromLibraryFormClosing);
            this.Load += new System.EventHandler(this.DeleteFromLibraryFormLoad);
            this.toolStripDeleteFromLibrary.ResumeLayout(false);
            this.toolStripDeleteFromLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripDeleteFromLibrary;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private MaterialSkin.Controls.MaterialLabel labelTitle;
        private MaterialSkin.Controls.MaterialLabel labelEdition;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxTitle;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxEdition;
        private MaterialSkin.Controls.MaterialFlatButton buttonDelete;
        private MaterialSkin.Controls.MaterialFlatButton buttonListAllBook;
        private System.Windows.Forms.DataGridView dataGVD;
        private MaterialSkin.Controls.MaterialFlatButton buttonRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}