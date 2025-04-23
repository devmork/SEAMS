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
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Students = new DevExpress.XtraGrid.GridControl();
            this.gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SchoolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QRImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_GridControlStudents = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).BeginInit();
            this.lc_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Students
            // 
            this.lc_Students.Controls.Add(this.panel_PageHeading);
            this.lc_Students.Controls.Add(this.gc_Students);
            this.lc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Students.Location = new System.Drawing.Point(0, 0);
            this.lc_Students.Name = "lc_Students";
            this.lc_Students.Root = this.Root;
            this.lc_Students.Size = new System.Drawing.Size(1038, 768);
            this.lc_Students.TabIndex = 0;
            this.lc_Students.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddStudent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(14, 12);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1010, 101);
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
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(147, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "All Students";
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
            this.btn_AddStudent.Location = new System.Drawing.Point(762, 25);
            this.btn_AddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddStudent.Size = new System.Drawing.Size(235, 50);
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
            this.label_PageDescription.Location = new System.Drawing.Point(31, 53);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(319, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage students information.";
            // 
            // gc_Students
            // 
            this.gc_Students.Location = new System.Drawing.Point(14, 117);
            this.gc_Students.MainView = this.gv_Students;
            this.gc_Students.Name = "gc_Students";
            this.gc_Students.Size = new System.Drawing.Size(1010, 639);
            this.gc_Students.TabIndex = 8;
            this.gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Students});
            this.gc_Students.Load += new System.EventHandler(this.gc_Students_Load);
            // 
            // gv_Students
            // 
            this.gv_Students.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.SchoolID,
            this.Course,
            this.YearLevel,
            this.Email,
            this.QRImage});
            this.gv_Students.GridControl = this.gc_Students;
            this.gv_Students.Name = "gv_Students";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 22;
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.MinWidth = 22;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 22;
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            // 
            // SchoolID
            // 
            this.SchoolID.Caption = "School ID";
            this.SchoolID.FieldName = "SchoolID";
            this.SchoolID.MinWidth = 22;
            this.SchoolID.Name = "SchoolID";
            this.SchoolID.Visible = true;
            this.SchoolID.VisibleIndex = 3;
            // 
            // Course
            // 
            this.Course.Caption = "Course";
            this.Course.FieldName = "Course";
            this.Course.MinWidth = 22;
            this.Course.Name = "Course";
            this.Course.Visible = true;
            this.Course.VisibleIndex = 4;
            // 
            // YearLevel
            // 
            this.YearLevel.Caption = "Year Level";
            this.YearLevel.FieldName = "YearLevel";
            this.YearLevel.MinWidth = 22;
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.Visible = true;
            this.YearLevel.VisibleIndex = 5;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 22;
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 6;
            // 
            // QRImage
            // 
            this.QRImage.Caption = "QR Code";
            this.QRImage.FieldName = "QRImage";
            this.QRImage.MinWidth = 22;
            this.QRImage.Name = "QRImage";
            this.QRImage.Visible = true;
            this.QRImage.VisibleIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_GridControlStudents});
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
            this.lci_PageHeading.Size = new System.Drawing.Size(1016, 105);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_GridControlStudents
            // 
            this.lci_GridControlStudents.Control = this.gc_Students;
            this.lci_GridControlStudents.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_GridControlStudents.CustomizationFormText = "lci_GridControlStudents";
            this.lci_GridControlStudents.Location = new System.Drawing.Point(0, 105);
            this.lci_GridControlStudents.Name = "lci_GridControlStudents";
            this.lci_GridControlStudents.Size = new System.Drawing.Size(1016, 643);
            this.lci_GridControlStudents.TextSize = new System.Drawing.Size(0, 0);
            this.lci_GridControlStudents.TextVisible = false;
            // 
            // Students_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Students);
            this.Name = "Students_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).EndInit();
            this.lc_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn SchoolID;
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn YearLevel;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn QRImage;
    }
}
