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
            this.lc_AddStudent_Form = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl_StudentData = new DevExpress.XtraEditors.GroupControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelBody_Right = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MiddleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SchoolStudentId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_EmailAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit_YearLevel = new DevExpress.XtraEditors.SpinEdit();
            this.cbe_Course = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit_StudentQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.btn_Browse = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent_Form)).BeginInit();
            this.lc_AddStudent_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_StudentData)).BeginInit();
            this.groupControl_StudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody_Right)).BeginInit();
            this.panelBody_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_StudentQRCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddStudent_Form
            // 
            this.lc_AddStudent_Form.Controls.Add(this.panelBody_Right);
            this.lc_AddStudent_Form.Controls.Add(this.groupControl_StudentData);
            this.lc_AddStudent_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddStudent_Form.Location = new System.Drawing.Point(0, 0);
            this.lc_AddStudent_Form.Name = "lc_AddStudent_Form";
            this.lc_AddStudent_Form.Root = this.Root;
            this.lc_AddStudent_Form.Size = new System.Drawing.Size(778, 529);
            this.lc_AddStudent_Form.TabIndex = 0;
            this.lc_AddStudent_Form.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(778, 529);
            this.Root.TextVisible = false;
            // 
            // groupControl_StudentData
            // 
            this.groupControl_StudentData.Controls.Add(this.cbe_Course);
            this.groupControl_StudentData.Controls.Add(this.spinEdit_YearLevel);
            this.groupControl_StudentData.Controls.Add(this.labelControl7);
            this.groupControl_StudentData.Controls.Add(this.labelControl6);
            this.groupControl_StudentData.Controls.Add(this.labelControl5);
            this.groupControl_StudentData.Controls.Add(this.txt_EmailAddress);
            this.groupControl_StudentData.Controls.Add(this.labelControl4);
            this.groupControl_StudentData.Controls.Add(this.txt_SchoolStudentId);
            this.groupControl_StudentData.Controls.Add(this.labelControl3);
            this.groupControl_StudentData.Controls.Add(this.txt_FirstName);
            this.groupControl_StudentData.Controls.Add(this.labelControl2);
            this.groupControl_StudentData.Controls.Add(this.txt_MiddleName);
            this.groupControl_StudentData.Controls.Add(this.labelControl1);
            this.groupControl_StudentData.Controls.Add(this.txt_LastName);
            this.groupControl_StudentData.Location = new System.Drawing.Point(16, 16);
            this.groupControl_StudentData.Name = "groupControl_StudentData";
            this.groupControl_StudentData.Size = new System.Drawing.Size(427, 497);
            this.groupControl_StudentData.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl_StudentData;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(433, 503);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelBody_Right
            // 
            this.panelBody_Right.Controls.Add(this.btn_Cancel);
            this.panelBody_Right.Controls.Add(this.btn_Save);
            this.panelBody_Right.Controls.Add(this.btn_Browse);
            this.panelBody_Right.Controls.Add(this.pictureEdit_StudentQRCode);
            this.panelBody_Right.Location = new System.Drawing.Point(449, 16);
            this.panelBody_Right.Name = "panelBody_Right";
            this.panelBody_Right.Size = new System.Drawing.Size(313, 497);
            this.panelBody_Right.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelBody_Right;
            this.layoutControlItem2.Location = new System.Drawing.Point(433, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 503);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(24, 78);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(340, 34);
            this.txt_LastName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Last Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Middle Name";
            // 
            // txt_MiddleName
            // 
            this.txt_MiddleName.Location = new System.Drawing.Point(24, 136);
            this.txt_MiddleName.Name = "txt_MiddleName";
            this.txt_MiddleName.Size = new System.Drawing.Size(340, 34);
            this.txt_MiddleName.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "First Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(24, 192);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(340, 34);
            this.txt_FirstName.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 229);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "School Id";
            // 
            // txt_SchoolStudentId
            // 
            this.txt_SchoolStudentId.Location = new System.Drawing.Point(24, 248);
            this.txt_SchoolStudentId.Name = "txt_SchoolStudentId";
            this.txt_SchoolStudentId.Size = new System.Drawing.Size(340, 34);
            this.txt_SchoolStudentId.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 288);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(77, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Email Address";
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(24, 307);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.Size = new System.Drawing.Size(340, 34);
            this.txt_EmailAddress.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(24, 354);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 19);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Couse";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(24, 416);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 19);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Year Level";
            // 
            // spinEdit_YearLevel
            // 
            this.spinEdit_YearLevel.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_YearLevel.Location = new System.Drawing.Point(24, 442);
            this.spinEdit_YearLevel.Name = "spinEdit_YearLevel";
            this.spinEdit_YearLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_YearLevel.Size = new System.Drawing.Size(340, 34);
            this.spinEdit_YearLevel.TabIndex = 14;
            // 
            // cbe_Course
            // 
            this.cbe_Course.Location = new System.Drawing.Point(24, 380);
            this.cbe_Course.Name = "cbe_Course";
            this.cbe_Course.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_Course.Size = new System.Drawing.Size(340, 34);
            this.cbe_Course.TabIndex = 15;
            // 
            // pictureEdit_StudentQRCode
            // 
            this.pictureEdit_StudentQRCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit_StudentQRCode.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit_StudentQRCode.Name = "pictureEdit_StudentQRCode";
            this.pictureEdit_StudentQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_StudentQRCode.Size = new System.Drawing.Size(309, 246);
            this.pictureEdit_StudentQRCode.TabIndex = 0;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(4, 258);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(302, 39);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.Text = "BROWSE";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(7, 387);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(302, 39);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "SAVE";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(7, 437);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(302, 39);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "CANCEL";
            // 
            // AddStudent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 529);
            this.Controls.Add(this.lc_AddStudent_Form);
            this.Name = "AddStudent_Form";
            this.Text = "Student Registration Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddStudent_Form)).EndInit();
            this.lc_AddStudent_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_StudentData)).EndInit();
            this.groupControl_StudentData.ResumeLayout(false);
            this.groupControl_StudentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody_Right)).EndInit();
            this.panelBody_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SchoolStudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_EmailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_StudentQRCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddStudent_Form;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelBody_Right;
        private DevExpress.XtraEditors.GroupControl groupControl_StudentData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit spinEdit_YearLevel;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_EmailAddress;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_SchoolStudentId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MiddleName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_Course;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Browse;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_StudentQRCode;
    }
}