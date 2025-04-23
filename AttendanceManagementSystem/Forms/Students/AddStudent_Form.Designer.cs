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
            this.label_EmailAddress = new DevExpress.XtraEditors.LabelControl();
            this.label_YearLevel = new DevExpress.XtraEditors.LabelControl();
            this.label_Course = new DevExpress.XtraEditors.LabelControl();
            this.label_SchoolStudentId = new DevExpress.XtraEditors.LabelControl();
            this.label_LastName = new DevExpress.XtraEditors.LabelControl();
            this.label_MiddleName = new DevExpress.XtraEditors.LabelControl();
            this.label_FirstName = new DevExpress.XtraEditors.LabelControl();
            this.se_YearLevel = new DevExpress.XtraEditors.SpinEdit();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_EmailAddress = new DevExpress.XtraEditors.TextEdit();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_MiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.panel_SaveStudentData = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Generate = new DevExpress.XtraEditors.SimpleButton();
            this.pe_QRCode = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_SaveStudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_StudentData = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent)).BeginInit();
            this.lc_AddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).BeginInit();
            this.gc_StudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SaveStudentData)).BeginInit();
            this.panel_SaveStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddStudent
            // 
            this.lc_AddStudent.Controls.Add(this.gc_StudentData);
            this.lc_AddStudent.Controls.Add(this.panel_SaveStudentData);
            this.lc_AddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddStudent.Location = new System.Drawing.Point(0, 0);
            this.lc_AddStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lc_AddStudent.Name = "lc_AddStudent";
            this.lc_AddStudent.Root = this.Root;
            this.lc_AddStudent.Size = new System.Drawing.Size(758, 601);
            this.lc_AddStudent.TabIndex = 0;
            this.lc_AddStudent.Text = "layoutControl1";
            // 
            // gc_StudentData
            // 
            this.gc_StudentData.Controls.Add(this.label_EmailAddress);
            this.gc_StudentData.Controls.Add(this.label_YearLevel);
            this.gc_StudentData.Controls.Add(this.label_Course);
            this.gc_StudentData.Controls.Add(this.label_SchoolStudentId);
            this.gc_StudentData.Controls.Add(this.label_LastName);
            this.gc_StudentData.Controls.Add(this.label_MiddleName);
            this.gc_StudentData.Controls.Add(this.label_FirstName);
            this.gc_StudentData.Controls.Add(this.se_YearLevel);
            this.gc_StudentData.Controls.Add(this.cbe_Course);
            this.gc_StudentData.Controls.Add(this.txt_EmailAddress);
            this.gc_StudentData.Controls.Add(this.txt_SchoolStudentId);
            this.gc_StudentData.Controls.Add(this.txt_LastName);
            this.gc_StudentData.Controls.Add(this.txt_MiddleName);
            this.gc_StudentData.Controls.Add(this.txt_FirstName);
            this.gc_StudentData.Location = new System.Drawing.Point(18, 21);
            this.gc_StudentData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_StudentData.Name = "gc_StudentData";
            this.gc_StudentData.Size = new System.Drawing.Size(388, 559);
            this.gc_StudentData.TabIndex = 6;
            this.gc_StudentData.Text = "Student Data";
            // 
            // label_EmailAddress
            // 
            this.label_EmailAddress.Location = new System.Drawing.Point(18, 462);
            this.label_EmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_EmailAddress.Name = "label_EmailAddress";
            this.label_EmailAddress.Size = new System.Drawing.Size(94, 25);
            this.label_EmailAddress.TabIndex = 14;
            this.label_EmailAddress.Text = "Email Address";
            // 
            // label_YearLevel
            // 
            this.label_YearLevel.Location = new System.Drawing.Point(185, 392);
            this.label_YearLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_YearLevel.Name = "label_YearLevel";
            this.label_YearLevel.Size = new System.Drawing.Size(69, 25);
            this.label_YearLevel.TabIndex = 13;
            this.label_YearLevel.Text = "Year Level";
            // 
            // label_Course
            // 
            this.label_Course.Location = new System.Drawing.Point(17, 392);
            this.label_Course.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(50, 25);
            this.label_Course.TabIndex = 12;
            this.label_Course.Text = "Course";
            // 
            // label_SchoolStudentId
            // 
            this.label_SchoolStudentId.Location = new System.Drawing.Point(18, 313);
            this.label_SchoolStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_SchoolStudentId.Name = "label_SchoolStudentId";
            this.label_SchoolStudentId.Size = new System.Drawing.Size(63, 25);
            this.label_SchoolStudentId.TabIndex = 11;
            this.label_SchoolStudentId.Text = "School ID";
            // 
            // label_LastName
            // 
            this.label_LastName.Location = new System.Drawing.Point(17, 228);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(72, 25);
            this.label_LastName.TabIndex = 10;
            this.label_LastName.Text = "Last Name";
            // 
            // label_MiddleName
            // 
            this.label_MiddleName.Location = new System.Drawing.Point(18, 138);
            this.label_MiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_MiddleName.Name = "label_MiddleName";
            this.label_MiddleName.Size = new System.Drawing.Size(90, 25);
            this.label_MiddleName.TabIndex = 9;
            this.label_MiddleName.Text = "Middle Name";
            // 
            // label_FirstName
            // 
            this.label_FirstName.Location = new System.Drawing.Point(17, 50);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(72, 25);
            this.label_FirstName.TabIndex = 8;
            this.label_FirstName.Text = "First Name";
            // 
            // se_YearLevel
            // 
            this.se_YearLevel.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.se_YearLevel.Location = new System.Drawing.Point(185, 417);
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
            this.se_YearLevel.Size = new System.Drawing.Size(177, 44);
            this.se_YearLevel.TabIndex = 7;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Location = new System.Drawing.Point(18, 417);
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
            this.cbe_Course.Size = new System.Drawing.Size(160, 44);
            this.cbe_Course.TabIndex = 6;
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(17, 493);
            this.txt_EmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.Size = new System.Drawing.Size(345, 44);
            this.txt_EmailAddress.TabIndex = 4;
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(18, 339);
            this.txt_SchoolStudentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(344, 44);
            this.txt_SchoolStudentId.TabIndex = 3;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(18, 261);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(344, 44);
            this.txt_LastName.TabIndex = 2;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(18, 171);
            this.txt_MiddleName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(344, 44);
            this.txt_MiddleName.TabIndex = 1;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(17, 83);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(345, 44);
            this.txt_FirstName.TabIndex = 0;
            // 
            // panel_SaveStudentData
            // 
            this.panel_SaveStudentData.Controls.Add(this.timeEdit1);
            this.panel_SaveStudentData.Controls.Add(this.btn_Cancel);
            this.panel_SaveStudentData.Controls.Add(this.btn_Save);
            this.panel_SaveStudentData.Controls.Add(this.btn_Generate);
            this.panel_SaveStudentData.Controls.Add(this.pe_QRCode);
            this.panel_SaveStudentData.Location = new System.Drawing.Point(412, 21);
            this.panel_SaveStudentData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_SaveStudentData.Name = "panel_SaveStudentData";
            this.panel_SaveStudentData.Size = new System.Drawing.Size(328, 559);
            this.panel_SaveStudentData.TabIndex = 5;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(6, 493);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(315, 45);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "CANCEL";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(6, 442);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(315, 45);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(6, 313);
            this.btn_Generate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(315, 45);
            this.btn_Generate.TabIndex = 1;
            this.btn_Generate.Text = "GENERATE";
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // pe_QRCode
            // 
            this.pe_QRCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pe_QRCode.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pe_QRCode.Name = "pe_QRCode";
            this.pe_QRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCode.Size = new System.Drawing.Size(324, 303);
            this.pe_QRCode.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_SaveStudentData,
            this.lci_StudentData});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(758, 601);
            this.Root.TextVisible = false;
            // 
            // lci_SaveStudentData
            // 
            this.lci_SaveStudentData.Control = this.panel_SaveStudentData;
            this.lci_SaveStudentData.Location = new System.Drawing.Point(394, 0);
            this.lci_SaveStudentData.Name = "lci_SaveStudentData";
            this.lci_SaveStudentData.Size = new System.Drawing.Size(334, 567);
            this.lci_SaveStudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SaveStudentData.TextVisible = false;
            // 
            // lci_StudentData
            // 
            this.lci_StudentData.Control = this.gc_StudentData;
            this.lci_StudentData.Location = new System.Drawing.Point(0, 0);
            this.lci_StudentData.Name = "lci_StudentData";
            this.lci_StudentData.Size = new System.Drawing.Size(394, 567);
            this.lci_StudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentData.TextVisible = false;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2025, 4, 23, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(37, 383);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(125, 44);
            this.timeEdit1.TabIndex = 4;
            // 
            // AddStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 601);
            this.Controls.Add(this.lc_AddStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudent_Form";
            this.Text = "AddStudent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent)).EndInit();
            this.lc_AddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).EndInit();
            this.gc_StudentData.ResumeLayout(false);
            this.gc_StudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.se_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_SaveStudentData)).EndInit();
            this.panel_SaveStudentData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pe_QRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddStudent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_SaveStudentData;
        private DevExpress.XtraLayout.LayoutControlItem lci_SaveStudentData;
        private DevExpress.XtraEditors.GroupControl gc_StudentData;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentData;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_MiddleName;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl label_EmailAddress;
        private DevExpress.XtraEditors.LabelControl label_YearLevel;
        private DevExpress.XtraEditors.LabelControl label_Course;
        private DevExpress.XtraEditors.LabelControl label_SchoolStudentId;
        private DevExpress.XtraEditors.LabelControl label_LastName;
        private DevExpress.XtraEditors.LabelControl label_MiddleName;
        private DevExpress.XtraEditors.LabelControl label_FirstName;
        private DevExpress.XtraEditors.SpinEdit se_YearLevel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.TextEdit txt_EmailAddress;
        private DevExpress.XtraEditors.TextEdit txt_SchoolStudentId;
        private DevExpress.XtraEditors.PictureEdit pe_QRCode;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Generate;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
    }
}