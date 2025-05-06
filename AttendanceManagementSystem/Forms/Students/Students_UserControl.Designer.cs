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
            this.lc_Students = new DevExpress.XtraLayout.LayoutControl();
            this.panel_FilterSection = new DevExpress.XtraEditors.PanelControl();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel_SearchBar = new DevExpress.XtraEditors.PanelControl();
            this.search_Panel = new DevExpress.XtraEditors.SearchControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Students = new DevExpress.XtraGrid.GridControl();
            this.gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_View = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_GridControlStudents = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SearchPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_FilterPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbe_YearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).BeginInit();
            this.lc_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterSection)).BeginInit();
            this.panel_FilterSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).BeginInit();
            this.panel_SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_Panel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SearchPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Students
            // 
            this.lc_Students.Controls.Add(this.panel_FilterSection);
            this.lc_Students.Controls.Add(this.panel_SearchBar);
            this.lc_Students.Controls.Add(this.panel_PageHeading);
            this.lc_Students.Controls.Add(this.gc_Students);
            this.lc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Students.Location = new System.Drawing.Point(0, 0);
            this.lc_Students.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_Students.Name = "lc_Students";
            this.lc_Students.Root = this.Root;
            this.lc_Students.Size = new System.Drawing.Size(1186, 1011);
            this.lc_Students.TabIndex = 0;
            this.lc_Students.Text = "layoutControl1";
            // 
            // panel_FilterSection
            // 
            this.panel_FilterSection.Controls.Add(this.cbe_YearLevel);
            this.panel_FilterSection.Controls.Add(this.cbe_Course);
            this.panel_FilterSection.Location = new System.Drawing.Point(826, 150);
            this.panel_FilterSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_FilterSection.Name = "panel_FilterSection";
            this.panel_FilterSection.Size = new System.Drawing.Size(342, 66);
            this.panel_FilterSection.TabIndex = 10;
            // 
            // cbe_Course
            // 
            this.cbe_Course.EditValue = "Course";
            this.cbe_Course.Location = new System.Drawing.Point(22, 11);
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
            this.cbe_Course.Size = new System.Drawing.Size(179, 44);
            this.cbe_Course.TabIndex = 0;
            // 
            // panel_SearchBar
            // 
            this.panel_SearchBar.Controls.Add(this.search_Panel);
            this.panel_SearchBar.Location = new System.Drawing.Point(18, 150);
            this.panel_SearchBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SearchBar.Name = "panel_SearchBar";
            this.panel_SearchBar.Size = new System.Drawing.Size(802, 66);
            this.panel_SearchBar.TabIndex = 9;
            // 
            // search_Panel
            // 
            this.search_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_Panel.Location = new System.Drawing.Point(2, 2);
            this.search_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_Panel.Name = "search_Panel";
            this.search_Panel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.search_Panel.Size = new System.Drawing.Size(798, 44);
            this.search_Panel.TabIndex = 0;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddStudent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(18, 21);
            this.panel_PageHeading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1150, 121);
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
            this.label_PageTitle.Size = new System.Drawing.Size(138, 53);
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
            this.btn_AddStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddStudent.Location = new System.Drawing.Point(866, 33);
            this.btn_AddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Padding = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.btn_AddStudent.Size = new System.Drawing.Size(269, 54);
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
            this.label_PageDescription.Location = new System.Drawing.Point(35, 70);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(397, 36);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage students information.";
            // 
            // gc_Students
            // 
            this.gc_Students.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gc_Students.Location = new System.Drawing.Point(18, 224);
            this.gc_Students.MainView = this.gv_Students;
            this.gc_Students.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_Students.Name = "gc_Students";
            this.gc_Students.Size = new System.Drawing.Size(1150, 766);
            this.gc_Students.TabIndex = 8;
            this.gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Students});
            this.gc_Students.Load += new System.EventHandler(this.gc_Students_Load);
            // 
            // gv_Students
            // 
            this.gv_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_StudentId,
            this.grdclm_Name,
            this.grdclm_Course,
            this.grdclm_YearLevel,
            this.grdclm_Email,
            this.grdclm_Edit,
            this.grdclm_View,
            this.grdclm_Delete});
            this.gv_Students.DetailHeight = 461;
            this.gv_Students.GridControl = this.gc_Students;
            this.gv_Students.Name = "gv_Students";
            this.gv_Students.OptionsEditForm.PopupEditFormWidth = 914;
            this.gv_Students.OptionsView.ShowGroupPanel = false;
            // 
            // grdclm_StudentId
            // 
            this.grdclm_StudentId.Caption = "ID #";
            this.grdclm_StudentId.FieldName = "SchoolID";
            this.grdclm_StudentId.MinWidth = 25;
            this.grdclm_StudentId.Name = "grdclm_StudentId";
            this.grdclm_StudentId.Visible = true;
            this.grdclm_StudentId.VisibleIndex = 0;
            this.grdclm_StudentId.Width = 86;
            // 
            // grdclm_Name
            // 
            this.grdclm_Name.Caption = "Name";
            this.grdclm_Name.FieldName = "FirstName";
            this.grdclm_Name.MinWidth = 25;
            this.grdclm_Name.Name = "grdclm_Name";
            this.grdclm_Name.Visible = true;
            this.grdclm_Name.VisibleIndex = 1;
            this.grdclm_Name.Width = 86;
            // 
            // grdclm_Course
            // 
            this.grdclm_Course.Caption = "Course";
            this.grdclm_Course.FieldName = "Course";
            this.grdclm_Course.MinWidth = 25;
            this.grdclm_Course.Name = "grdclm_Course";
            this.grdclm_Course.Visible = true;
            this.grdclm_Course.VisibleIndex = 2;
            this.grdclm_Course.Width = 86;
            // 
            // grdclm_YearLevel
            // 
            this.grdclm_YearLevel.Caption = "Year Level";
            this.grdclm_YearLevel.FieldName = "YearLevel";
            this.grdclm_YearLevel.MinWidth = 25;
            this.grdclm_YearLevel.Name = "grdclm_YearLevel";
            this.grdclm_YearLevel.Visible = true;
            this.grdclm_YearLevel.VisibleIndex = 3;
            this.grdclm_YearLevel.Width = 86;
            // 
            // grdclm_Email
            // 
            this.grdclm_Email.Caption = "Email";
            this.grdclm_Email.FieldName = "Email";
            this.grdclm_Email.MinWidth = 25;
            this.grdclm_Email.Name = "grdclm_Email";
            this.grdclm_Email.Visible = true;
            this.grdclm_Email.VisibleIndex = 4;
            this.grdclm_Email.Width = 86;
            // 
            // grdclm_Edit
            // 
            this.grdclm_Edit.Caption = "Edit";
            this.grdclm_Edit.MinWidth = 25;
            this.grdclm_Edit.Name = "grdclm_Edit";
            this.grdclm_Edit.Visible = true;
            this.grdclm_Edit.VisibleIndex = 5;
            this.grdclm_Edit.Width = 86;
            // 
            // grdclm_View
            // 
            this.grdclm_View.Caption = "View";
            this.grdclm_View.MinWidth = 23;
            this.grdclm_View.Name = "grdclm_View";
            this.grdclm_View.Visible = true;
            this.grdclm_View.VisibleIndex = 6;
            this.grdclm_View.Width = 86;
            // 
            // grdclm_Delete
            // 
            this.grdclm_Delete.Caption = "Delete";
            this.grdclm_Delete.MinWidth = 23;
            this.grdclm_Delete.Name = "grdclm_Delete";
            this.grdclm_Delete.Visible = true;
            this.grdclm_Delete.VisibleIndex = 7;
            this.grdclm_Delete.Width = 86;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_GridControlStudents,
            this.lci_SearchPanel,
            this.lci_FilterPanel});
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
            this.lci_PageHeading.Size = new System.Drawing.Size(1156, 129);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_GridControlStudents
            // 
            this.lci_GridControlStudents.Control = this.gc_Students;
            this.lci_GridControlStudents.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_GridControlStudents.CustomizationFormText = "lci_GridControlStudents";
            this.lci_GridControlStudents.Location = new System.Drawing.Point(0, 203);
            this.lci_GridControlStudents.Name = "lci_GridControlStudents";
            this.lci_GridControlStudents.Size = new System.Drawing.Size(1156, 774);
            this.lci_GridControlStudents.TextSize = new System.Drawing.Size(0, 0);
            this.lci_GridControlStudents.TextVisible = false;
            // 
            // lci_SearchPanel
            // 
            this.lci_SearchPanel.Control = this.panel_SearchBar;
            this.lci_SearchPanel.Location = new System.Drawing.Point(0, 129);
            this.lci_SearchPanel.Name = "lci_SearchPanel";
            this.lci_SearchPanel.Size = new System.Drawing.Size(808, 74);
            this.lci_SearchPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SearchPanel.TextVisible = false;
            // 
            // lci_FilterPanel
            // 
            this.lci_FilterPanel.Control = this.panel_FilterSection;
            this.lci_FilterPanel.Location = new System.Drawing.Point(808, 129);
            this.lci_FilterPanel.Name = "lci_FilterPanel";
            this.lci_FilterPanel.Size = new System.Drawing.Size(348, 74);
            this.lci_FilterPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lci_FilterPanel.TextVisible = false;
            // 
            // cbe_YearLevel
            // 
            this.cbe_YearLevel.EditValue = "Year Level";
            this.cbe_YearLevel.Location = new System.Drawing.Point(207, 11);
            this.cbe_YearLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbe_YearLevel.Name = "cbe_YearLevel";
            this.cbe_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_YearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_YearLevel.Size = new System.Drawing.Size(130, 44);
            this.cbe_YearLevel.TabIndex = 2;
            // 
            // Students_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Students);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Students_UserControl";
            this.Size = new System.Drawing.Size(1186, 1011);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).EndInit();
            this.lc_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_FilterSection)).EndInit();
            this.panel_FilterSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SearchBar)).EndInit();
            this.panel_SearchBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_Panel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SearchPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FilterPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gc_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Students;
        private DevExpress.XtraLayout.LayoutControlItem lci_GridControlStudents;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Name;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Course;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_YearLevel;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Email;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_View;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Delete;
        private DevExpress.XtraEditors.PanelControl panel_FilterSection;
        private DevExpress.XtraEditors.PanelControl panel_SearchBar;
        private DevExpress.XtraEditors.SearchControl search_Panel;
        private DevExpress.XtraLayout.LayoutControlItem lci_SearchPanel;
        private DevExpress.XtraLayout.LayoutControlItem lci_FilterPanel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_YearLevel;
    }
}
