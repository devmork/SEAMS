namespace AttendanceManagementSystem.Forms.Attendance_Report
{
    partial class AttendanceRecords
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
            this.lc_AttendanceRecords = new DevExpress.XtraLayout.LayoutControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.btn_Report = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.panel_PageBody = new DevExpress.XtraEditors.PanelControl();
            this.gridControl_Reports = new DevExpress.XtraGrid.GridControl();
            this.gridView_Reports = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_SchoolStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_View = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_SearchBar = new DevExpress.XtraEditors.PanelControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.panel_CourseFilter = new DevExpress.XtraEditors.PanelControl();
            this.cbe_YearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_QRCode = new DevExpress.XtraEditors.PanelControl();
            this.pe_QRCode = new DevExpress.XtraEditors.PictureEdit();
            this.panel_StudentInfo = new DevExpress.XtraEditors.PanelControl();
            this.label_YearLevel = new DevExpress.XtraEditors.LabelControl();
            this.label_Course = new DevExpress.XtraEditors.LabelControl();
            this.label_Email = new DevExpress.XtraEditors.LabelControl();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.label_IDNumber = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SearchBar = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FilterSection = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_QRCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StudentInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_YearLevelFilter = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AttendanceRecords)).BeginInit();
            this.lc_AttendanceRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageBody)).BeginInit();
            this.panel_PageBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).BeginInit();
            this.panel_SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CourseFilter)).BeginInit();
            this.panel_CourseFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).BeginInit();
            this.panel_QRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInfo)).BeginInit();
            this.panel_StudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SearchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_QRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_YearLevelFilter)).BeginInit();
            this.panel_YearLevelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AttendanceRecords
            // 
            this.lc_AttendanceRecords.Controls.Add(this.panel_YearLevelFilter);
            this.lc_AttendanceRecords.Controls.Add(this.panel_PageHeading);
            this.lc_AttendanceRecords.Controls.Add(this.panel_PageBody);
            this.lc_AttendanceRecords.Controls.Add(this.panel_SearchBar);
            this.lc_AttendanceRecords.Controls.Add(this.panel_CourseFilter);
            this.lc_AttendanceRecords.Controls.Add(this.panel_QRCode);
            this.lc_AttendanceRecords.Controls.Add(this.panel_StudentInfo);
            this.lc_AttendanceRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AttendanceRecords.Location = new System.Drawing.Point(0, 0);
            this.lc_AttendanceRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_AttendanceRecords.Name = "lc_AttendanceRecords";
            this.lc_AttendanceRecords.Root = this.Root;
            this.lc_AttendanceRecords.Size = new System.Drawing.Size(1186, 1011);
            this.lc_AttendanceRecords.TabIndex = 0;
            this.lc_AttendanceRecords.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.btn_Report);
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1154, 135);
            this.panel_PageHeading.TabIndex = 12;
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Report.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_Report.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_Report.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Appearance.Options.UseBackColor = true;
            this.btn_Report.Appearance.Options.UseFont = true;
            this.btn_Report.Appearance.Options.UseForeColor = true;
            this.btn_Report.Appearance.Options.UseTextOptions = true;
            this.btn_Report.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_Report.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_Report.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_Report.Location = new System.Drawing.Point(877, 37);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Padding = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.btn_Report.Size = new System.Drawing.Size(267, 67);
            this.btn_Report.TabIndex = 13;
            this.btn_Report.Text = "Report";
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(35, 22);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(5);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(313, 53);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Attendance Records";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(35, 70);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(5);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(465, 36);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage student attendance records.";
            // 
            // panel_PageBody
            // 
            this.panel_PageBody.Controls.Add(this.gridControl_Reports);
            this.panel_PageBody.Location = new System.Drawing.Point(16, 211);
            this.panel_PageBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_PageBody.Name = "panel_PageBody";
            this.panel_PageBody.Size = new System.Drawing.Size(785, 784);
            this.panel_PageBody.TabIndex = 7;
            // 
            // gridControl_Reports
            // 
            this.gridControl_Reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Reports.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl_Reports.Location = new System.Drawing.Point(2, 2);
            this.gridControl_Reports.MainView = this.gridView_Reports;
            this.gridControl_Reports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl_Reports.Name = "gridControl_Reports";
            this.gridControl_Reports.Size = new System.Drawing.Size(781, 780);
            this.gridControl_Reports.TabIndex = 0;
            this.gridControl_Reports.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Reports});
            // 
            // gridView_Reports
            // 
            this.gridView_Reports.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_SchoolStudentId,
            this.gridColumn_Name,
            this.gridColumn_View});
            this.gridView_Reports.DetailHeight = 461;
            this.gridView_Reports.GridControl = this.gridControl_Reports;
            this.gridView_Reports.Name = "gridView_Reports";
            this.gridView_Reports.OptionsEditForm.PopupEditFormWidth = 914;
            this.gridView_Reports.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn_SchoolStudentId
            // 
            this.gridColumn_SchoolStudentId.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_SchoolStudentId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_SchoolStudentId.Caption = "ID #";
            this.gridColumn_SchoolStudentId.MinWidth = 23;
            this.gridColumn_SchoolStudentId.Name = "gridColumn_SchoolStudentId";
            this.gridColumn_SchoolStudentId.Visible = true;
            this.gridColumn_SchoolStudentId.VisibleIndex = 0;
            this.gridColumn_SchoolStudentId.Width = 86;
            // 
            // gridColumn_Name
            // 
            this.gridColumn_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_Name.Caption = "Name";
            this.gridColumn_Name.MinWidth = 23;
            this.gridColumn_Name.Name = "gridColumn_Name";
            this.gridColumn_Name.Visible = true;
            this.gridColumn_Name.VisibleIndex = 1;
            this.gridColumn_Name.Width = 86;
            // 
            // gridColumn_View
            // 
            this.gridColumn_View.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_View.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_View.Caption = "View";
            this.gridColumn_View.MinWidth = 23;
            this.gridColumn_View.Name = "gridColumn_View";
            this.gridColumn_View.Visible = true;
            this.gridColumn_View.VisibleIndex = 2;
            this.gridColumn_View.Width = 86;
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.searchControl);
            this.panel_SearchBar.Location = new System.Drawing.Point(16, 157);
            this.panel_SearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(785, 48);
            this.panel_SearchBar.TabIndex = 8;
            // 
            // searchControl
            // 
            this.searchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl.Location = new System.Drawing.Point(2, 2);
            this.searchControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Size = new System.Drawing.Size(781, 44);
            this.searchControl.TabIndex = 0;
            // 
            // panel_CourseFilter
            // 
            this.panel_CourseFilter.Controls.Add(this.cbe_Course);
            this.panel_CourseFilter.Location = new System.Drawing.Point(807, 157);
            this.panel_CourseFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_CourseFilter.Name = "panel_CourseFilter";
            this.panel_CourseFilter.Size = new System.Drawing.Size(178, 48);
            this.panel_CourseFilter.TabIndex = 9;
            // 
            // cbe_YearLevel
            // 
            this.cbe_YearLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_YearLevel.EditValue = "Year Level";
            this.cbe_YearLevel.Location = new System.Drawing.Point(2, 2);
            this.cbe_YearLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbe_YearLevel.Name = "cbe_YearLevel";
            this.cbe_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_YearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_YearLevel.Size = new System.Drawing.Size(175, 44);
            this.cbe_YearLevel.TabIndex = 1;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbe_Course.EditValue = "Course";
            this.cbe_Course.Location = new System.Drawing.Point(2, 2);
            this.cbe_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Properties.Items.AddRange(new object[] {
            "BSN",
            "BSMT",
            "BS-RADTECH",
            "BS-PHARMA",
            "BSPT",
            "BSIT",
            "BSHM",
            "BSBA",
            "BSED"});
            this.cbe_Course.Size = new System.Drawing.Size(174, 44);
            this.cbe_Course.TabIndex = 0;
            // 
            // panel_QRCode
            // 
            this.panel_QRCode.Controls.Add(this.pe_QRCode);
            this.panel_QRCode.Location = new System.Drawing.Point(807, 211);
            this.panel_QRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_QRCode.Name = "panel_QRCode";
            this.panel_QRCode.Size = new System.Drawing.Size(363, 441);
            this.panel_QRCode.TabIndex = 10;
            // 
            // pe_QRCode
            // 
            this.pe_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCode.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pe_QRCode.Name = "pe_QRCode";
            this.pe_QRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCode.Size = new System.Drawing.Size(359, 437);
            this.pe_QRCode.TabIndex = 1;
            // 
            // panel_StudentInfo
            // 
            this.panel_StudentInfo.Controls.Add(this.label_YearLevel);
            this.panel_StudentInfo.Controls.Add(this.label_Course);
            this.panel_StudentInfo.Controls.Add(this.label_Email);
            this.panel_StudentInfo.Controls.Add(this.label_Name);
            this.panel_StudentInfo.Controls.Add(this.label_IDNumber);
            this.panel_StudentInfo.Location = new System.Drawing.Point(807, 658);
            this.panel_StudentInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_StudentInfo.Name = "panel_StudentInfo";
            this.panel_StudentInfo.Size = new System.Drawing.Size(363, 337);
            this.panel_StudentInfo.TabIndex = 11;
            // 
            // label_YearLevel
            // 
            this.label_YearLevel.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_YearLevel.Appearance.Options.UseFont = true;
            this.label_YearLevel.Location = new System.Drawing.Point(29, 267);
            this.label_YearLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_YearLevel.Name = "label_YearLevel";
            this.label_YearLevel.Size = new System.Drawing.Size(103, 36);
            this.label_YearLevel.TabIndex = 4;
            this.label_YearLevel.Text = "Year Level:";
            // 
            // label_Course
            // 
            this.label_Course.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_Course.Appearance.Options.UseFont = true;
            this.label_Course.Location = new System.Drawing.Point(29, 216);
            this.label_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(75, 36);
            this.label_Course.TabIndex = 3;
            this.label_Course.Text = "Course:";
            // 
            // label_Email
            // 
            this.label_Email.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_Email.Appearance.Options.UseFont = true;
            this.label_Email.Location = new System.Drawing.Point(29, 164);
            this.label_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(58, 36);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "Email:";
            // 
            // label_Name
            // 
            this.label_Name.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(29, 113);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(64, 36);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            // 
            // label_IDNumber
            // 
            this.label_IDNumber.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_IDNumber.Appearance.Options.UseFont = true;
            this.label_IDNumber.Location = new System.Drawing.Point(29, 62);
            this.label_IDNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_IDNumber.Name = "label_IDNumber";
            this.label_IDNumber.Size = new System.Drawing.Size(109, 36);
            this.label_IDNumber.TabIndex = 0;
            this.label_IDNumber.Text = "ID Number:";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageBody,
            this.lci_SearchBar,
            this.lci_FilterSection,
            this.lci_QRCode,
            this.lci_StudentInfo,
            this.lci_PageHeading,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1186, 1011);
            this.Root.TextVisible = false;
            // 
            // lci_PageBody
            // 
            this.lci_PageBody.Control = this.panel_PageBody;
            this.lci_PageBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageBody.CustomizationFormText = "layoutControlItem1";
            this.lci_PageBody.Location = new System.Drawing.Point(0, 195);
            this.lci_PageBody.Name = "lci_PageBody";
            this.lci_PageBody.Size = new System.Drawing.Size(791, 790);
            this.lci_PageBody.Text = "layoutControlItem1";
            this.lci_PageBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageBody.TextVisible = false;
            // 
            // lci_SearchBar
            // 
            this.lci_SearchBar.Control = this.panel_SearchBar;
            this.lci_SearchBar.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_SearchBar.CustomizationFormText = "lci_SearchBar";
            this.lci_SearchBar.Location = new System.Drawing.Point(0, 141);
            this.lci_SearchBar.Name = "lci_SearchBar";
            this.lci_SearchBar.Size = new System.Drawing.Size(791, 54);
            this.lci_SearchBar.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SearchBar.TextVisible = false;
            // 
            // lci_FilterSection
            // 
            this.lci_FilterSection.Control = this.panel_CourseFilter;
            this.lci_FilterSection.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_FilterSection.CustomizationFormText = "lci_FilterSection";
            this.lci_FilterSection.Location = new System.Drawing.Point(791, 141);
            this.lci_FilterSection.Name = "lci_FilterSection";
            this.lci_FilterSection.Size = new System.Drawing.Size(184, 54);
            this.lci_FilterSection.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FilterSection.TextVisible = false;
            // 
            // lci_QRCode
            // 
            this.lci_QRCode.Control = this.panel_QRCode;
            this.lci_QRCode.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_QRCode.CustomizationFormText = "lci_QRCode";
            this.lci_QRCode.Location = new System.Drawing.Point(791, 195);
            this.lci_QRCode.Name = "lci_QRCode";
            this.lci_QRCode.Size = new System.Drawing.Size(369, 447);
            this.lci_QRCode.TextSize = new System.Drawing.Size(0, 0);
            this.lci_QRCode.TextVisible = false;
            // 
            // lci_StudentInfo
            // 
            this.lci_StudentInfo.Control = this.panel_StudentInfo;
            this.lci_StudentInfo.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StudentInfo.CustomizationFormText = "lci_StudentInfo";
            this.lci_StudentInfo.Location = new System.Drawing.Point(791, 642);
            this.lci_StudentInfo.Name = "lci_StudentInfo";
            this.lci_StudentInfo.Size = new System.Drawing.Size(369, 343);
            this.lci_StudentInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentInfo.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1160, 141);
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // panel_YearLevelFilter
            // 
            this.panel_YearLevelFilter.Controls.Add(this.cbe_YearLevel);
            this.panel_YearLevelFilter.Location = new System.Drawing.Point(991, 157);
            this.panel_YearLevelFilter.Name = "panel_YearLevelFilter";
            this.panel_YearLevelFilter.Size = new System.Drawing.Size(179, 48);
            this.panel_YearLevelFilter.TabIndex = 13;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel_YearLevelFilter;
            this.layoutControlItem1.Location = new System.Drawing.Point(975, 141);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(185, 54);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // AttendanceRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_AttendanceRecords);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AttendanceRecords";
            this.Size = new System.Drawing.Size(1186, 1011);
            ((System.ComponentModel.ISupportInitialize)(this.lc_AttendanceRecords)).EndInit();
            this.lc_AttendanceRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageBody)).EndInit();
            this.panel_PageBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).EndInit();
            this.panel_SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_CourseFilter)).EndInit();
            this.panel_CourseFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).EndInit();
            this.panel_QRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInfo)).EndInit();
            this.panel_StudentInfo.ResumeLayout(false);
            this.panel_StudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SearchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_QRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_YearLevelFilter)).EndInit();
            this.panel_YearLevelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AttendanceRecords;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageBody;
        private DevExpress.XtraGrid.GridControl gridControl_Reports;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Reports;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_SchoolStudentId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_View;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageBody;
        private DevExpress.XtraEditors.PanelControl panel_SearchBar;
        private DevExpress.XtraEditors.SearchControl searchControl;
        private DevExpress.XtraLayout.LayoutControlItem lci_SearchBar;
        private DevExpress.XtraEditors.PanelControl panel_CourseFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_YearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraLayout.LayoutControlItem lci_FilterSection;
        private DevExpress.XtraEditors.PanelControl panel_QRCode;
        private DevExpress.XtraLayout.LayoutControlItem lci_QRCode;
        private DevExpress.XtraEditors.PictureEdit pe_QRCode;
        private DevExpress.XtraEditors.PanelControl panel_StudentInfo;
        private DevExpress.XtraEditors.LabelControl label_YearLevel;
        private DevExpress.XtraEditors.LabelControl label_Course;
        private DevExpress.XtraEditors.LabelControl label_Email;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private DevExpress.XtraEditors.LabelControl label_IDNumber;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentInfo;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.SimpleButton btn_Report;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_YearLevelFilter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
