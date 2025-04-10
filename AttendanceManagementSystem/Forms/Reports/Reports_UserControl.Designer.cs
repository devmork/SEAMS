namespace AttendanceManagementSystem.Forms.Reports
{
    partial class Reports_UserControl
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
            this.lc_Reports = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_PageBody = new DevExpress.XtraEditors.PanelControl();
            this.lci_PageBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl_Reports = new DevExpress.XtraGrid.GridControl();
            this.gridView_Reports = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Reports)).BeginInit();
            this.lc_Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageBody)).BeginInit();
            this.panel_PageBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Reports
            // 
            this.lc_Reports.Controls.Add(this.panel_PageHeading);
            this.lc_Reports.Controls.Add(this.panel_PageBody);
            this.lc_Reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Reports.Location = new System.Drawing.Point(0, 0);
            this.lc_Reports.Name = "lc_Reports";
            this.lc_Reports.Root = this.Root;
            this.lc_Reports.Size = new System.Drawing.Size(1038, 768);
            this.lc_Reports.TabIndex = 0;
            this.lc_Reports.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PageBody});
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
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 115);
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
            this.label_PageTitle.Size = new System.Drawing.Size(94, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Reports";
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
            this.label_PageDescription.Size = new System.Drawing.Size(379, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage student attendance records.";
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 121);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // panel_PageBody
            // 
            this.panel_PageBody.Controls.Add(this.gridControl_Reports);
            this.panel_PageBody.Location = new System.Drawing.Point(16, 137);
            this.panel_PageBody.Name = "panel_PageBody";
            this.panel_PageBody.Size = new System.Drawing.Size(1006, 615);
            this.panel_PageBody.TabIndex = 7;
            // 
            // lci_PageBody
            // 
            this.lci_PageBody.Control = this.panel_PageBody;
            this.lci_PageBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageBody.CustomizationFormText = "layoutControlItem1";
            this.lci_PageBody.Location = new System.Drawing.Point(0, 121);
            this.lci_PageBody.Name = "lci_PageBody";
            this.lci_PageBody.Size = new System.Drawing.Size(1012, 621);
            this.lci_PageBody.Text = "layoutControlItem1";
            this.lci_PageBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageBody.TextVisible = false;
            // 
            // gridControl_Reports
            // 
            this.gridControl_Reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Reports.Location = new System.Drawing.Point(2, 2);
            this.gridControl_Reports.MainView = this.gridView_Reports;
            this.gridControl_Reports.Name = "gridControl_Reports";
            this.gridControl_Reports.Size = new System.Drawing.Size(1002, 611);
            this.gridControl_Reports.TabIndex = 0;
            this.gridControl_Reports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Reports});
            // 
            // gridView_Reports
            // 
            this.gridView_Reports.GridControl = this.gridControl_Reports;
            this.gridView_Reports.Name = "gridView_Reports";
            // 
            // Reports_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Reports);
            this.Name = "Reports_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Reports)).EndInit();
            this.lc_Reports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageBody)).EndInit();
            this.panel_PageBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Reports;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_PageBody;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageBody;
        private DevExpress.XtraGrid.GridControl gridControl_Reports;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Reports;
    }
}
