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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_StartScan = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel_QRCodeData = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.cbe_ChooseAttendance = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_StopScan = new DevExpress.XtraEditors.SimpleButton();
            this.panel_Actions = new DevExpress.XtraEditors.PanelControl();
            this.panel_QRCamera = new DevExpress.XtraEditors.PanelControl();
            this.pe_QRCamera = new DevExpress.XtraEditors.PictureEdit();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelQRCamera = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelActions = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.LabelControl();
            this.txt_FullName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).BeginInit();
            this.lc_QRScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeData)).BeginInit();
            this.panel_QRCodeData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).BeginInit();
            this.panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCamera)).BeginInit();
            this.panel_QRCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCamera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelQRCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_QRScanner
            // 
            this.lc_QRScanner.Controls.Add(this.panelControl2);
            this.lc_QRScanner.Controls.Add(this.panelControl1);
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_StartScan);
            this.panelControl2.Location = new System.Drawing.Point(790, 710);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(232, 42);
            this.panelControl2.TabIndex = 10;
            // 
            // btn_StartScan
            // 
            this.btn_StartScan.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_StartScan.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_StartScan.Appearance.Options.UseBackColor = true;
            this.btn_StartScan.Appearance.Options.UseFont = true;
            this.btn_StartScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StartScan.Location = new System.Drawing.Point(2, 2);
            this.btn_StartScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StartScan.Name = "btn_StartScan";
            this.btn_StartScan.Size = new System.Drawing.Size(228, 38);
            this.btn_StartScan.StyleController = this.layoutControl1;
            this.btn_StartScan.TabIndex = 9;
            this.btn_StartScan.Text = "Start Scan";
            this.btn_StartScan.Click += new System.EventHandler(this.btn_StartScan_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel_QRCodeData);
            this.layoutControl1.Controls.Add(this.cbe_ChooseAttendance);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(450, 586);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel_QRCodeData
            // 
            this.panel_QRCodeData.Controls.Add(this.panelControl4);
            this.panel_QRCodeData.Location = new System.Drawing.Point(3, 43);
            this.panel_QRCodeData.Name = "panel_QRCodeData";
            this.panel_QRCodeData.Size = new System.Drawing.Size(444, 540);
            this.panel_QRCodeData.TabIndex = 6;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txt_FullName);
            this.panelControl4.Controls.Add(this.txt_SchoolStudentId);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(440, 536);
            this.panelControl4.TabIndex = 1;
            // 
            // cbe_ChooseAttendance
            // 
            this.cbe_ChooseAttendance.EditValue = "Choose Attendance";
            this.cbe_ChooseAttendance.Location = new System.Drawing.Point(3, 3);
            this.cbe_ChooseAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbe_ChooseAttendance.Name = "cbe_ChooseAttendance";
            this.cbe_ChooseAttendance.Properties.Appearance.Options.UseTextOptions = true;
            this.cbe_ChooseAttendance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbe_ChooseAttendance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_ChooseAttendance.Size = new System.Drawing.Size(444, 34);
            this.cbe_ChooseAttendance.StyleController = this.layoutControl1;
            this.cbe_ChooseAttendance.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 586);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbe_ChooseAttendance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(450, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panel_QRCodeData;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(450, 546);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_StopScan);
            this.panelControl1.Location = new System.Drawing.Point(568, 710);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(216, 42);
            this.panelControl1.TabIndex = 9;
            // 
            // btn_StopScan
            // 
            this.btn_StopScan.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_StopScan.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_StopScan.Appearance.Options.UseBackColor = true;
            this.btn_StopScan.Appearance.Options.UseFont = true;
            this.btn_StopScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_StopScan.Location = new System.Drawing.Point(2, 2);
            this.btn_StopScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StopScan.Name = "btn_StopScan";
            this.btn_StopScan.Size = new System.Drawing.Size(212, 38);
            this.btn_StopScan.StyleController = this.layoutControl1;
            this.btn_StopScan.TabIndex = 7;
            this.btn_StopScan.Text = "Stop Scan";
            this.btn_StopScan.Click += new System.EventHandler(this.btn_StopScan_Click);
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.layoutControl1);
            this.panel_Actions.Location = new System.Drawing.Point(568, 114);
            this.panel_Actions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(454, 590);
            this.panel_Actions.TabIndex = 0;
            // 
            // panel_QRCamera
            // 
            this.panel_QRCamera.Controls.Add(this.pe_QRCamera);
            this.panel_QRCamera.Location = new System.Drawing.Point(16, 114);
            this.panel_QRCamera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_QRCamera.Name = "panel_QRCamera";
            this.panel_QRCamera.Size = new System.Drawing.Size(546, 638);
            this.panel_QRCamera.TabIndex = 8;
            // 
            // pe_QRCamera
            // 
            this.pe_QRCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCamera.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCamera.Name = "pe_QRCamera";
            this.pe_QRCamera.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCamera.Size = new System.Drawing.Size(542, 634);
            this.pe_QRCamera.TabIndex = 2;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 92);
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
            this.lci_PanelActions,
            this.layoutControlItem4,
            this.layoutControlItem5});
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
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 98);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_PanelQRCamera
            // 
            this.lci_PanelQRCamera.Control = this.panel_QRCamera;
            this.lci_PanelQRCamera.Location = new System.Drawing.Point(0, 98);
            this.lci_PanelQRCamera.Name = "lci_PanelQRCamera";
            this.lci_PanelQRCamera.Size = new System.Drawing.Size(552, 644);
            this.lci_PanelQRCamera.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelQRCamera.TextVisible = false;
            // 
            // lci_PanelActions
            // 
            this.lci_PanelActions.Control = this.panel_Actions;
            this.lci_PanelActions.Location = new System.Drawing.Point(552, 98);
            this.lci_PanelActions.Name = "lci_PanelActions";
            this.lci_PanelActions.Size = new System.Drawing.Size(460, 596);
            this.lci_PanelActions.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelActions.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.panelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(552, 694);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(222, 48);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.panelControl2;
            this.layoutControlItem5.Location = new System.Drawing.Point(774, 694);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(238, 48);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Appearance.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SchoolStudentId.Appearance.Options.UseFont = true;
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(70, 159);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(100, 37);
            this.txt_SchoolStudentId.TabIndex = 0;
            this.txt_SchoolStudentId.Text = "2023-2172";
            // 
            // txt_FullName
            // 
            this.txt_FullName.Appearance.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FullName.Appearance.Options.UseFont = true;
            this.txt_FullName.Location = new System.Drawing.Point(70, 215);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(208, 37);
            this.txt_FullName.TabIndex = 1;
            this.txt_FullName.Text = "JEEVON M. RICAFORT";
            // 
            // QRScanner_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_QRScanner);
            this.Name = "QRScanner_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            this.Load += new System.EventHandler(this.QRScanner_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_QRScanner)).EndInit();
            this.lc_QRScanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCodeData)).EndInit();
            this.panel_QRCodeData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_ChooseAttendance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCamera)).EndInit();
            this.panel_QRCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCamera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelQRCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panel_QRCodeData;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_ChooseAttendance;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelActions;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PictureEdit pe_QRCamera;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_StartScan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_StopScan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LabelControl txt_FullName;
        private DevExpress.XtraEditors.LabelControl txt_SchoolStudentId;
    }
}
