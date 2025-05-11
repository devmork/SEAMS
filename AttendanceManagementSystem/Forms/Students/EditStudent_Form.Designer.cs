namespace AttendanceManagementSystem.Forms.Students
{
    partial class EditStudent_Form
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
            this.lc_EditStudent = new DevExpress.XtraLayout.LayoutControl();
            this.panel_Actions = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SaveChanges = new DevExpress.XtraEditors.SimpleButton();
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_StudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SaveStudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Actions = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_Generate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditStudent)).BeginInit();
            this.lc_EditStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).BeginInit();
            this.panel_Actions.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Actions)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_EditStudent
            // 
            this.lc_EditStudent.Controls.Add(this.panel_Actions);
            this.lc_EditStudent.Controls.Add(this.gc_StudentData);
            this.lc_EditStudent.Controls.Add(this.panel_QRCode);
            this.lc_EditStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_EditStudent.Location = new System.Drawing.Point(0, 0);
            this.lc_EditStudent.Name = "lc_EditStudent";
            this.lc_EditStudent.Root = this.Root;
            this.lc_EditStudent.Size = new System.Drawing.Size(776, 480);
            this.lc_EditStudent.TabIndex = 0;
            this.lc_EditStudent.Text = "layoutControl1";
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.btn_Generate);
            this.panel_Actions.Controls.Add(this.btn_Cancel);
            this.panel_Actions.Controls.Add(this.btn_SaveChanges);
            this.panel_Actions.Location = new System.Drawing.Point(472, 243);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(288, 221);
            this.panel_Actions.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(6, 177);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(275, 34);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveChanges.Location = new System.Drawing.Point(6, 138);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(275, 34);
            this.btn_SaveChanges.TabIndex = 4;
            this.btn_SaveChanges.Text = "SAVE CHANGES";
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // gc_StudentData
            // 
            this.gc_StudentData.Controls.Add(this.lc_TextFields);
            this.gc_StudentData.Location = new System.Drawing.Point(16, 15);
            this.gc_StudentData.Name = "gc_StudentData";
            this.gc_StudentData.Size = new System.Drawing.Size(450, 450);
            this.gc_StudentData.TabIndex = 6;
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
            this.lc_TextFields.Location = new System.Drawing.Point(2, 29);
            this.lc_TextFields.Name = "lc_TextFields";
            this.lc_TextFields.Root = this.lc_StudentData;
            this.lc_TextFields.Size = new System.Drawing.Size(446, 419);
            this.lc_TextFields.TabIndex = 0;
            this.lc_TextFields.Text = "layoutControl1";
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(16, 366);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.Size = new System.Drawing.Size(414, 34);
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
            this.se_YearLevel.Location = new System.Drawing.Point(222, 301);
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
            this.se_YearLevel.Size = new System.Drawing.Size(208, 34);
            this.se_YearLevel.StyleController = this.lc_TextFields;
            this.se_YearLevel.TabIndex = 8;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Location = new System.Drawing.Point(16, 301);
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
            this.cbe_Course.Size = new System.Drawing.Size(200, 34);
            this.cbe_Course.StyleController = this.lc_TextFields;
            this.cbe_Course.TabIndex = 7;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(16, 106);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(414, 34);
            this.txt_MiddleName.StyleController = this.lc_TextFields;
            this.txt_MiddleName.TabIndex = 5;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(16, 41);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(414, 34);
            this.txt_FirstName.StyleController = this.lc_TextFields;
            this.txt_FirstName.TabIndex = 4;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(16, 171);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(414, 34);
            this.txt_LastName.StyleController = this.lc_TextFields;
            this.txt_LastName.TabIndex = 5;
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(16, 236);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(414, 34);
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
            this.lc_StudentData.Size = new System.Drawing.Size(446, 419);
            this.lc_StudentData.TextVisible = false;
            // 
            // lci_FirstName
            // 
            this.lci_FirstName.Control = this.txt_FirstName;
            this.lci_FirstName.Location = new System.Drawing.Point(0, 0);
            this.lci_FirstName.Name = "lci_FirstName";
            this.lci_FirstName.Size = new System.Drawing.Size(420, 65);
            this.lci_FirstName.Text = "First Name";
            this.lci_FirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_FirstName.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_MiddleName
            // 
            this.lci_MiddleName.Control = this.txt_MiddleName;
            this.lci_MiddleName.Location = new System.Drawing.Point(0, 65);
            this.lci_MiddleName.Name = "lci_MiddleName";
            this.lci_MiddleName.Size = new System.Drawing.Size(420, 65);
            this.lci_MiddleName.Text = "Middle Name";
            this.lci_MiddleName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_MiddleName.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_LastName
            // 
            this.lci_LastName.Control = this.txt_LastName;
            this.lci_LastName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_LastName.CustomizationFormText = "layoutControlItem2";
            this.lci_LastName.Location = new System.Drawing.Point(0, 130);
            this.lci_LastName.Name = "lci_LastName";
            this.lci_LastName.Size = new System.Drawing.Size(420, 65);
            this.lci_LastName.Text = "Last Name";
            this.lci_LastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_LastName.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_StudentId
            // 
            this.lci_StudentId.Control = this.txt_SchoolStudentId;
            this.lci_StudentId.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StudentId.CustomizationFormText = "layoutControlItem2";
            this.lci_StudentId.Location = new System.Drawing.Point(0, 195);
            this.lci_StudentId.Name = "lci_StudentId";
            this.lci_StudentId.Size = new System.Drawing.Size(420, 65);
            this.lci_StudentId.Text = "ID #";
            this.lci_StudentId.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_StudentId.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_Course
            // 
            this.lci_Course.Control = this.cbe_Course;
            this.lci_Course.Location = new System.Drawing.Point(0, 260);
            this.lci_Course.Name = "lci_Course";
            this.lci_Course.Size = new System.Drawing.Size(206, 65);
            this.lci_Course.Text = "Course";
            this.lci_Course.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Course.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_YearLevel
            // 
            this.lci_YearLevel.Control = this.se_YearLevel;
            this.lci_YearLevel.Location = new System.Drawing.Point(206, 260);
            this.lci_YearLevel.Name = "lci_YearLevel";
            this.lci_YearLevel.Size = new System.Drawing.Size(214, 65);
            this.lci_YearLevel.Text = "Year Level";
            this.lci_YearLevel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_YearLevel.TextSize = new System.Drawing.Size(72, 19);
            // 
            // lci_Email
            // 
            this.lci_Email.Control = this.txt_EmailAddress;
            this.lci_Email.Location = new System.Drawing.Point(0, 325);
            this.lci_Email.Name = "lci_Email";
            this.lci_Email.Size = new System.Drawing.Size(420, 68);
            this.lci_Email.Text = "Email";
            this.lci_Email.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Email.TextSize = new System.Drawing.Size(72, 19);
            // 
            // panel_QRCode
            // 
            this.panel_QRCode.Controls.Add(this.pe_QRCode);
            this.panel_QRCode.Location = new System.Drawing.Point(472, 15);
            this.panel_QRCode.Name = "panel_QRCode";
            this.panel_QRCode.Size = new System.Drawing.Size(288, 223);
            this.panel_QRCode.TabIndex = 5;
            // 
            // pe_QRCode
            // 
            this.pe_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCode.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCode.Name = "pe_QRCode";
            this.pe_QRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCode.Size = new System.Drawing.Size(284, 219);
            this.pe_QRCode.TabIndex = 1;
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
            this.Root.Size = new System.Drawing.Size(776, 480);
            this.Root.TextVisible = false;
            // 
            // lci_StudentData
            // 
            this.lci_StudentData.Control = this.gc_StudentData;
            this.lci_StudentData.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StudentData.CustomizationFormText = "lci_StudentData";
            this.lci_StudentData.Location = new System.Drawing.Point(0, 0);
            this.lci_StudentData.Name = "lci_StudentData";
            this.lci_StudentData.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 2, 2);
            this.lci_StudentData.Size = new System.Drawing.Size(456, 454);
            this.lci_StudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentData.TextVisible = false;
            // 
            // lci_SaveStudentData
            // 
            this.lci_SaveStudentData.Control = this.panel_QRCode;
            this.lci_SaveStudentData.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_SaveStudentData.CustomizationFormText = "lci_SaveStudentData";
            this.lci_SaveStudentData.Location = new System.Drawing.Point(456, 0);
            this.lci_SaveStudentData.Name = "lci_SaveStudentData";
            this.lci_SaveStudentData.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 2, 2);
            this.lci_SaveStudentData.Size = new System.Drawing.Size(294, 227);
            this.lci_SaveStudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SaveStudentData.TextVisible = false;
            // 
            // lci_Actions
            // 
            this.lci_Actions.Control = this.panel_Actions;
            this.lci_Actions.Location = new System.Drawing.Point(456, 227);
            this.lci_Actions.Name = "lci_Actions";
            this.lci_Actions.Size = new System.Drawing.Size(294, 227);
            this.lci_Actions.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Actions.TextVisible = false;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_Generate.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Generate.Appearance.Options.UseBackColor = true;
            this.btn_Generate.Appearance.Options.UseFont = true;
            this.btn_Generate.Location = new System.Drawing.Point(4, 5);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(281, 41);
            this.btn_Generate.TabIndex = 7;
            this.btn_Generate.Text = "Generate QR Code";
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // EditStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 480);
            this.Controls.Add(this.lc_EditStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStudent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditStudent)).EndInit();
            this.lc_EditStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Actions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_EditStudent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_StudentData;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentData;
        private DevExpress.XtraEditors.PanelControl panel_QRCode;
        private DevExpress.XtraLayout.LayoutControlItem lci_SaveStudentData;
        private DevExpress.XtraLayout.LayoutControl lc_TextFields;
        private DevExpress.XtraLayout.LayoutControlGroup lc_StudentData;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraLayout.LayoutControlItem lci_FirstName;
        private DevExpress.XtraEditors.TextEdit txt_MiddleName;
        private DevExpress.XtraLayout.LayoutControlItem lci_MiddleName;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_SchoolStudentId;
        private DevExpress.XtraLayout.LayoutControlItem lci_LastName;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentId;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraLayout.LayoutControlItem lci_Course;
        private DevExpress.XtraEditors.SpinEdit se_YearLevel;
        private DevExpress.XtraLayout.LayoutControlItem lci_YearLevel;
        private DevExpress.XtraEditors.TextEdit txt_EmailAddress;
        private DevExpress.XtraLayout.LayoutControlItem lci_Email;
        private DevExpress.XtraEditors.PictureEdit pe_QRCode;
        private DevExpress.XtraEditors.PanelControl panel_Actions;
        private DevExpress.XtraLayout.LayoutControlItem lci_Actions;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_SaveChanges;
        private DevExpress.XtraEditors.SimpleButton btn_Generate;
    }
}