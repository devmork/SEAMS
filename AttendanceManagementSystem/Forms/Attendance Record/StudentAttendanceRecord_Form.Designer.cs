namespace AttendanceManagementSystem.Forms.Attendance_Report
{
    partial class StudentAttendanceRecord_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAttendanceRecord_Form));
            this.lc_StudentAttendanceRecord = new DevExpress.XtraLayout.LayoutControl();
            this.panel_ResetRecord = new DevExpress.XtraEditors.PanelControl();
            this.btn_ResetRecord = new DevExpress.XtraEditors.SimpleButton();
            this.gc_AttendanceRecord = new DevExpress.XtraGrid.GridControl();
            this.gv_AttendanceRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_AttendanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Remarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_TotalAttendance = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.panel_TotalAbsent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalAbsent = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalAbsent = new DevExpress.XtraEditors.TextEdit();
            this.panel_TotalPresent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalPresent = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalPresent = new DevExpress.XtraEditors.TextEdit();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.btn_CloseForm = new DevExpress.XtraEditors.PictureEdit();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalPresent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalAttendance = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_gridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lci_ResetRecord = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).BeginInit();
            this.lc_StudentAttendanceRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_ResetRecord)).BeginInit();
            this.panel_ResetRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).BeginInit();
            this.panel_TotalAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).BeginInit();
            this.panel_TotalAbsent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).BeginInit();
            this.panel_TotalPresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ResetRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_StudentAttendanceRecord
            // 
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_ResetRecord);
            this.lc_StudentAttendanceRecord.Controls.Add(this.gc_AttendanceRecord);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAttendance);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAbsent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalPresent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_PageHeading);
            this.lc_StudentAttendanceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_StudentAttendanceRecord.Location = new System.Drawing.Point(0, 0);
            this.lc_StudentAttendanceRecord.Name = "lc_StudentAttendanceRecord";
            this.lc_StudentAttendanceRecord.Root = this.Root;
            this.lc_StudentAttendanceRecord.Size = new System.Drawing.Size(1119, 649);
            this.lc_StudentAttendanceRecord.TabIndex = 0;
            this.lc_StudentAttendanceRecord.Text = "layoutControl1";
            // 
            // panel_ResetRecord
            // 
            this.panel_ResetRecord.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_ResetRecord.Appearance.Options.UseBackColor = true;
            this.panel_ResetRecord.Controls.Add(this.btn_ResetRecord);
            this.panel_ResetRecord.Location = new System.Drawing.Point(796, 591);
            this.panel_ResetRecord.Name = "panel_ResetRecord";
            this.panel_ResetRecord.Size = new System.Drawing.Size(307, 42);
            this.panel_ResetRecord.TabIndex = 9;
            // 
            // btn_ResetRecord
            // 
            this.btn_ResetRecord.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(51)))), ((int)(((byte)(234)))));
            this.btn_ResetRecord.Appearance.Font = new System.Drawing.Font("Poppins", 13.5F);
            this.btn_ResetRecord.Appearance.Options.UseBackColor = true;
            this.btn_ResetRecord.Appearance.Options.UseFont = true;
            this.btn_ResetRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ResetRecord.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_ResetRecord.ImageOptions.ImageToTextIndent = 22;
            this.btn_ResetRecord.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ResetRecord.ImageOptions.SvgImage")));
            this.btn_ResetRecord.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btn_ResetRecord.Location = new System.Drawing.Point(2, 2);
            this.btn_ResetRecord.Name = "btn_ResetRecord";
            this.btn_ResetRecord.Size = new System.Drawing.Size(303, 38);
            this.btn_ResetRecord.TabIndex = 0;
            this.btn_ResetRecord.Text = "Reset Record";
            // 
            // gc_AttendanceRecord
            // 
            this.gc_AttendanceRecord.Location = new System.Drawing.Point(16, 210);
            this.gc_AttendanceRecord.MainView = this.gv_AttendanceRecord;
            this.gc_AttendanceRecord.Name = "gc_AttendanceRecord";
            this.gc_AttendanceRecord.Size = new System.Drawing.Size(1087, 375);
            this.gc_AttendanceRecord.TabIndex = 8;
            this.gc_AttendanceRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AttendanceRecord});
            // 
            // gv_AttendanceRecord
            // 
            this.gv_AttendanceRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_AttendanceName,
            this.grdclm_Data,
            this.grdclm_LogType,
            this.grdclm_StartTime,
            this.grdclm_EndTime,
            this.grdclm_Remarks});
            this.gv_AttendanceRecord.GridControl = this.gc_AttendanceRecord;
            this.gv_AttendanceRecord.Name = "gv_AttendanceRecord";
            this.gv_AttendanceRecord.OptionsView.ShowGroupPanel = false;
            // 
            // grdclm_AttendanceName
            // 
            this.grdclm_AttendanceName.Caption = "Name";
            this.grdclm_AttendanceName.Name = "grdclm_AttendanceName";
            this.grdclm_AttendanceName.Visible = true;
            this.grdclm_AttendanceName.VisibleIndex = 0;
            // 
            // grdclm_Data
            // 
            this.grdclm_Data.Caption = "Date";
            this.grdclm_Data.Name = "grdclm_Data";
            this.grdclm_Data.Visible = true;
            this.grdclm_Data.VisibleIndex = 1;
            // 
            // grdclm_LogType
            // 
            this.grdclm_LogType.Caption = "Log Type";
            this.grdclm_LogType.Name = "grdclm_LogType";
            this.grdclm_LogType.Visible = true;
            this.grdclm_LogType.VisibleIndex = 2;
            // 
            // grdclm_StartTime
            // 
            this.grdclm_StartTime.Caption = "Start Time";
            this.grdclm_StartTime.Name = "grdclm_StartTime";
            this.grdclm_StartTime.Visible = true;
            this.grdclm_StartTime.VisibleIndex = 3;
            // 
            // grdclm_EndTime
            // 
            this.grdclm_EndTime.Caption = "End Time";
            this.grdclm_EndTime.Name = "grdclm_EndTime";
            this.grdclm_EndTime.Visible = true;
            this.grdclm_EndTime.VisibleIndex = 4;
            // 
            // grdclm_Remarks
            // 
            this.grdclm_Remarks.Caption = "Remarks";
            this.grdclm_Remarks.Name = "grdclm_Remarks";
            this.grdclm_Remarks.Visible = true;
            this.grdclm_Remarks.VisibleIndex = 5;
            // 
            // panel_TotalAttendance
            // 
            this.panel_TotalAttendance.Controls.Add(this.label_TotalAttendance);
            this.panel_TotalAttendance.Controls.Add(this.textEdit1);
            this.panel_TotalAttendance.Location = new System.Drawing.Point(730, 66);
            this.panel_TotalAttendance.Name = "panel_TotalAttendance";
            this.panel_TotalAttendance.Size = new System.Drawing.Size(373, 138);
            this.panel_TotalAttendance.TabIndex = 7;
            // 
            // label_TotalAttendance
            // 
            this.label_TotalAttendance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.label_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label_TotalAttendance.Appearance.Options.UseBackColor = true;
            this.label_TotalAttendance.Appearance.Options.UseFont = true;
            this.label_TotalAttendance.Location = new System.Drawing.Point(116, 95);
            this.label_TotalAttendance.Name = "label_TotalAttendance";
            this.label_TotalAttendance.Size = new System.Drawing.Size(140, 28);
            this.label_TotalAttendance.TabIndex = 3;
            this.label_TotalAttendance.Text = "Total Attendance";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.EditValue = "6";
            this.textEdit1.Location = new System.Drawing.Point(2, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Poppins", 35.84F);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(369, 134);
            this.textEdit1.TabIndex = 2;
            // 
            // panel_TotalAbsent
            // 
            this.panel_TotalAbsent.Appearance.BackColor = System.Drawing.Color.White;
            this.panel_TotalAbsent.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel_TotalAbsent.Appearance.Options.UseBackColor = true;
            this.panel_TotalAbsent.Appearance.Options.UseBorderColor = true;
            this.panel_TotalAbsent.Controls.Add(this.label_TotalAbsent);
            this.panel_TotalAbsent.Controls.Add(this.txt_TotalAbsent);
            this.panel_TotalAbsent.Location = new System.Drawing.Point(358, 66);
            this.panel_TotalAbsent.Name = "panel_TotalAbsent";
            this.panel_TotalAbsent.Size = new System.Drawing.Size(366, 138);
            this.panel_TotalAbsent.TabIndex = 6;
            // 
            // label_TotalAbsent
            // 
            this.label_TotalAbsent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.label_TotalAbsent.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label_TotalAbsent.Appearance.Options.UseBackColor = true;
            this.label_TotalAbsent.Appearance.Options.UseFont = true;
            this.label_TotalAbsent.Location = new System.Drawing.Point(154, 95);
            this.label_TotalAbsent.Name = "label_TotalAbsent";
            this.label_TotalAbsent.Size = new System.Drawing.Size(58, 28);
            this.label_TotalAbsent.TabIndex = 2;
            this.label_TotalAbsent.Text = "Absent";
            // 
            // txt_TotalAbsent
            // 
            this.txt_TotalAbsent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TotalAbsent.EditValue = "3";
            this.txt_TotalAbsent.Location = new System.Drawing.Point(2, 2);
            this.txt_TotalAbsent.Name = "txt_TotalAbsent";
            this.txt_TotalAbsent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.txt_TotalAbsent.Properties.Appearance.Font = new System.Drawing.Font("Poppins", 35.84F);
            this.txt_TotalAbsent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.txt_TotalAbsent.Properties.Appearance.Options.UseBackColor = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseFont = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TotalAbsent.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TotalAbsent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_TotalAbsent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(36)))), ((int)(((byte)(0)))));
            this.txt_TotalAbsent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_TotalAbsent.Properties.AutoHeight = false;
            this.txt_TotalAbsent.Properties.ReadOnly = true;
            this.txt_TotalAbsent.Size = new System.Drawing.Size(362, 134);
            this.txt_TotalAbsent.TabIndex = 1;
            // 
            // panel_TotalPresent
            // 
            this.panel_TotalPresent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel_TotalPresent.Appearance.Options.UseBackColor = true;
            this.panel_TotalPresent.Controls.Add(this.label_TotalPresent);
            this.panel_TotalPresent.Controls.Add(this.txt_TotalPresent);
            this.panel_TotalPresent.Location = new System.Drawing.Point(16, 66);
            this.panel_TotalPresent.Name = "panel_TotalPresent";
            this.panel_TotalPresent.Size = new System.Drawing.Size(336, 138);
            this.panel_TotalPresent.TabIndex = 5;
            // 
            // label_TotalPresent
            // 
            this.label_TotalPresent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.label_TotalPresent.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label_TotalPresent.Appearance.Options.UseBackColor = true;
            this.label_TotalPresent.Appearance.Options.UseFont = true;
            this.label_TotalPresent.Location = new System.Drawing.Point(137, 95);
            this.label_TotalPresent.Name = "label_TotalPresent";
            this.label_TotalPresent.Size = new System.Drawing.Size(63, 28);
            this.label_TotalPresent.TabIndex = 1;
            this.label_TotalPresent.Text = "Present";
            // 
            // txt_TotalPresent
            // 
            this.txt_TotalPresent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TotalPresent.EditValue = "3";
            this.txt_TotalPresent.Location = new System.Drawing.Point(2, 2);
            this.txt_TotalPresent.Name = "txt_TotalPresent";
            this.txt_TotalPresent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.txt_TotalPresent.Properties.Appearance.Font = new System.Drawing.Font("Poppins", 35.84F);
            this.txt_TotalPresent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(177)))), ((int)(((byte)(26)))));
            this.txt_TotalPresent.Properties.Appearance.Options.UseBackColor = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseFont = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TotalPresent.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_TotalPresent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txt_TotalPresent.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(177)))), ((int)(((byte)(26)))));
            this.txt_TotalPresent.Properties.AppearanceReadOnly.Options.UseForeColor = true;
            this.txt_TotalPresent.Properties.AutoHeight = false;
            this.txt_TotalPresent.Properties.ReadOnly = true;
            this.txt_TotalPresent.Size = new System.Drawing.Size(332, 134);
            this.txt_TotalPresent.TabIndex = 0;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.btn_CloseForm);
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1087, 44);
            this.panel_PageHeading.TabIndex = 4;
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.EditValue = ((object)(resources.GetObject("btn_CloseForm.EditValue")));
            this.btn_CloseForm.Location = new System.Drawing.Point(1044, 8);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.btn_CloseForm.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseForm.Properties.Appearance.Options.UseBackColor = true;
            this.btn_CloseForm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_CloseForm.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.btn_CloseForm.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.btn_CloseForm.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.btn_CloseForm.Size = new System.Drawing.Size(29, 28);
            this.btn_CloseForm.TabIndex = 21;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(20, 8);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(231, 28);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Student Attendance Record";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_TotalAbsent,
            this.lci_TotalPresent,
            this.lci_TotalAttendance,
            this.lci_gridControl,
            this.emptySpaceItem,
            this.lci_ResetRecord});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1119, 649);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1093, 50);
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_TotalAbsent
            // 
            this.lci_TotalAbsent.Control = this.panel_TotalAbsent;
            this.lci_TotalAbsent.Location = new System.Drawing.Point(342, 50);
            this.lci_TotalAbsent.Name = "lci_TotalAbsent";
            this.lci_TotalAbsent.Size = new System.Drawing.Size(372, 144);
            this.lci_TotalAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalAbsent.TextVisible = false;
            // 
            // lci_TotalPresent
            // 
            this.lci_TotalPresent.Control = this.panel_TotalPresent;
            this.lci_TotalPresent.Location = new System.Drawing.Point(0, 50);
            this.lci_TotalPresent.Name = "lci_TotalPresent";
            this.lci_TotalPresent.Size = new System.Drawing.Size(342, 144);
            this.lci_TotalPresent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalPresent.TextVisible = false;
            // 
            // lci_TotalAttendance
            // 
            this.lci_TotalAttendance.Control = this.panel_TotalAttendance;
            this.lci_TotalAttendance.Location = new System.Drawing.Point(714, 50);
            this.lci_TotalAttendance.Name = "lci_TotalAttendance";
            this.lci_TotalAttendance.Size = new System.Drawing.Size(379, 144);
            this.lci_TotalAttendance.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalAttendance.TextVisible = false;
            // 
            // lci_gridControl
            // 
            this.lci_gridControl.Control = this.gc_AttendanceRecord;
            this.lci_gridControl.Location = new System.Drawing.Point(0, 194);
            this.lci_gridControl.Name = "lci_gridControl";
            this.lci_gridControl.Size = new System.Drawing.Size(1093, 381);
            this.lci_gridControl.TextSize = new System.Drawing.Size(0, 0);
            this.lci_gridControl.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 575);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(780, 48);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lci_ResetRecord
            // 
            this.lci_ResetRecord.Control = this.panel_ResetRecord;
            this.lci_ResetRecord.Location = new System.Drawing.Point(780, 575);
            this.lci_ResetRecord.Name = "lci_ResetRecord";
            this.lci_ResetRecord.Size = new System.Drawing.Size(313, 48);
            this.lci_ResetRecord.TextSize = new System.Drawing.Size(0, 0);
            this.lci_ResetRecord.TextVisible = false;
            // 
            // StudentAttendanceRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 649);
            this.Controls.Add(this.lc_StudentAttendanceRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAttendanceRecord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendanceRecord_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).EndInit();
            this.lc_StudentAttendanceRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_ResetRecord)).EndInit();
            this.panel_ResetRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).EndInit();
            this.panel_TotalAttendance.ResumeLayout(false);
            this.panel_TotalAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).EndInit();
            this.panel_TotalAbsent.ResumeLayout(false);
            this.panel_TotalAbsent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).EndInit();
            this.panel_TotalPresent.ResumeLayout(false);
            this.panel_TotalPresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CloseForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ResetRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_StudentAttendanceRecord;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_AttendanceRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AttendanceRecord;
        private DevExpress.XtraEditors.PanelControl panel_TotalAttendance;
        private DevExpress.XtraEditors.PanelControl panel_TotalAbsent;
        private DevExpress.XtraEditors.PanelControl panel_TotalPresent;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalAbsent;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalPresent;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalAttendance;
        private DevExpress.XtraLayout.LayoutControlItem lci_gridControl;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceName;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Data;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_LogType;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Remarks;
        private DevExpress.XtraEditors.PanelControl panel_ResetRecord;
        private DevExpress.XtraEditors.SimpleButton btn_ResetRecord;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem lci_ResetRecord;
        private DevExpress.XtraEditors.TextEdit txt_TotalPresent;
        private DevExpress.XtraEditors.TextEdit txt_TotalAbsent;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl label_TotalPresent;
        private DevExpress.XtraEditors.LabelControl label_TotalAttendance;
        private DevExpress.XtraEditors.LabelControl label_TotalAbsent;
        private DevExpress.XtraEditors.PictureEdit btn_CloseForm;
    }
}