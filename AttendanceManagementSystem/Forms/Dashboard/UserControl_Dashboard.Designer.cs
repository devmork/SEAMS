namespace AttendanceManagementSystem.Forms.Dashboard
{
    partial class UserControl_Dashboard
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
            this.panel_DashboardBody = new DevExpress.XtraEditors.PanelControl();
            this.lci_PanelDashboardBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).BeginInit();
            this.lc_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_DashboardBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelDashboardBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Dashboard
            // 
            this.lc_Dashboard.Controls.Add(this.panel_DashboardBody);
            this.lc_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.lc_Dashboard.Name = "lc_Dashboard";
            this.lc_Dashboard.Root = this.Root;
            this.lc_Dashboard.Size = new System.Drawing.Size(1058, 768);
            this.lc_Dashboard.TabIndex = 0;
            this.lc_Dashboard.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PanelDashboardBody});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1058, 768);
            this.Root.TextVisible = false;
            // 
            // panel_DashboardBody
            // 
            this.panel_DashboardBody.Location = new System.Drawing.Point(16, 16);
            this.panel_DashboardBody.Name = "panel_DashboardBody";
            this.panel_DashboardBody.Size = new System.Drawing.Size(1026, 736);
            this.panel_DashboardBody.TabIndex = 4;
            // 
            // lci_PanelDashboardBody
            // 
            this.lci_PanelDashboardBody.Control = this.panel_DashboardBody;
            this.lci_PanelDashboardBody.Location = new System.Drawing.Point(0, 0);
            this.lci_PanelDashboardBody.Name = "lci_PanelDashboardBody";
            this.lci_PanelDashboardBody.Size = new System.Drawing.Size(1032, 742);
            this.lci_PanelDashboardBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelDashboardBody.TextVisible = false;
            // 
            // UserControl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Dashboard);
            this.Name = "UserControl_Dashboard";
            this.Size = new System.Drawing.Size(1058, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).EndInit();
            this.lc_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_DashboardBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelDashboardBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Dashboard;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_DashboardBody;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelDashboardBody;
    }
}
