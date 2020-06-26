using System;
using System.Windows.Forms;

namespace LMS_160706300.Menus
{
    partial class DatabaseOperations
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
            this.toolStripEditLibrary = new System.Windows.Forms.ToolStrip();
            this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
            this.buttonAddSection = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonDeleteBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonUpdateBook = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonBorrow = new MaterialSkin.Controls.MaterialFlatButton();
            this.barrowSection = new System.Windows.Forms.PictureBox();
            this.updateSection = new System.Windows.Forms.PictureBox();
            this.deleteSection = new System.Windows.Forms.PictureBox();
            this.addSection = new System.Windows.Forms.PictureBox();
            this.toolStripEditLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrowSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSection)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEditLibrary
            // 
            this.toolStripEditLibrary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripEditLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackButton});
            this.toolStripEditLibrary.Location = new System.Drawing.Point(0, 287);
            this.toolStripEditLibrary.Name = "toolStripEditLibrary";
            this.toolStripEditLibrary.Size = new System.Drawing.Size(710, 25);
            this.toolStripEditLibrary.TabIndex = 11;
            this.toolStripEditLibrary.Text = "toolStrip2";
            this.toolStripEditLibrary.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ReturnToHomeScreen);
            // 
            // toolStripBackButton
            // 
            this.toolStripBackButton.Image = global::LMS_160706300.Properties.Resources.left_arrow;
            this.toolStripBackButton.Name = "toolStripBackButton";
            this.toolStripBackButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackButton.Click += new System.EventHandler(this.BackToHomeScreen);
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.AutoSize = true;
            this.buttonAddSection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddSection.Depth = 0;
            this.buttonAddSection.Icon = null;
            this.buttonAddSection.Location = new System.Drawing.Point(24, 213);
            this.buttonAddSection.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddSection.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Primary = false;
            this.buttonAddSection.Size = new System.Drawing.Size(88, 36);
            this.buttonAddSection.TabIndex = 12;
            this.buttonAddSection.Text = "Add Book";
            this.buttonAddSection.UseVisualStyleBackColor = true;
            this.buttonAddSection.Click += new System.EventHandler(this.GoToAddPage);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.AutoSize = true;
            this.buttonDeleteBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteBook.Depth = 0;
            this.buttonDeleteBook.Icon = null;
            this.buttonDeleteBook.Location = new System.Drawing.Point(193, 213);
            this.buttonDeleteBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Primary = false;
            this.buttonDeleteBook.Size = new System.Drawing.Size(109, 36);
            this.buttonDeleteBook.TabIndex = 13;
            this.buttonDeleteBook.Text = "Delete Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.GoToDeletePage);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.AutoSize = true;
            this.buttonUpdateBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonUpdateBook.Depth = 0;
            this.buttonUpdateBook.Icon = null;
            this.buttonUpdateBook.Location = new System.Drawing.Point(369, 209);
            this.buttonUpdateBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonUpdateBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Primary = false;
            this.buttonUpdateBook.Size = new System.Drawing.Size(113, 36);
            this.buttonUpdateBook.TabIndex = 14;
            this.buttonUpdateBook.Text = "Update Book";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.GoToUpdatePage);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.AutoSize = true;
            this.buttonBorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBorrow.Depth = 0;
            this.buttonBorrow.Icon = null;
            this.buttonBorrow.Location = new System.Drawing.Point(548, 209);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonBorrow.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Primary = false;
            this.buttonBorrow.Size = new System.Drawing.Size(117, 36);
            this.buttonBorrow.TabIndex = 16;
            this.buttonBorrow.Text = "Borrow Book";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.GoToBorrowPage);
            // 
            // barrowSection
            // 
            this.barrowSection.Image = global::LMS_160706300.Properties.Resources.borrow;
            this.barrowSection.Location = new System.Drawing.Point(529, 59);
            this.barrowSection.Name = "barrowSection";
            this.barrowSection.Size = new System.Drawing.Size(136, 108);
            this.barrowSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barrowSection.TabIndex = 15;
            this.barrowSection.TabStop = false;
            // 
            // updateSection
            // 
            this.updateSection.Image = global::LMS_160706300.Properties.Resources.updatebook;
            this.updateSection.Location = new System.Drawing.Point(349, 59);
            this.updateSection.Name = "updateSection";
            this.updateSection.Size = new System.Drawing.Size(129, 116);
            this.updateSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updateSection.TabIndex = 2;
            this.updateSection.TabStop = false;
            // 
            // deleteSection
            // 
            this.deleteSection.Image = global::LMS_160706300.Properties.Resources.deletebook;
            this.deleteSection.Location = new System.Drawing.Point(183, 59);
            this.deleteSection.Name = "deleteSection";
            this.deleteSection.Size = new System.Drawing.Size(129, 116);
            this.deleteSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteSection.TabIndex = 1;
            this.deleteSection.TabStop = false;
            // 
            // addSection
            // 
            this.addSection.Image = global::LMS_160706300.Properties.Resources.addbook;
            this.addSection.Location = new System.Drawing.Point(23, 59);
            this.addSection.Name = "addSection";
            this.addSection.Size = new System.Drawing.Size(129, 116);
            this.addSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addSection.TabIndex = 0;
            this.addSection.TabStop = false;
            // 
            // DatabaseOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 312);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.barrowSection);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonAddSection);
            this.Controls.Add(this.toolStripEditLibrary);
            this.Controls.Add(this.updateSection);
            this.Controls.Add(this.deleteSection);
            this.Controls.Add(this.addSection);
            this.Name = "DatabaseOperations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseOperationsFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseOperations_FormClosed);
            this.toolStripEditLibrary.ResumeLayout(false);
            this.toolStripEditLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barrowSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addSection;
        private System.Windows.Forms.PictureBox deleteSection;
        private System.Windows.Forms.PictureBox updateSection;
        private System.Windows.Forms.ToolStrip toolStripEditLibrary;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private MaterialSkin.Controls.MaterialFlatButton buttonAddSection;
        private MaterialSkin.Controls.MaterialFlatButton buttonDeleteBook;
        private MaterialSkin.Controls.MaterialFlatButton buttonUpdateBook;
        private PictureBox barrowSection;
        private MaterialSkin.Controls.MaterialFlatButton buttonBorrow;
    }
}