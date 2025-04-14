namespace AttendanceManagementSystem.Forms.Students
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
            this.lc_StudentAttendanceRecord = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_QRCode = new DevExpress.XtraEditors.PanelControl();
            this.lci_panelQRCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_StudentInformation = new DevExpress.XtraEditors.PanelControl();
            this.lci_StudentInformation = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_Present = new DevExpress.XtraEditors.PanelControl();
            this.lci_panelPresent = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_AttendanceRecords = new DevExpress.XtraEditors.PanelControl();
            this.lci_AttendanceRecords = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureEdit_StudentQRCode = new DevExpress.XtraEditors.PictureEdit();
            this.label_Name = new DevExpress.XtraEditors.LabelControl();
            this.label_Course = new DevExpress.XtraEditors.LabelControl();
            this.label_YearLevel = new DevExpress.XtraEditors.LabelControl();
            this.label_StudentId = new DevExpress.XtraEditors.LabelControl();
            this.txt_StudentName = new DevExpress.XtraEditors.TextEdit();
            this.txt_Course = new DevExpress.XtraEditors.TextEdit();
            this.txt_StudentId = new DevExpress.XtraEditors.TextEdit();
            this.txt_YearLevel = new DevExpress.XtraEditors.TextEdit();
            this.panel_Absent = new DevExpress.XtraEditors.PanelControl();
            this.lci_panelAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel_TotalAttendance = new DevExpress.XtraEditors.PanelControl();
            this.lci_panelTotalAttendance = new DevExpress.XtraLayout.LayoutControlItem();
            this.label_Present = new DevExpress.XtraEditors.LabelControl();
            this.label_Absent = new DevExpress.XtraEditors.LabelControl();
            this.label_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.txt_TotalPresent = new DevExpress.XtraEditors.TextEdit();
            this.txt_TotalAbsent = new DevExpress.XtraEditors.TextEdit();
            this.txt_TotalAttendance = new DevExpress.XtraEditors.TextEdit();
            this.gc_AttendanceRecords = new DevExpress.XtraGrid.GridControl();
            this.gv_AttendanceRecords = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Marked = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).BeginInit();
            this.lc_StudentAttendanceRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).BeginInit();
            this.panel_QRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInformation)).BeginInit();
            this.panel_StudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Present)).BeginInit();
            this.panel_Present.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_AttendanceRecords)).BeginInit();
            this.panel_AttendanceRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendanceRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_StudentQRCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Course.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Absent)).BeginInit();
            this.panel_Absent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).BeginInit();
            this.panel_TotalAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelTotalAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAttendance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_StudentAttendanceRecord
            // 
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAttendance);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_Absent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_AttendanceRecords);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_Present);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_StudentInformation);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_QRCode);
            this.lc_StudentAttendanceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_StudentAttendanceRecord.Location = new System.Drawing.Point(0, 0);
            this.lc_StudentAttendanceRecord.Name = "lc_StudentAttendanceRecord";
            this.lc_StudentAttendanceRecord.Root = this.Root;
            this.lc_StudentAttendanceRecord.Size = new System.Drawing.Size(778, 746);
            this.lc_StudentAttendanceRecord.TabIndex = 0;
            this.lc_StudentAttendanceRecord.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_panelQRCode,
            this.lci_StudentInformation,
            this.lci_panelPresent,
            this.lci_AttendanceRecords,
            this.lci_panelAbsent,
            this.lci_panelTotalAttendance});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(778, 746);
            this.Root.TextVisible = false;
            // 
            // panel_QRCode
            // 
            this.panel_QRCode.Controls.Add(this.pictureEdit_StudentQRCode);
            this.panel_QRCode.Location = new System.Drawing.Point(16, 16);
            this.panel_QRCode.Name = "panel_QRCode";
            this.panel_QRCode.Size = new System.Drawing.Size(187, 169);
            this.panel_QRCode.TabIndex = 4;
            // 
            // lci_panelQRCode
            // 
            this.lci_panelQRCode.Control = this.panel_QRCode;
            this.lci_panelQRCode.Location = new System.Drawing.Point(0, 0);
            this.lci_panelQRCode.Name = "lci_panelQRCode";
            this.lci_panelQRCode.Size = new System.Drawing.Size(193, 175);
            this.lci_panelQRCode.TextSize = new System.Drawing.Size(0, 0);
            this.lci_panelQRCode.TextVisible = false;
            // 
            // panel_StudentInformation
            // 
            this.panel_StudentInformation.Controls.Add(this.txt_YearLevel);
            this.panel_StudentInformation.Controls.Add(this.txt_StudentId);
            this.panel_StudentInformation.Controls.Add(this.txt_Course);
            this.panel_StudentInformation.Controls.Add(this.txt_StudentName);
            this.panel_StudentInformation.Controls.Add(this.label_StudentId);
            this.panel_StudentInformation.Controls.Add(this.label_YearLevel);
            this.panel_StudentInformation.Controls.Add(this.label_Course);
            this.panel_StudentInformation.Controls.Add(this.label_Name);
            this.panel_StudentInformation.Location = new System.Drawing.Point(209, 16);
            this.panel_StudentInformation.Name = "panel_StudentInformation";
            this.panel_StudentInformation.Size = new System.Drawing.Size(553, 169);
            this.panel_StudentInformation.TabIndex = 5;
            // 
            // lci_StudentInformation
            // 
            this.lci_StudentInformation.Control = this.panel_StudentInformation;
            this.lci_StudentInformation.Location = new System.Drawing.Point(193, 0);
            this.lci_StudentInformation.Name = "lci_StudentInformation";
            this.lci_StudentInformation.Size = new System.Drawing.Size(559, 175);
            this.lci_StudentInformation.TextSize = new System.Drawing.Size(0, 0);
            this.lci_StudentInformation.TextVisible = false;
            // 
            // panel_Present
            // 
            this.panel_Present.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Present.Appearance.Options.UseBackColor = true;
            this.panel_Present.Controls.Add(this.txt_TotalPresent);
            this.panel_Present.Controls.Add(this.label_Present);
            this.panel_Present.Location = new System.Drawing.Point(16, 191);
            this.panel_Present.Name = "panel_Present";
            this.panel_Present.Size = new System.Drawing.Size(245, 116);
            this.panel_Present.TabIndex = 6;
            // 
            // lci_panelPresent
            // 
            this.lci_panelPresent.Control = this.panel_Present;
            this.lci_panelPresent.Location = new System.Drawing.Point(0, 175);
            this.lci_panelPresent.Name = "lci_panelPresent";
            this.lci_panelPresent.Size = new System.Drawing.Size(251, 122);
            this.lci_panelPresent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_panelPresent.TextVisible = false;
            // 
            // panel_AttendanceRecords
            // 
            this.panel_AttendanceRecords.Controls.Add(this.gc_AttendanceRecords);
            this.panel_AttendanceRecords.Location = new System.Drawing.Point(16, 313);
            this.panel_AttendanceRecords.Name = "panel_AttendanceRecords";
            this.panel_AttendanceRecords.Size = new System.Drawing.Size(746, 417);
            this.panel_AttendanceRecords.TabIndex = 7;
            // 
            // lci_AttendanceRecords
            // 
            this.lci_AttendanceRecords.Control = this.panel_AttendanceRecords;
            this.lci_AttendanceRecords.Location = new System.Drawing.Point(0, 297);
            this.lci_AttendanceRecords.Name = "lci_AttendanceRecords";
            this.lci_AttendanceRecords.Size = new System.Drawing.Size(752, 423);
            this.lci_AttendanceRecords.TextSize = new System.Drawing.Size(0, 0);
            this.lci_AttendanceRecords.TextVisible = false;
            // 
            // pictureEdit_StudentQRCode
            // 
            this.pictureEdit_StudentQRCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit_StudentQRCode.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit_StudentQRCode.Name = "pictureEdit_StudentQRCode";
            this.pictureEdit_StudentQRCode.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit_StudentQRCode.Size = new System.Drawing.Size(183, 165);
            this.pictureEdit_StudentQRCode.TabIndex = 0;
            // 
            // label_Name
            // 
            this.label_Name.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Name.Appearance.Options.UseFont = true;
            this.label_Name.Location = new System.Drawing.Point(17, 22);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(42, 25);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // label_Course
            // 
            this.label_Course.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Course.Appearance.Options.UseFont = true;
            this.label_Course.Location = new System.Drawing.Point(17, 92);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(50, 25);
            this.label_Course.TabIndex = 1;
            this.label_Course.Text = "Course";
            // 
            // label_YearLevel
            // 
            this.label_YearLevel.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_YearLevel.Appearance.Options.UseFont = true;
            this.label_YearLevel.Location = new System.Drawing.Point(316, 92);
            this.label_YearLevel.Name = "label_YearLevel";
            this.label_YearLevel.Size = new System.Drawing.Size(69, 25);
            this.label_YearLevel.TabIndex = 2;
            this.label_YearLevel.Text = "Year Level";
            // 
            // label_StudentId
            // 
            this.label_StudentId.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_StudentId.Appearance.Options.UseFont = true;
            this.label_StudentId.Location = new System.Drawing.Point(316, 22);
            this.label_StudentId.Name = "label_StudentId";
            this.label_StudentId.Size = new System.Drawing.Size(69, 25);
            this.label_StudentId.TabIndex = 3;
            this.label_StudentId.Text = "Student Id";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(17, 44);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Properties.ReadOnly = true;
            this.txt_StudentName.Size = new System.Drawing.Size(284, 34);
            this.txt_StudentName.TabIndex = 4;
            // 
            // txt_Course
            // 
            this.txt_Course.Location = new System.Drawing.Point(17, 113);
            this.txt_Course.Name = "txt_Course";
            this.txt_Course.Properties.ReadOnly = true;
            this.txt_Course.Size = new System.Drawing.Size(284, 34);
            this.txt_Course.TabIndex = 5;
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.Location = new System.Drawing.Point(316, 44);
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.Properties.ReadOnly = true;
            this.txt_StudentId.Size = new System.Drawing.Size(219, 34);
            this.txt_StudentId.TabIndex = 6;
            // 
            // txt_YearLevel
            // 
            this.txt_YearLevel.Location = new System.Drawing.Point(316, 113);
            this.txt_YearLevel.Name = "txt_YearLevel";
            this.txt_YearLevel.Properties.ReadOnly = true;
            this.txt_YearLevel.Size = new System.Drawing.Size(219, 34);
            this.txt_YearLevel.TabIndex = 7;
            // 
            // panel_Absent
            // 
            this.panel_Absent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel_Absent.Appearance.Options.UseBackColor = true;
            this.panel_Absent.Controls.Add(this.txt_TotalAbsent);
            this.panel_Absent.Controls.Add(this.label_Absent);
            this.panel_Absent.Location = new System.Drawing.Point(267, 191);
            this.panel_Absent.Name = "panel_Absent";
            this.panel_Absent.Size = new System.Drawing.Size(244, 116);
            this.panel_Absent.TabIndex = 8;
            // 
            // lci_panelAbsent
            // 
            this.lci_panelAbsent.Control = this.panel_Absent;
            this.lci_panelAbsent.Location = new System.Drawing.Point(251, 175);
            this.lci_panelAbsent.Name = "lci_panelAbsent";
            this.lci_panelAbsent.Size = new System.Drawing.Size(250, 122);
            this.lci_panelAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_panelAbsent.TextVisible = false;
            // 
            // panel_TotalAttendance
            // 
            this.panel_TotalAttendance.Controls.Add(this.txt_TotalAttendance);
            this.panel_TotalAttendance.Controls.Add(this.label_TotalAttendance);
            this.panel_TotalAttendance.Location = new System.Drawing.Point(517, 191);
            this.panel_TotalAttendance.Name = "panel_TotalAttendance";
            this.panel_TotalAttendance.Size = new System.Drawing.Size(245, 116);
            this.panel_TotalAttendance.TabIndex = 9;
            // 
            // lci_panelTotalAttendance
            // 
            this.lci_panelTotalAttendance.Control = this.panel_TotalAttendance;
            this.lci_panelTotalAttendance.Location = new System.Drawing.Point(501, 175);
            this.lci_panelTotalAttendance.Name = "lci_panelTotalAttendance";
            this.lci_panelTotalAttendance.Size = new System.Drawing.Size(251, 122);
            this.lci_panelTotalAttendance.TextSize = new System.Drawing.Size(0, 0);
            this.lci_panelTotalAttendance.TextVisible = false;
            // 
            // label_Present
            // 
            this.label_Present.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Present.Appearance.Options.UseFont = true;
            this.label_Present.Location = new System.Drawing.Point(96, 70);
            this.label_Present.Name = "label_Present";
            this.label_Present.Size = new System.Drawing.Size(52, 25);
            this.label_Present.TabIndex = 1;
            this.label_Present.Text = "Present";
            // 
            // label_Absent
            // 
            this.label_Absent.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Absent.Appearance.Options.UseFont = true;
            this.label_Absent.Location = new System.Drawing.Point(98, 70);
            this.label_Absent.Name = "label_Absent";
            this.label_Absent.Size = new System.Drawing.Size(48, 25);
            this.label_Absent.TabIndex = 2;
            this.label_Absent.Text = "Absent";
            // 
            // label_TotalAttendance
            // 
            this.label_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_TotalAttendance.Appearance.Options.UseFont = true;
            this.label_TotalAttendance.Location = new System.Drawing.Point(63, 70);
            this.label_TotalAttendance.Name = "label_TotalAttendance";
            this.label_TotalAttendance.Size = new System.Drawing.Size(118, 25);
            this.label_TotalAttendance.TabIndex = 2;
            this.label_TotalAttendance.Text = "Total Attendance";
            // 
            // txt_TotalPresent
            // 
            this.txt_TotalPresent.Location = new System.Drawing.Point(72, 30);
            this.txt_TotalPresent.Name = "txt_TotalPresent";
            this.txt_TotalPresent.Properties.ReadOnly = true;
            this.txt_TotalPresent.Size = new System.Drawing.Size(100, 34);
            this.txt_TotalPresent.TabIndex = 2;
            // 
            // txt_TotalAbsent
            // 
            this.txt_TotalAbsent.Location = new System.Drawing.Point(72, 30);
            this.txt_TotalAbsent.Name = "txt_TotalAbsent";
            this.txt_TotalAbsent.Properties.ReadOnly = true;
            this.txt_TotalAbsent.Size = new System.Drawing.Size(100, 34);
            this.txt_TotalAbsent.TabIndex = 3;
            // 
            // txt_TotalAttendance
            // 
            this.txt_TotalAttendance.Location = new System.Drawing.Point(72, 30);
            this.txt_TotalAttendance.Name = "txt_TotalAttendance";
            this.txt_TotalAttendance.Properties.ReadOnly = true;
            this.txt_TotalAttendance.Size = new System.Drawing.Size(100, 34);
            this.txt_TotalAttendance.TabIndex = 3;
            // 
            // gc_AttendanceRecords
            // 
            this.gc_AttendanceRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_AttendanceRecords.Location = new System.Drawing.Point(2, 2);
            this.gc_AttendanceRecords.MainView = this.gv_AttendanceRecords;
            this.gc_AttendanceRecords.Name = "gc_AttendanceRecords";
            this.gc_AttendanceRecords.Size = new System.Drawing.Size(742, 413);
            this.gc_AttendanceRecords.TabIndex = 0;
            this.gc_AttendanceRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AttendanceRecords});
            // 
            // gv_AttendanceRecords
            // 
            this.gv_AttendanceRecords.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Title,
            this.gc_Date,
            this.gc_StartTime,
            this.gc_EndTime,
            this.gc_Location,
            this.gc_Marked});
            this.gv_AttendanceRecords.GridControl = this.gc_AttendanceRecords;
            this.gv_AttendanceRecords.Name = "gv_AttendanceRecords";
            // 
            // gc_Title
            // 
            this.gc_Title.Caption = "Title";
            this.gc_Title.Name = "gc_Title";
            this.gc_Title.Visible = true;
            this.gc_Title.VisibleIndex = 0;
            // 
            // gc_Date
            // 
            this.gc_Date.Caption = "Date";
            this.gc_Date.Name = "gc_Date";
            this.gc_Date.Visible = true;
            this.gc_Date.VisibleIndex = 1;
            // 
            // gc_StartTime
            // 
            this.gc_StartTime.Caption = "Start Time";
            this.gc_StartTime.Name = "gc_StartTime";
            this.gc_StartTime.Visible = true;
            this.gc_StartTime.VisibleIndex = 2;
            // 
            // gc_EndTime
            // 
            this.gc_EndTime.Caption = "End Time";
            this.gc_EndTime.Name = "gc_EndTime";
            this.gc_EndTime.Visible = true;
            this.gc_EndTime.VisibleIndex = 3;
            // 
            // gc_Location
            // 
            this.gc_Location.Caption = "Location";
            this.gc_Location.Name = "gc_Location";
            this.gc_Location.Visible = true;
            this.gc_Location.VisibleIndex = 4;
            // 
            // gc_Marked
            // 
            this.gc_Marked.Caption = "Marked";
            this.gc_Marked.Name = "gc_Marked";
            this.gc_Marked.Visible = true;
            this.gc_Marked.VisibleIndex = 5;
            // 
            // StudentAttendanceRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 746);
            this.Controls.Add(this.lc_StudentAttendanceRecord);
            this.Name = "StudentAttendanceRecord_Form";
            this.Text = "Student Attendance Record";
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).EndInit();
            this.lc_StudentAttendanceRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_QRCode)).EndInit();
            this.panel_QRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_StudentInformation)).EndInit();
            this.panel_StudentInformation.ResumeLayout(false);
            this.panel_StudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StudentInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Present)).EndInit();
            this.panel_Present.ResumeLayout(false);
            this.panel_Present.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_AttendanceRecords)).EndInit();
            this.panel_AttendanceRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendanceRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_StudentQRCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Course.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_StudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Absent)).EndInit();
            this.panel_Absent.ResumeLayout(false);
            this.panel_Absent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).EndInit();
            this.panel_TotalAttendance.ResumeLayout(false);
            this.panel_TotalAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_panelTotalAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalPresent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAbsent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TotalAttendance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_StudentAttendanceRecord;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_QRCode;
        private DevExpress.XtraLayout.LayoutControlItem lci_panelQRCode;
        private DevExpress.XtraEditors.PanelControl panel_AttendanceRecords;
        private DevExpress.XtraEditors.PanelControl panel_Present;
        private DevExpress.XtraEditors.PanelControl panel_StudentInformation;
        private DevExpress.XtraLayout.LayoutControlItem lci_StudentInformation;
        private DevExpress.XtraLayout.LayoutControlItem lci_panelPresent;
        private DevExpress.XtraLayout.LayoutControlItem lci_AttendanceRecords;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_StudentQRCode;
        private DevExpress.XtraEditors.LabelControl label_Name;
        private DevExpress.XtraEditors.LabelControl label_StudentId;
        private DevExpress.XtraEditors.LabelControl label_YearLevel;
        private DevExpress.XtraEditors.LabelControl label_Course;
        private DevExpress.XtraEditors.TextEdit txt_YearLevel;
        private DevExpress.XtraEditors.TextEdit txt_StudentId;
        private DevExpress.XtraEditors.TextEdit txt_Course;
        private DevExpress.XtraEditors.TextEdit txt_StudentName;
        private DevExpress.XtraEditors.PanelControl panel_TotalAttendance;
        private DevExpress.XtraEditors.PanelControl panel_Absent;
        private DevExpress.XtraLayout.LayoutControlItem lci_panelAbsent;
        private DevExpress.XtraLayout.LayoutControlItem lci_panelTotalAttendance;
        private DevExpress.XtraEditors.LabelControl label_TotalAttendance;
        private DevExpress.XtraEditors.LabelControl label_Absent;
        private DevExpress.XtraEditors.LabelControl label_Present;
        private DevExpress.XtraEditors.TextEdit txt_TotalAttendance;
        private DevExpress.XtraEditors.TextEdit txt_TotalAbsent;
        private DevExpress.XtraEditors.TextEdit txt_TotalPresent;
        private DevExpress.XtraGrid.GridControl gc_AttendanceRecords;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AttendanceRecords;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Title;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Date;
        private DevExpress.XtraGrid.Columns.GridColumn gc_StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Location;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Marked;
    }
}