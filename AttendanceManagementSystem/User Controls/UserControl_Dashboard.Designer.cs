namespace AttendanceManagementSystem.User_Controls
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel_DashboardBody = new DevExpress.XtraEditors.PanelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PanelDashboardBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lci_PanelTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_Title = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Dashboard = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Caption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_DashboardBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelDashboardBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl3);
            this.layoutControl1.Controls.Add(this.panel_DashboardBody);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 523, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1231, 888);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel_DashboardBody
            // 
            this.panel_DashboardBody.Location = new System.Drawing.Point(16, 99);
            this.panel_DashboardBody.Name = "panel_DashboardBody";
            this.panel_DashboardBody.Size = new System.Drawing.Size(1199, 773);
            this.panel_DashboardBody.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PanelDashboardBody,
            this.lci_PanelTitle});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1231, 888);
            this.Root.TextVisible = false;
            // 
            // lci_PanelDashboardBody
            // 
            this.lci_PanelDashboardBody.Control = this.panel_DashboardBody;
            this.lci_PanelDashboardBody.Location = new System.Drawing.Point(0, 83);
            this.lci_PanelDashboardBody.Name = "lci_PanelDashboardBody";
            this.lci_PanelDashboardBody.Size = new System.Drawing.Size(1205, 779);
            this.lci_PanelDashboardBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelDashboardBody.TextVisible = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panel_Title);
            this.panelControl3.Location = new System.Drawing.Point(16, 16);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1199, 77);
            this.panelControl3.TabIndex = 6;
            // 
            // lci_PanelTitle
            // 
            this.lci_PanelTitle.Control = this.panelControl3;
            this.lci_PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.lci_PanelTitle.Name = "lci_PanelTitle";
            this.lci_PanelTitle.Size = new System.Drawing.Size(1205, 83);
            this.lci_PanelTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelTitle.TextVisible = false;
            // 
            // panel_Title
            // 
            this.panel_Title.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(113)))), ((int)(((byte)(75)))));
            this.panel_Title.Appearance.Options.UseBackColor = true;
            this.panel_Title.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_Title.Controls.Add(this.lbl_Caption);
            this.panel_Title.Controls.Add(this.lbl_Dashboard);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(1199, 77);
            this.panel_Title.TabIndex = 0;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.Appearance.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard.Appearance.Options.UseFont = true;
            this.lbl_Dashboard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(187, 58);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Dashboard";
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.Appearance.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caption.Appearance.Options.UseFont = true;
            this.lbl_Caption.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Caption.Location = new System.Drawing.Point(0, 47);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(361, 30);
            this.lbl_Caption.TabIndex = 2;
            this.lbl_Caption.Text = "Overview of school event attendance.";
            // 
            // UserControl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserControl_Dashboard";
            this.Size = new System.Drawing.Size(1231, 888);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_DashboardBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelDashboardBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Title)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_DashboardBody;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelDashboardBody;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelTitle;
        private DevExpress.XtraEditors.PanelControl panel_Title;
        private DevExpress.XtraEditors.LabelControl lbl_Caption;
        private DevExpress.XtraEditors.LabelControl lbl_Dashboard;
    }
}
