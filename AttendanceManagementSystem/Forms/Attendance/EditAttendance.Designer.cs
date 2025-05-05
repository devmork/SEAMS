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
            this.btn_SaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.timeEdit_EndTime = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit_StartTime = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit_AttendanceDate = new DevExpress.XtraEditors.DateEdit();
            this.label_EventEndTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventStartTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventLocation = new DevExpress.XtraEditors.LabelControl();
            this.label_EventDate = new DevExpress.XtraEditors.LabelControl();
            this.label_EventDescription = new DevExpress.XtraEditors.LabelControl();
            this.label_EventTitle = new DevExpress.XtraEditors.LabelControl();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.txt_Title = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_EditEvent = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbe_LogType = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditEvent)).BeginInit();
            this.lc_EditEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).BeginInit();
            this.gc_EventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EditEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_EditEvent
            // 
            this.lc_EditEvent.Controls.Add(this.gc_EventDetails);
            this.lc_EditEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_EditEvent.Location = new System.Drawing.Point(0, 0);
            this.lc_EditEvent.Name = "lc_EditEvent";
            this.lc_EditEvent.Root = this.Root;
            this.lc_EditEvent.Size = new System.Drawing.Size(558, 505);
            this.lc_EditEvent.TabIndex = 0;
            this.lc_EditEvent.Text = "layoutControl1";
            // 
            // gc_EventDetails
            // 
            this.gc_EventDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_EventDetails.AppearanceCaption.Options.UseFont = true;
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
            this.gc_EventDetails.Controls.Add(this.label_EventDescription);
            this.gc_EventDetails.Controls.Add(this.label_EventTitle);
            this.gc_EventDetails.Controls.Add(this.txt_Location);
            this.gc_EventDetails.Controls.Add(this.txt_Title);
            this.gc_EventDetails.Location = new System.Drawing.Point(16, 16);
            this.gc_EventDetails.Name = "gc_EventDetails";
            this.gc_EventDetails.Size = new System.Drawing.Size(526, 473);
            this.gc_EventDetails.TabIndex = 4;
            this.gc_EventDetails.Text = "Edit Attendance";
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_SaveChanges.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_SaveChanges.Appearance.Options.UseBackColor = true;
            this.btn_SaveChanges.Appearance.Options.UseFont = true;
            this.btn_SaveChanges.Location = new System.Drawing.Point(351, 373);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(158, 41);
            this.btn_SaveChanges.TabIndex = 19;
            this.btn_SaveChanges.Text = "Save Changes";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 373);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            // 
            // timeEdit_EndTime
            // 
            this.timeEdit_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_EndTime.Location = new System.Drawing.Point(266, 295);
            this.timeEdit_EndTime.Name = "timeEdit_EndTime";
            this.timeEdit_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_EndTime.Size = new System.Drawing.Size(243, 34);
            this.timeEdit_EndTime.TabIndex = 17;
            // 
            // timeEdit_StartTime
            // 
            this.timeEdit_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_StartTime.Location = new System.Drawing.Point(17, 295);
            this.timeEdit_StartTime.Name = "timeEdit_StartTime";
            this.timeEdit_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_StartTime.Size = new System.Drawing.Size(240, 34);
            this.timeEdit_StartTime.TabIndex = 18;
            // 
            // dateEdit_AttendanceDate
            // 
            this.dateEdit_AttendanceDate.EditValue = null;
            this.dateEdit_AttendanceDate.Location = new System.Drawing.Point(17, 224);
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
            this.label_EventEndTime.Location = new System.Drawing.Point(266, 270);
            this.label_EventEndTime.Name = "label_EventEndTime";
            this.label_EventEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_EventEndTime.TabIndex = 10;
            this.label_EventEndTime.Text = "End Time";
            // 
            // label_EventStartTime
            // 
            this.label_EventStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventStartTime.Appearance.Options.UseFont = true;
            this.label_EventStartTime.Location = new System.Drawing.Point(17, 270);
            this.label_EventStartTime.Name = "label_EventStartTime";
            this.label_EventStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_EventStartTime.TabIndex = 11;
            this.label_EventStartTime.Text = "Start Time";
            // 
            // label_EventLocation
            // 
            this.label_EventLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventLocation.Appearance.Options.UseFont = true;
            this.label_EventLocation.Location = new System.Drawing.Point(266, 199);
            this.label_EventLocation.Name = "label_EventLocation";
            this.label_EventLocation.Size = new System.Drawing.Size(62, 25);
            this.label_EventLocation.TabIndex = 12;
            this.label_EventLocation.Text = "Log Type";
            // 
            // label_EventDate
            // 
            this.label_EventDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventDate.Appearance.Options.UseFont = true;
            this.label_EventDate.Location = new System.Drawing.Point(17, 199);
            this.label_EventDate.Name = "label_EventDate";
            this.label_EventDate.Size = new System.Drawing.Size(34, 25);
            this.label_EventDate.TabIndex = 13;
            this.label_EventDate.Text = "Date";
            // 
            // label_EventDescription
            // 
            this.label_EventDescription.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventDescription.Appearance.Options.UseFont = true;
            this.label_EventDescription.Location = new System.Drawing.Point(17, 116);
            this.label_EventDescription.Name = "label_EventDescription";
            this.label_EventDescription.Size = new System.Drawing.Size(61, 25);
            this.label_EventDescription.TabIndex = 14;
            this.label_EventDescription.Text = "Location";
            // 
            // label_EventTitle
            // 
            this.label_EventTitle.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventTitle.Appearance.Options.UseFont = true;
            this.label_EventTitle.Location = new System.Drawing.Point(17, 37);
            this.label_EventTitle.Name = "label_EventTitle";
            this.label_EventTitle.Size = new System.Drawing.Size(31, 25);
            this.label_EventTitle.TabIndex = 15;
            this.label_EventTitle.Text = "Title";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(17, 141);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Properties.AutoHeight = false;
            this.txt_Location.Size = new System.Drawing.Size(492, 39);
            this.txt_Location.TabIndex = 7;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(17, 62);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Properties.AutoHeight = false;
            this.txt_Title.Size = new System.Drawing.Size(492, 34);
            this.txt_Title.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_EditEvent});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 505);
            this.Root.TextVisible = false;
            // 
            // lci_EditEvent
            // 
            this.lci_EditEvent.Control = this.gc_EventDetails;
            this.lci_EditEvent.Location = new System.Drawing.Point(0, 0);
            this.lci_EditEvent.Name = "lci_EditEvent";
            this.lci_EditEvent.Size = new System.Drawing.Size(532, 479);
            this.lci_EditEvent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_EditEvent.TextVisible = false;
            // 
            // cbe_LogType
            // 
            this.cbe_LogType.Location = new System.Drawing.Point(266, 224);
            this.cbe_LogType.Name = "cbe_LogType";
            this.cbe_LogType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_LogType.Size = new System.Drawing.Size(243, 34);
            this.cbe_LogType.TabIndex = 21;
            // 
            // EditAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 505);
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
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EditEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl label_EventDescription;
        private DevExpress.XtraEditors.LabelControl label_EventTitle;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private DevExpress.XtraEditors.TextEdit txt_Title;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_LogType;
    }
}