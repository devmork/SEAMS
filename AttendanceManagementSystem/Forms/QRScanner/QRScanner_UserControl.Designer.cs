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
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbe_ChooseEvent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_StartScan = new DevExpress.XtraEditors.SimpleButton();
            this.btn_StopScan = new DevExpress.XtraEditors.SimpleButton();
            this.panel_QRCodeInfo = new DevExpress.XtraEditors.PanelControl();
            this.label_QRCodeInfo = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseEvent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeInfo)).BeginInit();
            this.panel_QRCodeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lc_QRScanner
            // 
            this.lc_QRScanner.Controls.Add(this.panel_Actions);
            this.lc_QRScanner.Controls.Add(this.panel_QRCamera);
            this.lc_QRScanner.Controls.Add(this.panel_PageHeading);
            this.lc_QRScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_QRScanner.Location = new System.Drawing.Point(0, 0);
            this.lc_QRScanner.Name = "lc_QRScanner";
            this.lc_QRScanner.Root = this.Root;
            this.lc_QRScanner.Size = new System.Drawing.Size(1038, 768);
            this.lc_QRScanner.TabIndex = 0;
            this.lc_QRScanner.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 103);
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
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelQRCamera,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1038, 768);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 109);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // panel_QRCamera
            // 
            this.panel_QRCamera.Location = new System.Drawing.Point(16, 125);
            this.panel_QRCamera.Name = "panel_QRCamera";
            this.panel_QRCamera.Size = new System.Drawing.Size(578, 627);
            this.panel_QRCamera.TabIndex = 8;
            // 
            // lci_PanelQRCamera
            // 
            this.lci_PanelQRCamera.Control = this.panel_QRCamera;
            this.lci_PanelQRCamera.Location = new System.Drawing.Point(0, 109);
            this.lci_PanelQRCamera.Name = "lci_PanelQRCamera";
            this.lci_PanelQRCamera.Size = new System.Drawing.Size(584, 633);
            this.lci_PanelQRCamera.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelQRCamera.TextVisible = false;
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.panel_QRCodeInfo);
            this.panel_Actions.Controls.Add(this.btn_StopScan);
            this.panel_Actions.Controls.Add(this.btn_StartScan);
            this.panel_Actions.Controls.Add(this.cbe_ChooseEvent);
            this.panel_Actions.Location = new System.Drawing.Point(600, 125);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(422, 627);
            this.panel_Actions.TabIndex = 9;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panel_Actions;
            this.layoutControlItem2.Location = new System.Drawing.Point(584, 109);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(428, 633);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // cbe_ChooseEvent
            // 
            this.cbe_ChooseEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbe_ChooseEvent.EditValue = "Choose Attendance";
            this.cbe_ChooseEvent.Location = new System.Drawing.Point(2, 2);
            this.cbe_ChooseEvent.Name = "cbe_ChooseEvent";
            this.cbe_ChooseEvent.Properties.Appearance.Options.UseTextOptions = true;
            this.cbe_ChooseEvent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbe_ChooseEvent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_ChooseEvent.Size = new System.Drawing.Size(418, 34);
            this.cbe_ChooseEvent.TabIndex = 0;
            // 
            // btn_StartScan
            // 
            this.btn_StartScan.Location = new System.Drawing.Point(5, 585);
            this.btn_StartScan.Name = "btn_StartScan";
            this.btn_StartScan.Size = new System.Drawing.Size(205, 37);
            this.btn_StartScan.TabIndex = 1;
            this.btn_StartScan.Text = "Start Scan";
            // 
            // btn_StopScan
            // 
            this.btn_StopScan.Location = new System.Drawing.Point(216, 585);
            this.btn_StopScan.Name = "btn_StopScan";
            this.btn_StopScan.Size = new System.Drawing.Size(205, 37);
            this.btn_StopScan.TabIndex = 2;
            this.btn_StopScan.Text = "Stop Scan";
            // 
            // panel_QRCodeInfo
            // 
            this.panel_QRCodeInfo.Controls.Add(this.label_QRCodeInfo);
            this.panel_QRCodeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_QRCodeInfo.Location = new System.Drawing.Point(2, 36);
            this.panel_QRCodeInfo.Name = "panel_QRCodeInfo";
            this.panel_QRCodeInfo.Size = new System.Drawing.Size(418, 543);
            this.panel_QRCodeInfo.TabIndex = 3;
            // 
            // label_QRCodeInfo
            // 
            this.label_QRCodeInfo.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F);
            this.label_QRCodeInfo.Appearance.Options.UseFont = true;
            this.label_QRCodeInfo.Location = new System.Drawing.Point(115, 250);
            this.label_QRCodeInfo.Name = "label_QRCodeInfo";
            this.label_QRCodeInfo.Size = new System.Drawing.Size(188, 42);
            this.label_QRCodeInfo.TabIndex = 4;
            this.label_QRCodeInfo.Text = "ENOY, DEN MARK";
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
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelQRCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseEvent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeInfo)).EndInit();
            this.panel_QRCodeInfo.ResumeLayout(false);
            this.panel_QRCodeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_QRScanner;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_QRCamera;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelQRCamera;
        private DevExpress.XtraEditors.PanelControl panel_Actions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_ChooseEvent;
        private DevExpress.XtraEditors.PanelControl panel_QRCodeInfo;
        private DevExpress.XtraEditors.SimpleButton btn_StopScan;
        private DevExpress.XtraEditors.SimpleButton btn_StartScan;
        private DevExpress.XtraEditors.LabelControl label_QRCodeInfo;
    }
}
