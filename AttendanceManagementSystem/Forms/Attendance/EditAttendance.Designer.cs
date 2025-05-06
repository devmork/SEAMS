namespace AttendanceManagementSystem.Forms.Events
{
    partial class EditAttendance
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
            this.lc_EditEvent = new DevExpress.XtraLayout.LayoutControl();
            this.gc_EventDetails = new DevExpress.XtraEditors.GroupControl();
            this.cbe_LogType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_SaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.timeEdit_EndTime = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit_StartTime = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit_AttendanceDate = new DevExpress.XtraEditors.DateEdit();
            this.label_EventEndTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventStartTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventLocation = new DevExpress.XtraEditors.LabelControl();
            this.label_EventDate = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceLocation = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceName = new DevExpress.XtraEditors.LabelControl();
            this.txt_AttedanceLocation = new DevExpress.XtraEditors.TextEdit();
            this.txt_AttendanceName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_EditEvent = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbe_TimeOfDay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label_DayTime = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditEvent)).BeginInit();
            this.lc_EditEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).BeginInit();
            this.gc_EventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttedanceLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EditEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_TimeOfDay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_EditEvent
            // 
            this.lc_EditEvent.Controls.Add(this.gc_EventDetails);
            this.lc_EditEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_EditEvent.Location = new System.Drawing.Point(0, 0);
            this.lc_EditEvent.Name = "lc_EditEvent";
            this.lc_EditEvent.Root = this.Root;
            this.lc_EditEvent.Size = new System.Drawing.Size(558, 520);
            this.lc_EditEvent.TabIndex = 0;
            this.lc_EditEvent.Text = "layoutControl1";
            // 
            // gc_EventDetails
            // 
            this.gc_EventDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_EventDetails.AppearanceCaption.Options.UseFont = true;
            this.gc_EventDetails.Controls.Add(this.label_DayTime);
            this.gc_EventDetails.Controls.Add(this.cbe_TimeOfDay);
            this.gc_EventDetails.Controls.Add(this.cbe_LogType);
            this.gc_EventDetails.Controls.Add(this.btn_SaveChanges);
            this.gc_EventDetails.Controls.Add(this.btn_Cancel);
            this.gc_EventDetails.Controls.Add(this.timeEdit_EndTime);
            this.gc_EventDetails.Controls.Add(this.timeEdit_StartTime);
            this.gc_EventDetails.Controls.Add(this.dateEdit_AttendanceDate);
            this.gc_EventDetails.Controls.Add(this.label_EventEndTime);
            this.gc_EventDetails.Controls.Add(this.label_EventStartTime);
            this.gc_EventDetails.Controls.Add(this.label_EventLocation);
            this.gc_EventDetails.Controls.Add(this.label_EventDate);
            this.gc_EventDetails.Controls.Add(this.label_AttendanceLocation);
            this.gc_EventDetails.Controls.Add(this.label_AttendanceName);
            this.gc_EventDetails.Controls.Add(this.txt_AttedanceLocation);
            this.gc_EventDetails.Controls.Add(this.txt_AttendanceName);
            this.gc_EventDetails.Location = new System.Drawing.Point(16, 16);
            this.gc_EventDetails.Name = "gc_EventDetails";
            this.gc_EventDetails.Size = new System.Drawing.Size(526, 488);
            this.gc_EventDetails.TabIndex = 4;
            this.gc_EventDetails.Text = "Edit Attendance";
            // 
            // cbe_LogType
            // 
            this.cbe_LogType.Location = new System.Drawing.Point(266, 291);
            this.cbe_LogType.Name = "cbe_LogType";
            this.cbe_LogType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_LogType.Size = new System.Drawing.Size(243, 34);
            this.cbe_LogType.TabIndex = 21;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_SaveChanges.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_SaveChanges.Appearance.Options.UseBackColor = true;
            this.btn_SaveChanges.Appearance.Options.UseFont = true;
            this.btn_SaveChanges.Location = new System.Drawing.Point(351, 440);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(158, 41);
            this.btn_SaveChanges.TabIndex = 19;
            this.btn_SaveChanges.Text = "Save Changes";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 440);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            // 
            // timeEdit_EndTime
            // 
            this.timeEdit_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_EndTime.Location = new System.Drawing.Point(266, 362);
            this.timeEdit_EndTime.Name = "timeEdit_EndTime";
            this.timeEdit_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_EndTime.Size = new System.Drawing.Size(243, 34);
            this.timeEdit_EndTime.TabIndex = 17;
            // 
            // timeEdit_StartTime
            // 
            this.timeEdit_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_StartTime.Location = new System.Drawing.Point(17, 362);
            this.timeEdit_StartTime.Name = "timeEdit_StartTime";
            this.timeEdit_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_StartTime.Size = new System.Drawing.Size(240, 34);
            this.timeEdit_StartTime.TabIndex = 18;
            // 
            // dateEdit_AttendanceDate
            // 
            this.dateEdit_AttendanceDate.EditValue = null;
            this.dateEdit_AttendanceDate.Location = new System.Drawing.Point(17, 291);
            this.dateEdit_AttendanceDate.Name = "dateEdit_AttendanceDate";
            this.dateEdit_AttendanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Size = new System.Drawing.Size(240, 34);
            this.dateEdit_AttendanceDate.TabIndex = 16;
            // 
            // label_EventEndTime
            // 
            this.label_EventEndTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventEndTime.Appearance.Options.UseFont = true;
            this.label_EventEndTime.Location = new System.Drawing.Point(266, 337);
            this.label_EventEndTime.Name = "label_EventEndTime";
            this.label_EventEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_EventEndTime.TabIndex = 10;
            this.label_EventEndTime.Text = "End Time";
            // 
            // label_EventStartTime
            // 
            this.label_EventStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventStartTime.Appearance.Options.UseFont = true;
            this.label_EventStartTime.Location = new System.Drawing.Point(17, 337);
            this.label_EventStartTime.Name = "label_EventStartTime";
            this.label_EventStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_EventStartTime.TabIndex = 11;
            this.label_EventStartTime.Text = "Start Time";
            // 
            // label_EventLocation
            // 
            this.label_EventLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventLocation.Appearance.Options.UseFont = true;
            this.label_EventLocation.Location = new System.Drawing.Point(266, 266);
            this.label_EventLocation.Name = "label_EventLocation";
            this.label_EventLocation.Size = new System.Drawing.Size(62, 25);
            this.label_EventLocation.TabIndex = 12;
            this.label_EventLocation.Text = "Log Type";
            // 
            // label_EventDate
            // 
            this.label_EventDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventDate.Appearance.Options.UseFont = true;
            this.label_EventDate.Location = new System.Drawing.Point(17, 266);
            this.label_EventDate.Name = "label_EventDate";
            this.label_EventDate.Size = new System.Drawing.Size(34, 25);
            this.label_EventDate.TabIndex = 13;
            this.label_EventDate.Text = "Date";
            // 
            // label_AttendanceLocation
            // 
            this.label_AttendanceLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceLocation.Appearance.Options.UseFont = true;
            this.label_AttendanceLocation.Location = new System.Drawing.Point(17, 116);
            this.label_AttendanceLocation.Name = "label_AttendanceLocation";
            this.label_AttendanceLocation.Size = new System.Drawing.Size(61, 25);
            this.label_AttendanceLocation.TabIndex = 14;
            this.label_AttendanceLocation.Text = "Location";
            // 
            // label_AttendanceName
            // 
            this.label_AttendanceName.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceName.Appearance.Options.UseFont = true;
            this.label_AttendanceName.Location = new System.Drawing.Point(17, 37);
            this.label_AttendanceName.Name = "label_AttendanceName";
            this.label_AttendanceName.Size = new System.Drawing.Size(43, 25);
            this.label_AttendanceName.TabIndex = 15;
            this.label_AttendanceName.Text = "Name";
            // 
            // txt_AttedanceLocation
            // 
            this.txt_AttedanceLocation.Location = new System.Drawing.Point(17, 141);
            this.txt_AttedanceLocation.Name = "txt_AttedanceLocation";
            this.txt_AttedanceLocation.Properties.AutoHeight = false;
            this.txt_AttedanceLocation.Size = new System.Drawing.Size(492, 39);
            this.txt_AttedanceLocation.TabIndex = 7;
            // 
            // txt_AttendanceName
            // 
            this.txt_AttendanceName.Location = new System.Drawing.Point(17, 62);
            this.txt_AttendanceName.Name = "txt_AttendanceName";
            this.txt_AttendanceName.Properties.AutoHeight = false;
            this.txt_AttendanceName.Size = new System.Drawing.Size(492, 34);
            this.txt_AttendanceName.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_EditEvent});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 520);
            this.Root.TextVisible = false;
            // 
            // lci_EditEvent
            // 
            this.lci_EditEvent.Control = this.gc_EventDetails;
            this.lci_EditEvent.Location = new System.Drawing.Point(0, 0);
            this.lci_EditEvent.Name = "lci_EditEvent";
            this.lci_EditEvent.Size = new System.Drawing.Size(532, 494);
            this.lci_EditEvent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_EditEvent.TextVisible = false;
            // 
            // cbe_TimeOfDay
            // 
            this.cbe_TimeOfDay.Location = new System.Drawing.Point(19, 227);
            this.cbe_TimeOfDay.Name = "cbe_TimeOfDay";
            this.cbe_TimeOfDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_TimeOfDay.Properties.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbe_TimeOfDay.Size = new System.Drawing.Size(489, 34);
            this.cbe_TimeOfDay.TabIndex = 22;
            // 
            // label_DayTime
            // 
            this.label_DayTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_DayTime.Appearance.Options.UseFont = true;
            this.label_DayTime.Location = new System.Drawing.Point(17, 196);
            this.label_DayTime.Name = "label_DayTime";
            this.label_DayTime.Size = new System.Drawing.Size(67, 25);
            this.label_DayTime.TabIndex = 23;
            this.label_DayTime.Text = "Day Time";
            // 
            // EditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 520);
            this.Controls.Add(this.lc_EditEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEvent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditEvent)).EndInit();
            this.lc_EditEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).EndInit();
            this.gc_EventDetails.ResumeLayout(false);
            this.gc_EventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttedanceLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EditEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_TimeOfDay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_EditEvent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_EventDetails;
        private DevExpress.XtraLayout.LayoutControlItem lci_EditEvent;
        private DevExpress.XtraEditors.SimpleButton btn_SaveChanges;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TimeEdit timeEdit_EndTime;
        private DevExpress.XtraEditors.TimeEdit timeEdit_StartTime;
        private DevExpress.XtraEditors.DateEdit dateEdit_AttendanceDate;
        private DevExpress.XtraEditors.LabelControl label_EventEndTime;
        private DevExpress.XtraEditors.LabelControl label_EventStartTime;
        private DevExpress.XtraEditors.LabelControl label_EventLocation;
        private DevExpress.XtraEditors.LabelControl label_EventDate;
        private DevExpress.XtraEditors.LabelControl label_AttendanceLocation;
        private DevExpress.XtraEditors.LabelControl label_AttendanceName;
        private DevExpress.XtraEditors.TextEdit txt_AttedanceLocation;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceName;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_LogType;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_TimeOfDay;
        private DevExpress.XtraEditors.LabelControl label_DayTime;
    }
}