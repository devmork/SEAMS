namespace AttendanceManagementSystem.Forms.QR_Code_Management
{
    partial class QRCodeManagement_Form
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbe_YearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gc_QRCodes = new DevExpress.XtraGrid.GridControl();
            this.tileView_QRCodes = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.progressBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_QRCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_QRCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbe_Course
            // 
            this.cbe_Course.EditValue = "Select Course";
            this.cbe_Course.Location = new System.Drawing.Point(26, 73);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Properties.Items.AddRange(new object[] {
            "BS Nursing",
            "BS Medical Technology",
            "BS Information Technology",
            "BS Business Accountancy",
            "BS Hospitality Management",
            "BS Secondary Education",
            "BS Physical Therapy",
            "BS Pharmacy",
            "BS Radiologic Technology"});
            this.cbe_Course.Size = new System.Drawing.Size(267, 34);
            this.cbe_Course.TabIndex = 0;
            // 
            // cbe_YearLevel
            // 
            this.cbe_YearLevel.EditValue = "Select Year Level";
            this.cbe_YearLevel.Location = new System.Drawing.Point(299, 73);
            this.cbe_YearLevel.Name = "cbe_YearLevel";
            this.cbe_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_YearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_YearLevel.Size = new System.Drawing.Size(267, 34);
            this.cbe_YearLevel.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(960, 560);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(261, 80);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Download QR Codes";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gc_QRCodes
            // 
            this.gc_QRCodes.Location = new System.Drawing.Point(26, 113);
            this.gc_QRCodes.MainView = this.tileView_QRCodes;
            this.gc_QRCodes.Name = "gc_QRCodes";
            this.gc_QRCodes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gc_QRCodes.Size = new System.Drawing.Size(1195, 441);
            this.gc_QRCodes.TabIndex = 3;
            this.gc_QRCodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_QRCodes});
            this.gc_QRCodes.Load += new System.EventHandler(this.gc_QRCodes_Load);
            // 
            // tileView_QRCodes
            // 
            this.tileView_QRCodes.GridControl = this.gc_QRCodes;
            this.tileView_QRCodes.Name = "tileView_QRCodes";
            this.tileView_QRCodes.OptionsTiles.ItemBackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_QRCodes.OptionsTiles.ItemSize = new System.Drawing.Size(250, 250);
            this.tileView_QRCodes.TileColumns.Add(tableColumnDefinition1);
            this.tileView_QRCodes.TileColumns.Add(tableColumnDefinition2);
            this.tileView_QRCodes.TileColumns.Add(tableColumnDefinition3);
            this.tileView_QRCodes.TileRows.Add(tableRowDefinition1);
            this.tileView_QRCodes.TileRows.Add(tableRowDefinition2);
            this.tileView_QRCodes.TileRows.Add(tableRowDefinition3);
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // progressBar
            // 
            this.progressBar.EditValue = 0;
            this.progressBar.Location = new System.Drawing.Point(687, 88);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(534, 18);
            this.progressBar.TabIndex = 4;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(26, 560);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(185, 53);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Clear Filters";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(217, 560);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(185, 53);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Refresh";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // QRCodeManagement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 681);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gc_QRCodes);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cbe_YearLevel);
            this.Controls.Add(this.cbe_Course);
            this.Name = "QRCodeManagement_Form";
            this.Text = "QRCodeManagement_Form";
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_QRCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_QRCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_YearLevel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gc_QRCodes;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_QRCodes;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBar;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}