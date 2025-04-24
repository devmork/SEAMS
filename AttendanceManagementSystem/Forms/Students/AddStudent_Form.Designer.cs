namespace AttendanceManagementSystem.Forms.Students
{
    partial class AddStudent_Form
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
            this.lc_AddStudent = new DevExpress.XtraLayout.LayoutControl();
            this.gc_StudentData = new DevExpress.XtraEditors.GroupControl();
            this.lc_TextFields = new DevExpress.XtraLayout.LayoutControl();
            this.txt_EmailAddress = new DevExpress.XtraEditors.TextEdit();
            this.se_YearLevel = new DevExpress.XtraEditors.SpinEdit();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_MiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.TextEdit();
            this.lc_StudentData = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_FirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_MiddleName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_LastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StudentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Course = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_YearLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_QRCode = new DevExpress.XtraEditors.PanelControl();
            this.pe_QRCode = new DevExpress.XtraEditors.PictureEdit();
            this.panel_Actions = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_StudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SaveStudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Actions = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent)).BeginInit();
            this.lc_AddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).BeginInit();
            this.gc_StudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lc_TextFields)).BeginInit();
            this.lc_TextFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MiddleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_LastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_YearLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).BeginInit();
            this.panel_QRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).BeginInit();
            this.panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Actions)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddStudent
            // 
            this.lc_AddStudent.Controls.Add(this.gc_StudentData);
            this.lc_AddStudent.Controls.Add(this.panel_QRCode);
            this.lc_AddStudent.Controls.Add(this.panel_Actions);
            this.lc_AddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddStudent.Location = new System.Drawing.Point(0, 0);
            this.lc_AddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_AddStudent.Name = "lc_AddStudent";
            this.lc_AddStudent.Root = this.Root;
            this.lc_AddStudent.Size = new System.Drawing.Size(889, 632);
            this.lc_AddStudent.TabIndex = 0;
            this.lc_AddStudent.Text = "layoutControl1";
            // 
            // gc_StudentData
            // 
            this.gc_StudentData.Controls.Add(this.lc_TextFields);
            this.gc_StudentData.Location = new System.Drawing.Point(18, 21);
            this.gc_StudentData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_StudentData.Name = "gc_StudentData";
            this.gc_StudentData.Size = new System.Drawing.Size(516, 590);
            this.gc_StudentData.TabIndex = 7;
            this.gc_StudentData.Text = "Student Data";
            // 
            // lc_TextFields
            // 
            this.lc_TextFields.Controls.Add(this.txt_EmailAddress);
            this.lc_TextFields.Controls.Add(this.se_YearLevel);
            this.lc_TextFields.Controls.Add(this.cbe_Course);
            this.lc_TextFields.Controls.Add(this.txt_MiddleName);
            this.lc_TextFields.Controls.Add(this.txt_FirstName);
            this.lc_TextFields.Controls.Add(this.txt_LastName);
            this.lc_TextFields.Controls.Add(this.txt_SchoolStudentId);
            this.lc_TextFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_TextFields.Location = new System.Drawing.Point(2, 36);
            this.lc_TextFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_TextFields.Name = "lc_TextFields";
            this.lc_TextFields.Root = this.lc_StudentData;
            this.lc_TextFields.Size = new System.Drawing.Size(512, 552);
            this.lc_TextFields.TabIndex = 0;
            this.lc_TextFields.Text = "layoutControl1";
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(18, 473);
            this.txt_EmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.Size = new System.Drawing.Size(476, 44);
            this.txt_EmailAddress.StyleController = this.lc_TextFields;
            this.txt_EmailAddress.TabIndex = 9;
            // 
            // se_YearLevel
            // 
            this.se_YearLevel.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.se_YearLevel.Location = new System.Drawing.Point(254, 389);
            this.se_YearLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.se_YearLevel.Name = "se_YearLevel";
            this.se_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_YearLevel.Properties.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_YearLevel.Properties.IsFloatValue = false;
            this.se_YearLevel.Properties.MaskSettings.Set("mask", "N00");
            this.se_YearLevel.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.se_YearLevel.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.se_YearLevel.Size = new System.Drawing.Size(240, 44);
            this.se_YearLevel.StyleController = this.lc_TextFields;
            this.se_YearLevel.TabIndex = 8;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Location = new System.Drawing.Point(18, 389);
            this.cbe_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Properties.Items.AddRange(new object[] {
            "BSN",
            "BSMT",
            "BSIT",
            "BSBA",
            "BSHM",
            "BSED",
            "BSPT",
            "BS-PHARMA",
            "BSRT"});
            this.cbe_Course.Size = new System.Drawing.Size(230, 44);
            this.cbe_Course.StyleController = this.lc_TextFields;
            this.cbe_Course.TabIndex = 7;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(18, 137);
            this.txt_MiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(476, 44);
            this.txt_MiddleName.StyleController = this.lc_TextFields;
            this.txt_MiddleName.TabIndex = 5;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(18, 53);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(476, 44);
            this.txt_FirstName.StyleController = this.lc_TextFields;
            this.txt_FirstName.TabIndex = 4;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(18, 221);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(476, 44);
            this.txt_LastName.StyleController = this.lc_TextFields;
            this.txt_LastName.TabIndex = 5;
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(18, 305);
            this.txt_SchoolStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(476, 44);
            this.txt_SchoolStudentId.StyleController = this.lc_TextFields;
            this.txt_SchoolStudentId.TabIndex = 5;
            // 
            // lc_StudentData
            // 
            this.lc_StudentData.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lc_StudentData.GroupBordersVisible = false;
            this.lc_StudentData.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_FirstName,
            this.lci_MiddleName,
            this.lci_LastName,
            this.lci_StudentId,
            this.lci_Course,
            this.lci_YearLevel,
            this.lci_Email});
            this.lc_StudentData.Name = "Root";
            this.lc_StudentData.Size = new System.Drawing.Size(512, 552);
            this.lc_StudentData.TextVisible = false;
            // 
            // lci_FirstName
            // 
            this.lci_FirstName.Control = this.txt_FirstName;
            this.lci_FirstName.Location = new System.Drawing.Point(0, 0);
            this.lci_FirstName.Name = "lci_FirstName";
            this.lci_FirstName.Size = new System.Drawing.Size(482, 84);
            this.lci_FirstName.Text = "First Name";
            this.lci_FirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_FirstName.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_MiddleName
            // 
            this.lci_MiddleName.Control = this.txt_MiddleName;
            this.lci_MiddleName.Location = new System.Drawing.Point(0, 84);
            this.lci_MiddleName.Name = "lci_MiddleName";
            this.lci_MiddleName.Size = new System.Drawing.Size(482, 84);
            this.lci_MiddleName.Text = "Middle Name";
            this.lci_MiddleName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_MiddleName.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_LastName
            // 
            this.lci_LastName.Control = this.txt_LastName;
            this.lci_LastName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_LastName.CustomizationFormText = "layoutControlItem2";
            this.lci_LastName.Location = new System.Drawing.Point(0, 168);
            this.lci_LastName.Name = "lci_LastName";
            this.lci_LastName.Size = new System.Drawing.Size(482, 84);
            this.lci_LastName.Text = "Last Name";
            this.lci_LastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_LastName.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_StudentId
            // 
            this.lci_StudentId.Control = this.txt_SchoolStudentId;
            this.lci_StudentId.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StudentId.CustomizationFormText = "layoutControlItem2";
            this.lci_StudentId.Location = new System.Drawing.Point(0, 252);
            this.lci_StudentId.Name = "lci_StudentId";
            this.lci_StudentId.Size = new System.Drawing.Size(482, 84);
            this.lci_StudentId.Text = "ID #";
            this.lci_StudentId.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_StudentId.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_Course
            // 
            this.lci_Course.Control = this.cbe_Course;
            this.lci_Course.Location = new System.Drawing.Point(0, 336);
            this.lci_Course.Name = "lci_Course";
            this.lci_Course.Size = new System.Drawing.Size(236, 84);
            this.lci_Course.Text = "Course";
            this.lci_Course.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Course.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_YearLevel
            // 
            this.lci_YearLevel.Control = this.se_YearLevel;
            this.lci_YearLevel.Location = new System.Drawing.Point(236, 336);
            this.lci_YearLevel.Name = "lci_YearLevel";
            this.lci_YearLevel.Size = new System.Drawing.Size(246, 84);
            this.lci_YearLevel.Text = "Year Level";
            this.lci_YearLevel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_YearLevel.TextSize = new System.Drawing.Size(90, 25);
            // 
            // lci_Email
            // 
            this.lci_Email.Control = this.txt_EmailAddress;
            this.lci_Email.Location = new System.Drawing.Point(0, 420);
            this.lci_Email.Name = "lci_Email";
            this.lci_Email.Size = new System.Drawing.Size(482, 98);
            this.lci_Email.Text = "Email";
            this.lci_Email.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Email.TextSize = new System.Drawing.Size(90, 25);
            // 
            // panel_QRCode
            // 
            this.panel_QRCode.Controls.Add(this.pe_QRCode);
            this.panel_QRCode.Location = new System.Drawing.Point(540, 21);
            this.panel_QRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_QRCode.Name = "panel_QRCode";
            this.panel_QRCode.Size = new System.Drawing.Size(331, 287);
            this.panel_QRCode.TabIndex = 5;
            // 
            // pe_QRCode
            // 
            this.pe_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCode.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pe_QRCode.Name = "pe_QRCode";
            this.pe_QRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCode.Size = new System.Drawing.Size(327, 283);
            this.pe_QRCode.TabIndex = 1;
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.btn_Cancel);
            this.panel_Actions.Controls.Add(this.btn_Save);
            this.panel_Actions.Location = new System.Drawing.Point(540, 316);
            this.panel_Actions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(331, 295);
            this.panel_Actions.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(7, 305);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(306, 45);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCEL";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(7, 254);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(306, 45);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "SAVE";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_StudentData,
            this.lci_SaveStudentData,
            this.lci_Actions});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(889, 632);
            this.Root.TextVisible = false;
            // 
            // lci_StudentData
            // 
            this.lci_StudentData.Control = this.gc_StudentData;
            this.lci_StudentData.Location = new System.Drawing.Point(0, 0);
            this.lci_StudentData.Name = "lci_StudentData";
            this.lci_StudentData.Size = new System.Drawing.Size(522, 598);
            this.lci_StudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentData.TextVisible = false;
            // 
            // lci_SaveStudentData
            // 
            this.lci_SaveStudentData.Control = this.panel_QRCode;
            this.lci_SaveStudentData.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_SaveStudentData.CustomizationFormText = "lci_SaveStudentData";
            this.lci_SaveStudentData.Location = new System.Drawing.Point(522, 0);
            this.lci_SaveStudentData.Name = "lci_SaveStudentData";
            this.lci_SaveStudentData.Size = new System.Drawing.Size(337, 295);
            this.lci_SaveStudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SaveStudentData.TextVisible = false;
            // 
            // lci_Actions
            // 
            this.lci_Actions.Control = this.panel_Actions;
            this.lci_Actions.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_Actions.CustomizationFormText = "layoutControlItem8";
            this.lci_Actions.Location = new System.Drawing.Point(522, 295);
            this.lci_Actions.Name = "lci_Actions";
            this.lci_Actions.Size = new System.Drawing.Size(337, 303);
            this.lci_Actions.Text = "layoutControlItem8";
            this.lci_Actions.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Actions.TextVisible = false;
            // 
            // AddStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 632);
            this.Controls.Add(this.lc_AddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudent_Form";
            this.Text = "AddStudent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent)).EndInit();
            this.lc_AddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).EndInit();
            this.gc_StudentData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lc_TextFields)).EndInit();
            this.lc_TextFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_FirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_MiddleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_LastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_YearLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).EndInit();
            this.panel_QRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Actions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddStudent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_StudentData;
        private DevExpress.XtraLayout.LayoutControl lc_TextFields;
        private DevExpress.XtraEditors.TextEdit txt_EmailAddress;
        private DevExpress.XtraEditors.SpinEdit se_YearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.TextEdit txt_MiddleName;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_SchoolStudentId;
        private DevExpress.XtraLayout.LayoutControlGroup lc_StudentData;
        private DevExpress.XtraLayout.LayoutControlItem lci_FirstName;
        private DevExpress.XtraLayout.LayoutControlItem lci_MiddleName;
        private DevExpress.XtraLayout.LayoutControlItem lci_LastName;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentId;
        private DevExpress.XtraLayout.LayoutControlItem lci_Course;
        private DevExpress.XtraLayout.LayoutControlItem lci_YearLevel;
        private DevExpress.XtraLayout.LayoutControlItem lci_Email;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentData;
        private DevExpress.XtraEditors.PanelControl panel_QRCode;
        private DevExpress.XtraEditors.PictureEdit pe_QRCode;
        private DevExpress.XtraLayout.LayoutControlItem lci_SaveStudentData;
        private DevExpress.XtraEditors.PanelControl panel_Actions;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraLayout.LayoutControlItem lci_Actions;
    }
}