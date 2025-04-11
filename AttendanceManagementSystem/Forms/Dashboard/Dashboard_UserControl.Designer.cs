namespace AttendanceManagementSystem.Forms.Dashboard
{
    partial class Dashboard_UserControl
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
            this.lc_Dashboard = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).BeginInit();
            this.lc_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Dashboard
            // 
            this.lc_Dashboard.Controls.Add(this.panel_Body);
            this.lc_Dashboard.Controls.Add(this.panel_PageHeading);
            this.lc_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.lc_Dashboard.Name = "lc_Dashboard";
            this.lc_Dashboard.Root = this.Root;
            this.lc_Dashboard.Size = new System.Drawing.Size(1038, 768);
            this.lc_Dashboard.TabIndex = 0;
            this.lc_Dashboard.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelBody});
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
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 108);
            this.panel_PageHeading.TabIndex = 4;
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
            this.label_PageTitle.Size = new System.Drawing.Size(136, 42);
            this.label_PageTitle.TabIndex = 2;
            this.label_PageTitle.Text = "Dashboard";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 54);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(300, 28);
            this.label_PageDescription.TabIndex = 3;
            this.label_PageDescription.Text = "Overview of school event attendance.";
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 114);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // panel_Body
            // 
            this.panel_Body.Location = new System.Drawing.Point(16, 130);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1006, 622);
            this.panel_Body.TabIndex = 5;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.panel_Body;
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 114);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1012, 628);
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // Dashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Dashboard);
            this.Name = "Dashboard_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).EndInit();
            this.lc_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Dashboard;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
    }
}
