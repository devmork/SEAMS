namespace AttendanceManagementSystem.Forms.QRScanner
{
    partial class QRScanner_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lc_QRScanner = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabControl_QRScanner = new DevExpress.XtraTab.XtraTabControl();
            this.lci_TabControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPage_QRScanner = new DevExpress.XtraTab.XtraTabPage();
            this.tabPage_ManualEntry = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).BeginInit();
            this.lc_QRScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_QRScanner)).BeginInit();
            this.tabControl_QRScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_QRScanner
            // 
            this.lc_QRScanner.Controls.Add(this.tabControl_QRScanner);
            this.lc_QRScanner.Controls.Add(this.panel_PageHeading);
            this.lc_QRScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_QRScanner.Location = new System.Drawing.Point(0, 0);
            this.lc_QRScanner.Name = "lc_QRScanner";
            this.lc_QRScanner.Root = this.Root;
            this.lc_QRScanner.Size = new System.Drawing.Size(1038, 768);
            this.lc_QRScanner.TabIndex = 0;
            this.lc_QRScanner.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_TabControl});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1038, 768);
            this.Root.TextVisible = false;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 130);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 17);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(142, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "QR Scanner";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 53);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(404, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "Record attendance by scanning student QR codes.";
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 136);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // tabControl_QRScanner
            // 
            this.tabControl_QRScanner.Appearance.Options.UseTextOptions = true;
            this.tabControl_QRScanner.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabControl_QRScanner.Location = new System.Drawing.Point(16, 152);
            this.tabControl_QRScanner.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.tabControl_QRScanner.Name = "tabControl_QRScanner";
            this.tabControl_QRScanner.SelectedTabPage = this.tabPage_QRScanner;
            this.tabControl_QRScanner.Size = new System.Drawing.Size(1006, 600);
            this.tabControl_QRScanner.TabIndex = 8;
            this.tabControl_QRScanner.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPage_QRScanner,
            this.tabPage_ManualEntry});
            // 
            // lci_TabControl
            // 
            this.lci_TabControl.Control = this.tabControl_QRScanner;
            this.lci_TabControl.Location = new System.Drawing.Point(0, 136);
            this.lci_TabControl.Name = "lci_TabControl";
            this.lci_TabControl.Size = new System.Drawing.Size(1012, 606);
            this.lci_TabControl.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TabControl.TextVisible = false;
            // 
            // tabPage_QRScanner
            // 
            this.tabPage_QRScanner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage_QRScanner.Name = "tabPage_QRScanner";
            this.tabPage_QRScanner.Size = new System.Drawing.Size(1004, 569);
            this.tabPage_QRScanner.Text = "QR Scanner";
            // 
            // tabPage_ManualEntry
            // 
            this.tabPage_ManualEntry.Name = "tabPage_ManualEntry";
            this.tabPage_ManualEntry.Size = new System.Drawing.Size(1004, 569);
            this.tabPage_ManualEntry.Text = "Manual Entry";
            // 
            // QRScanner_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_QRScanner);
            this.Name = "QRScanner_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).EndInit();
            this.lc_QRScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_QRScanner)).EndInit();
            this.tabControl_QRScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_TabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_QRScanner;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraTab.XtraTabControl tabControl_QRScanner;
        private DevExpress.XtraTab.XtraTabPage tabPage_QRScanner;
        private DevExpress.XtraTab.XtraTabPage tabPage_ManualEntry;
        private DevExpress.XtraLayout.LayoutControlItem lci_TabControl;
    }
}
