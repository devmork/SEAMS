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
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_MiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.TextEdit();
            this.cbe_YearLevel = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditStudent)).BeginInit();
            this.lc_EditStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).BeginInit();
            this.panel_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).BeginInit();
            this.gc_StudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lc_TextFields)).BeginInit();
            this.lc_TextFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).BeginInit();
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
            this.lc_EditStudent.Size = new System.Drawing.Size(1080, 541);
            this.lc_EditStudent.TabIndex = 0;
            this.lc_EditStudent.Text = "layoutControl1";
            // 
            // panel_Actions
            // 
            this.panel_Actions.Controls.Add(this.btn_Cancel);
            this.panel_Actions.Controls.Add(this.btn_SaveChanges);
            this.panel_Actions.Location = new System.Drawing.Point(657, 295);
            this.panel_Actions.Name = "panel_Actions";
            this.panel_Actions.Size = new System.Drawing.Size(407, 230);
            this.panel_Actions.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 186);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(394, 34);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_SaveChanges.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.btn_SaveChanges.Appearance.Options.UseBackColor = true;
            this.btn_SaveChanges.Appearance.Options.UseFont = true;
            this.btn_SaveChanges.Location = new System.Drawing.Point(6, 147);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(394, 34);
            this.btn_SaveChanges.TabIndex = 4;
            this.btn_SaveChanges.Text = "SAVE CHANGES";
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // gc_StudentData
            // 
            this.gc_StudentData.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 14F);
            this.gc_StudentData.AppearanceCaption.Options.UseFont = true;
            this.gc_StudentData.Controls.Add(this.lc_TextFields);
            this.gc_StudentData.Location = new System.Drawing.Point(16, 15);
            this.gc_StudentData.Name = "gc_StudentData";
            this.gc_StudentData.Size = new System.Drawing.Size(635, 511);
            this.gc_StudentData.TabIndex = 6;
            this.gc_StudentData.Text = "Student Data";
            // 
            // lc_TextFields
            // 
            this.lc_TextFields.Controls.Add(this.txt_EmailAddress);
            this.lc_TextFields.Controls.Add(this.cbe_Course);
            this.lc_TextFields.Controls.Add(this.txt_MiddleName);
            this.lc_TextFields.Controls.Add(this.txt_FirstName);
            this.lc_TextFields.Controls.Add(this.txt_LastName);
            this.lc_TextFields.Controls.Add(this.txt_SchoolStudentId);
            this.lc_TextFields.Controls.Add(this.cbe_YearLevel);
            this.lc_TextFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_TextFields.Location = new System.Drawing.Point(2, 39);
            this.lc_TextFields.Name = "lc_TextFields";
            this.lc_TextFields.Root = this.lc_StudentData;
            this.lc_TextFields.Size = new System.Drawing.Size(631, 470);
            this.lc_TextFields.TabIndex = 0;
            this.lc_TextFields.Text = "layoutControl1";
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(16, 420);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.Size = new System.Drawing.Size(599, 34);
            this.txt_EmailAddress.StyleController = this.lc_TextFields;
            this.txt_EmailAddress.TabIndex = 9;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Location = new System.Drawing.Point(16, 346);
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
            this.cbe_Course.Size = new System.Drawing.Size(291, 34);
            this.cbe_Course.StyleController = this.lc_TextFields;
            this.cbe_Course.TabIndex = 7;
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(16, 124);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(599, 34);
            this.txt_MiddleName.StyleController = this.lc_TextFields;
            this.txt_MiddleName.TabIndex = 5;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(16, 50);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(599, 34);
            this.txt_FirstName.StyleController = this.lc_TextFields;
            this.txt_FirstName.TabIndex = 4;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(16, 198);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(599, 34);
            this.txt_LastName.StyleController = this.lc_TextFields;
            this.txt_LastName.TabIndex = 5;
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(16, 272);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(599, 34);
            this.txt_SchoolStudentId.StyleController = this.lc_TextFields;
            this.txt_SchoolStudentId.TabIndex = 5;
            this.txt_SchoolStudentId.EditValueChanged += new System.EventHandler(this.txt_SchoolStudentId_EditValueChanged);
            this.txt_SchoolStudentId.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txt_SchoolStudentId_EditValueChanging);
            // 
            // cbe_YearLevel
            // 
            this.cbe_YearLevel.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbe_YearLevel.Location = new System.Drawing.Point(313, 346);
            this.cbe_YearLevel.Name = "cbe_YearLevel";
            this.cbe_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_YearLevel.Properties.DropDownRows = 4;
            this.cbe_YearLevel.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.cbe_YearLevel.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbe_YearLevel.Size = new System.Drawing.Size(302, 34);
            this.cbe_YearLevel.StyleController = this.lc_TextFields;
            this.cbe_YearLevel.TabIndex = 8;
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
            this.lc_StudentData.Size = new System.Drawing.Size(631, 470);
            this.lc_StudentData.TextVisible = false;
            // 
            // lci_FirstName
            // 
            this.lci_FirstName.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_FirstName.AppearanceItemCaption.Options.UseFont = true;
            this.lci_FirstName.Control = this.txt_FirstName;
            this.lci_FirstName.Location = new System.Drawing.Point(0, 0);
            this.lci_FirstName.Name = "lci_FirstName";
            this.lci_FirstName.Size = new System.Drawing.Size(605, 74);
            this.lci_FirstName.Text = "First Name";
            this.lci_FirstName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_FirstName.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_MiddleName
            // 
            this.lci_MiddleName.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_MiddleName.AppearanceItemCaption.Options.UseFont = true;
            this.lci_MiddleName.Control = this.txt_MiddleName;
            this.lci_MiddleName.Location = new System.Drawing.Point(0, 74);
            this.lci_MiddleName.Name = "lci_MiddleName";
            this.lci_MiddleName.Size = new System.Drawing.Size(605, 74);
            this.lci_MiddleName.Text = "Middle Name";
            this.lci_MiddleName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_MiddleName.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_LastName
            // 
            this.lci_LastName.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_LastName.AppearanceItemCaption.Options.UseFont = true;
            this.lci_LastName.Control = this.txt_LastName;
            this.lci_LastName.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_LastName.CustomizationFormText = "layoutControlItem2";
            this.lci_LastName.Location = new System.Drawing.Point(0, 148);
            this.lci_LastName.Name = "lci_LastName";
            this.lci_LastName.Size = new System.Drawing.Size(605, 74);
            this.lci_LastName.Text = "Last Name";
            this.lci_LastName.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_LastName.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_StudentId
            // 
            this.lci_StudentId.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_StudentId.AppearanceItemCaption.Options.UseFont = true;
            this.lci_StudentId.Control = this.txt_SchoolStudentId;
            this.lci_StudentId.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StudentId.CustomizationFormText = "layoutControlItem2";
            this.lci_StudentId.Location = new System.Drawing.Point(0, 222);
            this.lci_StudentId.Name = "lci_StudentId";
            this.lci_StudentId.Size = new System.Drawing.Size(605, 74);
            this.lci_StudentId.Text = "ID #";
            this.lci_StudentId.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_StudentId.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_Course
            // 
            this.lci_Course.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_Course.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Course.Control = this.cbe_Course;
            this.lci_Course.Location = new System.Drawing.Point(0, 296);
            this.lci_Course.Name = "lci_Course";
            this.lci_Course.Size = new System.Drawing.Size(297, 74);
            this.lci_Course.Text = "Course";
            this.lci_Course.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Course.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_YearLevel
            // 
            this.lci_YearLevel.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_YearLevel.AppearanceItemCaption.Options.UseFont = true;
            this.lci_YearLevel.Control = this.cbe_YearLevel;
            this.lci_YearLevel.Location = new System.Drawing.Point(297, 296);
            this.lci_YearLevel.Name = "lci_YearLevel";
            this.lci_YearLevel.Size = new System.Drawing.Size(308, 74);
            this.lci_YearLevel.Text = "Year Level";
            this.lci_YearLevel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_YearLevel.TextSize = new System.Drawing.Size(106, 28);
            // 
            // lci_Email
            // 
            this.lci_Email.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F);
            this.lci_Email.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Email.Control = this.txt_EmailAddress;
            this.lci_Email.Location = new System.Drawing.Point(0, 370);
            this.lci_Email.Name = "lci_Email";
            this.lci_Email.Size = new System.Drawing.Size(605, 74);
            this.lci_Email.Text = "Email";
            this.lci_Email.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Email.TextSize = new System.Drawing.Size(106, 28);
            // 
            // panel_QRCode
            // 
            this.panel_QRCode.Controls.Add(this.pe_QRCode);
            this.panel_QRCode.Location = new System.Drawing.Point(657, 15);
            this.panel_QRCode.Name = "panel_QRCode";
            this.panel_QRCode.Size = new System.Drawing.Size(407, 275);
            this.panel_QRCode.TabIndex = 5;
            // 
            // pe_QRCode
            // 
            this.pe_QRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pe_QRCode.Location = new System.Drawing.Point(2, 2);
            this.pe_QRCode.Name = "pe_QRCode";
            this.pe_QRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pe_QRCode.Size = new System.Drawing.Size(403, 271);
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
            this.Root.Size = new System.Drawing.Size(1080, 541);
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
            this.lci_StudentData.Size = new System.Drawing.Size(641, 515);
            this.lci_StudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentData.TextVisible = false;
            // 
            // lci_SaveStudentData
            // 
            this.lci_SaveStudentData.Control = this.panel_QRCode;
            this.lci_SaveStudentData.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_SaveStudentData.CustomizationFormText = "lci_SaveStudentData";
            this.lci_SaveStudentData.Location = new System.Drawing.Point(641, 0);
            this.lci_SaveStudentData.Name = "lci_SaveStudentData";
            this.lci_SaveStudentData.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 2, 2);
            this.lci_SaveStudentData.Size = new System.Drawing.Size(413, 279);
            this.lci_SaveStudentData.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SaveStudentData.TextVisible = false;
            // 
            // lci_Actions
            // 
            this.lci_Actions.Control = this.panel_Actions;
            this.lci_Actions.Location = new System.Drawing.Point(641, 279);
            this.lci_Actions.Name = "lci_Actions";
            this.lci_Actions.Size = new System.Drawing.Size(413, 236);
            this.lci_Actions.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Actions.TextVisible = false;
            // 
            // EditStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 541);
            this.Controls.Add(this.lc_EditStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditStudent_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditStudent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditStudent)).EndInit();
            this.lc_EditStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Actions)).EndInit();
            this.panel_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_StudentData)).EndInit();
            this.gc_StudentData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lc_TextFields)).EndInit();
            this.lc_TextFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_YearLevel.Properties)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem lci_FirstName;
        private DevExpress.XtraLayout.LayoutControlItem lci_MiddleName;
        private DevExpress.XtraLayout.LayoutControlItem lci_LastName;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentId;
        private DevExpress.XtraLayout.LayoutControlItem lci_Course;
        private DevExpress.XtraLayout.LayoutControlItem lci_YearLevel;
        private DevExpress.XtraLayout.LayoutControlItem lci_Email;
        private DevExpress.XtraEditors.PanelControl panel_Actions;
        private DevExpress.XtraLayout.LayoutControlItem lci_Actions;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_SaveChanges;
        public DevExpress.XtraEditors.TextEdit txt_FirstName;
        public DevExpress.XtraEditors.TextEdit txt_MiddleName;
        public DevExpress.XtraEditors.TextEdit txt_LastName;
        public DevExpress.XtraEditors.TextEdit txt_SchoolStudentId;
        public DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        public DevExpress.XtraEditors.TextEdit txt_EmailAddress;
        public DevExpress.XtraEditors.PictureEdit pe_QRCode;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_YearLevel;
    }
}