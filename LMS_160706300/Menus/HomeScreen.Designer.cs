namespace LMS_160706300
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.buttonSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonDB = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.reportSection = new System.Windows.Forms.PictureBox();
            this.editSection = new System.Windows.Forms.PictureBox();
            this.searchSection = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSection)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.Depth = 0;
            this.buttonSearch.Icon = null;
            this.buttonSearch.Location = new System.Drawing.Point(20, 228);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Primary = false;
            this.buttonSearch.Size = new System.Drawing.Size(73, 36);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.AutoSize = true;
            this.buttonReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReport.Depth = 0;
            this.buttonReport.Icon = null;
            this.buttonReport.Location = new System.Drawing.Point(170, 231);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Primary = false;
            this.buttonReport.Size = new System.Drawing.Size(72, 36);
            this.buttonReport.TabIndex = 9;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.ReportScreen);
            // 
            // buttonDB
            // 
            this.buttonDB.AutoSize = true;
            this.buttonDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDB.Depth = 0;
            this.buttonDB.Icon = null;
            this.buttonDB.Location = new System.Drawing.Point(295, 231);
            this.buttonDB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Primary = false;
            this.buttonDB.Size = new System.Drawing.Size(125, 36);
            this.buttonDB.TabIndex = 10;
            this.buttonDB.Text = "DB Operations";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::LMS_160706300.Properties.Resources.lmBackground;
            this.pictureBoxLogo.Location = new System.Drawing.Point(99, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(216, 94);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // reportSection
            // 
            this.reportSection.Image = global::LMS_160706300.Properties.Resources.report;
            this.reportSection.Location = new System.Drawing.Point(170, 148);
            this.reportSection.Name = "reportSection";
            this.reportSection.Size = new System.Drawing.Size(76, 74);
            this.reportSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reportSection.TabIndex = 3;
            this.reportSection.TabStop = false;
            // 
            // editSection
            // 
            this.editSection.Image = global::LMS_160706300.Properties.Resources.database;
            this.editSection.Location = new System.Drawing.Point(319, 148);
            this.editSection.Margin = new System.Windows.Forms.Padding(0);
            this.editSection.Name = "editSection";
            this.editSection.Size = new System.Drawing.Size(73, 74);
            this.editSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editSection.TabIndex = 1;
            this.editSection.TabStop = false;
            // 
            // searchSection
            // 
            this.searchSection.Image = ((System.Drawing.Image)(resources.GetObject("searchSection.Image")));
            this.searchSection.Location = new System.Drawing.Point(20, 148);
            this.searchSection.Margin = new System.Windows.Forms.Padding(0);
            this.searchSection.Name = "searchSection";
            this.searchSection.Size = new System.Drawing.Size(76, 74);
            this.searchSection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchSection.TabIndex = 0;
            this.searchSection.TabStop = false;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(429, 305);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.reportSection);
            this.Controls.Add(this.editSection);
            this.Controls.Add(this.searchSection);
            this.DoubleBuffered = true;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox searchSection;
        private System.Windows.Forms.PictureBox editSection;
        private System.Windows.Forms.PictureBox reportSection;
        private MaterialSkin.Controls.MaterialFlatButton buttonSearch;
        private MaterialSkin.Controls.MaterialFlatButton buttonReport;
        private MaterialSkin.Controls.MaterialFlatButton buttonDB;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

