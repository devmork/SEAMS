namespace AttendanceManagementSystem.Forms.Students
{
    partial class Students_UserControl
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students_UserControl));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lc_Students = new DevExpress.XtraLayout.LayoutControl();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.cbe_FilterYearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbe_FilterCourse = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gc_Students = new DevExpress.XtraGrid.GridControl();
            this.gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_IdNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).BeginInit();
            this.lc_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Students
            // 
            this.lc_Students.Controls.Add(this.panel);
            this.lc_Students.Controls.Add(this.panel_PageHeading);
            this.lc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Students.Location = new System.Drawing.Point(0, 0);
            this.lc_Students.Name = "lc_Students";
            this.lc_Students.Root = this.Root;
            this.lc_Students.Size = new System.Drawing.Size(1440, 1024);
            this.lc_Students.TabIndex = 0;
            this.lc_Students.Text = "layoutControl1";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbe_FilterYearLevel);
            this.panel.Controls.Add(this.cbe_FilterCourse);
            this.panel.Controls.Add(this.gc_Students);
            this.panel.Location = new System.Drawing.Point(16, 126);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1408, 882);
            this.panel.TabIndex = 11;
            // 
            // cbe_FilterYearLevel
            // 
            this.cbe_FilterYearLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbe_FilterYearLevel.EditValue = "Year Level";
            this.cbe_FilterYearLevel.Location = new System.Drawing.Point(1189, 20);
            this.cbe_FilterYearLevel.Name = "cbe_FilterYearLevel";
            this.cbe_FilterYearLevel.Properties.AutoHeight = false;
            this.cbe_FilterYearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_FilterYearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_FilterYearLevel.Size = new System.Drawing.Size(206, 34);
            this.cbe_FilterYearLevel.TabIndex = 3;
            this.cbe_FilterYearLevel.SelectedValueChanged += new System.EventHandler(this.cbe_FilterYearLevel_SelectedValueChanged);
            // 
            // cbe_FilterCourse
            // 
            this.cbe_FilterCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbe_FilterCourse.EditValue = "Course";
            this.cbe_FilterCourse.Location = new System.Drawing.Point(973, 21);
            this.cbe_FilterCourse.Name = "cbe_FilterCourse";
            this.cbe_FilterCourse.Properties.AutoHeight = false;
            this.cbe_FilterCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_FilterCourse.Properties.Items.AddRange(new object[] {
            "BSN",
            "BSMT",
            "BS-RADTECH",
            "BS-PHARMA",
            "BSPT",
            "BSIT",
            "BSHM",
            "BSBA",
            "BSED"});
            this.cbe_FilterCourse.Size = new System.Drawing.Size(204, 34);
            this.cbe_FilterCourse.TabIndex = 3;
            this.cbe_FilterCourse.SelectedValueChanged += new System.EventHandler(this.cbe_FilterCourse_SelectedValueChanged);
            // 
            // gc_Students
            // 
            this.gc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Students.Location = new System.Drawing.Point(2, 2);
            this.gc_Students.MainView = this.gv_Students;
            this.gc_Students.Name = "gc_Students";
            this.gc_Students.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit});
            this.gc_Students.Size = new System.Drawing.Size(1404, 878);
            this.gc_Students.TabIndex = 9;
            this.gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Students});
            // 
            // gv_Students
            // 
            this.gv_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_Id,
            this.grdclm_IdNumber,
            this.grdclm_Name,
            this.grdclm_Course,
            this.grdclm_YearLevel,
            this.grdclm_Email,
            this.grdclm_Edit});
            this.gv_Students.GridControl = this.gc_Students;
            this.gv_Students.Name = "gv_Students";
            this.gv_Students.OptionsFind.AlwaysVisible = true;
            this.gv_Students.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gv_Students.OptionsView.ShowGroupPanel = false;
            // 
            // grdclm_Id
            // 
            this.grdclm_Id.Caption = "Id";
            this.grdclm_Id.FieldName = "Id";
            this.grdclm_Id.Name = "grdclm_Id";
            // 
            // grdclm_IdNumber
            // 
            this.grdclm_IdNumber.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_IdNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_IdNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_IdNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_IdNumber.Caption = "ID #";
            this.grdclm_IdNumber.FieldName = "SchoolStudentId";
            this.grdclm_IdNumber.MinWidth = 22;
            this.grdclm_IdNumber.Name = "grdclm_IdNumber";
            this.grdclm_IdNumber.OptionsColumn.AllowEdit = false;
            this.grdclm_IdNumber.Visible = true;
            this.grdclm_IdNumber.VisibleIndex = 0;
            // 
            // grdclm_Name
            // 
            this.grdclm_Name.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Name.Caption = "Name";
            this.grdclm_Name.FieldName = "FullName";
            this.grdclm_Name.MinWidth = 22;
            this.grdclm_Name.Name = "grdclm_Name";
            this.grdclm_Name.OptionsColumn.AllowEdit = false;
            this.grdclm_Name.Visible = true;
            this.grdclm_Name.VisibleIndex = 1;
            // 
            // grdclm_Course
            // 
            this.grdclm_Course.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Course.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Course.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Course.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Course.Caption = "Course";
            this.grdclm_Course.FieldName = "Course";
            this.grdclm_Course.MinWidth = 22;
            this.grdclm_Course.Name = "grdclm_Course";
            this.grdclm_Course.OptionsColumn.AllowEdit = false;
            this.grdclm_Course.Visible = true;
            this.grdclm_Course.VisibleIndex = 2;
            // 
            // grdclm_YearLevel
            // 
            this.grdclm_YearLevel.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_YearLevel.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_YearLevel.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_YearLevel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_YearLevel.Caption = "Year Level";
            this.grdclm_YearLevel.FieldName = "YearLevel";
            this.grdclm_YearLevel.MinWidth = 22;
            this.grdclm_YearLevel.Name = "grdclm_YearLevel";
            this.grdclm_YearLevel.OptionsColumn.AllowEdit = false;
            this.grdclm_YearLevel.Visible = true;
            this.grdclm_YearLevel.VisibleIndex = 3;
            // 
            // grdclm_Email
            // 
            this.grdclm_Email.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Email.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Email.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Email.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Email.Caption = "Email";
            this.grdclm_Email.FieldName = "Email";
            this.grdclm_Email.MinWidth = 22;
            this.grdclm_Email.Name = "grdclm_Email";
            this.grdclm_Email.OptionsColumn.AllowEdit = false;
            this.grdclm_Email.Visible = true;
            this.grdclm_Email.VisibleIndex = 4;
            // 
            // grdclm_Edit
            // 
            this.grdclm_Edit.AppearanceCell.Options.UseTextOptions = true;
            this.grdclm_Edit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Edit.AppearanceHeader.Options.UseTextOptions = true;
            this.grdclm_Edit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdclm_Edit.Caption = "Edit";
            this.grdclm_Edit.ColumnEdit = this.repositoryItemButtonEdit;
            this.grdclm_Edit.MinWidth = 22;
            this.grdclm_Edit.Name = "grdclm_Edit";
            this.grdclm_Edit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.grdclm_Edit.Visible = true;
            this.grdclm_Edit.VisibleIndex = 5;
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit_ButtonClick);
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddStudent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 104);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 20);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(110, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Students";
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddStudent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddStudent.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddStudent.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddStudent.Appearance.Options.UseBackColor = true;
            this.btn_AddStudent.Appearance.Options.UseFont = true;
            this.btn_AddStudent.Appearance.Options.UseForeColor = true;
            this.btn_AddStudent.Appearance.Options.UseTextOptions = true;
            this.btn_AddStudent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddStudent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddStudent.ImageOptions.SvgImage")));
            this.btn_AddStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddStudent.Location = new System.Drawing.Point(1159, 25);
            this.btn_AddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddStudent.Size = new System.Drawing.Size(236, 56);
            this.btn_AddStudent.TabIndex = 2;
            this.btn_AddStudent.Text = "Add Student";
            this.btn_AddStudent.Click += new System.EventHandler(this.btn_AddStudent_Click);
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 56);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(319, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage students information.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1440, 1024);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1414, 110);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1414, 888);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Students_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Students);
            this.Name = "Students_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).EndInit();
            this.lc_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Students;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudent;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraGrid.GridControl gc_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Students;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Id;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_IdNumber;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Name;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Course;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_YearLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Email;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_FilterYearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_FilterCourse;
    }
}
