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
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_QRCamera = new DevExpress.XtraEditors.PanelControl();
            this.lci_PanelQRCamera = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_Actions = new DevExpress.XtraEditors.PanelControl();
            this.lci_PanelActions = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbe_ChooseAttendance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_QRCodeInfo = new DevExpress.XtraEditors.PanelControl();
            this.btn_StartScan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_StopScan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).BeginInit();
            this.lc_QRScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelQRCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).BeginInit();
            this.panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_QRScanner
            // 
            this.lc_QRScanner.Controls.Add(this.panel_Actions);
            this.lc_QRScanner.Controls.Add(this.panel_QRCamera);
            this.lc_QRScanner.Controls.Add(this.panel_PageHeading);
            this.lc_QRScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_QRScanner.Location = new System.Drawing.Point(0, 0);
            this.lc_QRScanner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_QRScanner.Name = "lc_QRScanner";
            this.lc_QRScanner.Root = this.Root;
            this.lc_QRScanner.Size = new System.Drawing.Size(1186, 1011);
            this.lc_QRScanner.TabIndex = 0;
            this.lc_QRScanner.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(18, 21);
            this.panel_PageHeading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1150, 151);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(35, 22);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(177, 53);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "QR Scanner";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(35, 70);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(497, 36);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "Record attendance by scanning student QR codes.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelQRCamera,
            this.lci_PanelActions});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1186, 1011);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1156, 159);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // panel_QRCamera
            // 
            this.panel_QRCamera.Location = new System.Drawing.Point(18, 180);
            this.panel_QRCamera.Name = "panel_QRCamera";
            this.panel_QRCamera.Size = new System.Drawing.Size(638, 810);
            this.panel_QRCamera.TabIndex = 8;
            // 
            // lci_PanelQRCamera
            // 
            this.lci_PanelQRCamera.Control = this.panel_QRCamera;
            this.lci_PanelQRCamera.Location = new System.Drawing.Point(0, 159);
            this.lci_PanelQRCamera.Name = "lci_PanelQRCamera";
            this.lci_PanelQRCamera.Size = new System.Drawing.Size(644, 818);
            this.lci_PanelQRCamera.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelQRCamera.TextVisible = false;
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.btn_StopScan);
            this.panel_Actions.Controls.Add(this.btn_StartScan);
            this.panel_Actions.Controls.Add(this.panel_QRCodeInfo);
            this.panel_Actions.Controls.Add(this.cbe_ChooseAttendance);
            this.panel_Actions.Location = new System.Drawing.Point(662, 180);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(506, 810);
            this.panel_Actions.TabIndex = 0;
            // 
            // lci_PanelActions
            // 
            this.lci_PanelActions.Control = this.panel_Actions;
            this.lci_PanelActions.Location = new System.Drawing.Point(644, 159);
            this.lci_PanelActions.Name = "lci_PanelActions";
            this.lci_PanelActions.Size = new System.Drawing.Size(512, 818);
            this.lci_PanelActions.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelActions.TextVisible = false;
            // 
            // cbe_ChooseAttendance
            // 
            this.cbe_ChooseAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbe_ChooseAttendance.EditValue = "Choose Attendance";
            this.cbe_ChooseAttendance.Location = new System.Drawing.Point(2, 2);
            this.cbe_ChooseAttendance.Name = "cbe_ChooseAttendance";
            this.cbe_ChooseAttendance.Properties.Appearance.Options.UseTextOptions = true;
            this.cbe_ChooseAttendance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbe_ChooseAttendance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_ChooseAttendance.Size = new System.Drawing.Size(502, 44);
            this.cbe_ChooseAttendance.TabIndex = 0;
            // 
            // panel_QRCodeInfo
            // 
            this.panel_QRCodeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_QRCodeInfo.Location = new System.Drawing.Point(2, 46);
            this.panel_QRCodeInfo.Name = "panel_QRCodeInfo";
            this.panel_QRCodeInfo.Size = new System.Drawing.Size(502, 698);
            this.panel_QRCodeInfo.TabIndex = 1;
            // 
            // btn_StartScan
            // 
            this.btn_StartScan.Location = new System.Drawing.Point(5, 750);
            this.btn_StartScan.Name = "btn_StartScan";
            this.btn_StartScan.Size = new System.Drawing.Size(253, 55);
            this.btn_StartScan.TabIndex = 2;
            this.btn_StartScan.Text = "Start Scan";
            // 
            // btn_StopScan
            // 
            this.btn_StopScan.Location = new System.Drawing.Point(264, 750);
            this.btn_StopScan.Name = "btn_StopScan";
            this.btn_StopScan.Size = new System.Drawing.Size(242, 55);
            this.btn_StopScan.TabIndex = 3;
            this.btn_StopScan.Text = "Stop Scan";
            // 
            // QRScanner_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_QRScanner);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QRScanner_UserControl";
            this.Size = new System.Drawing.Size(1186, 1011);
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).EndInit();
            this.lc_QRScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelQRCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_QRScanner;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_Actions;
        private DevExpress.XtraEditors.SimpleButton btn_StopScan;
        private DevExpress.XtraEditors.SimpleButton btn_StartScan;
        private DevExpress.XtraEditors.PanelControl panel_QRCodeInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_ChooseAttendance;
        private DevExpress.XtraEditors.PanelControl panel_QRCamera;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelQRCamera;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelActions;
    }
}
