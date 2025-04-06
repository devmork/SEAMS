namespace AttendanceManagementSystem.Forms.Events
{
    partial class EditAttendance_Form
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
            this.lc_EditAttendance = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gc_AttendanceDetails = new DevExpress.XtraEditors.GroupControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_SaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.timeEdit_EndTime = new DevExpress.XtraEditors.TimeEdit();
            this.timeEdit_StartTime = new DevExpress.XtraEditors.TimeEdit();
            this.dateEdit_AttendanceDate = new DevExpress.XtraEditors.DateEdit();
            this.label_AttendanceEndTime = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceStartTime = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceLocation = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceDate = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceDescription = new DevExpress.XtraEditors.LabelControl();
            this.label_AttendanceTitle = new DevExpress.XtraEditors.LabelControl();
            this.txt_AttendanceDescription = new DevExpress.XtraEditors.TextEdit();
            this.txt_AttendanceLocation = new DevExpress.XtraEditors.TextEdit();
            this.txt_AttendanceTitle = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditAttendance)).BeginInit();
            this.lc_EditAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceDetails)).BeginInit();
            this.gc_AttendanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_EditAttendance
            // 
            this.lc_EditAttendance.Controls.Add(this.gc_AttendanceDetails);
            this.lc_EditAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_EditAttendance.Location = new System.Drawing.Point(0, 0);
            this.lc_EditAttendance.Name = "lc_EditAttendance";
            this.lc_EditAttendance.Root = this.Root;
            this.lc_EditAttendance.Size = new System.Drawing.Size(558, 558);
            this.lc_EditAttendance.TabIndex = 0;
            this.lc_EditAttendance.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 558);
            this.Root.TextVisible = false;
            // 
            // gc_AttendanceDetails
            // 
            this.gc_AttendanceDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_AttendanceDetails.AppearanceCaption.Options.UseFont = true;
            this.gc_AttendanceDetails.Controls.Add(this.btn_SaveChanges);
            this.gc_AttendanceDetails.Controls.Add(this.btn_Cancel);
            this.gc_AttendanceDetails.Controls.Add(this.timeEdit_EndTime);
            this.gc_AttendanceDetails.Controls.Add(this.timeEdit_StartTime);
            this.gc_AttendanceDetails.Controls.Add(this.dateEdit_AttendanceDate);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceEndTime);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceStartTime);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceLocation);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceDate);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceDescription);
            this.gc_AttendanceDetails.Controls.Add(this.label_AttendanceTitle);
            this.gc_AttendanceDetails.Controls.Add(this.txt_AttendanceDescription);
            this.gc_AttendanceDetails.Controls.Add(this.txt_AttendanceLocation);
            this.gc_AttendanceDetails.Controls.Add(this.txt_AttendanceTitle);
            this.gc_AttendanceDetails.Location = new System.Drawing.Point(16, 16);
            this.gc_AttendanceDetails.Name = "gc_AttendanceDetails";
            this.gc_AttendanceDetails.Size = new System.Drawing.Size(526, 526);
            this.gc_AttendanceDetails.TabIndex = 4;
            this.gc_AttendanceDetails.Text = "Edit Attendance";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gc_AttendanceDetails;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(532, 532);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_SaveChanges.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_SaveChanges.Appearance.Options.UseBackColor = true;
            this.btn_SaveChanges.Appearance.Options.UseFont = true;
            this.btn_SaveChanges.Location = new System.Drawing.Point(351, 471);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(158, 41);
            this.btn_SaveChanges.TabIndex = 19;
            this.btn_SaveChanges.Text = "Save Changes";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 471);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "Cancel";
            // 
            // timeEdit_EndTime
            // 
            this.timeEdit_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_EndTime.Location = new System.Drawing.Point(269, 407);
            this.timeEdit_EndTime.Name = "timeEdit_EndTime";
            this.timeEdit_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_EndTime.Size = new System.Drawing.Size(243, 34);
            this.timeEdit_EndTime.TabIndex = 17;
            // 
            // timeEdit_StartTime
            // 
            this.timeEdit_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_StartTime.Location = new System.Drawing.Point(20, 407);
            this.timeEdit_StartTime.Name = "timeEdit_StartTime";
            this.timeEdit_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_StartTime.Size = new System.Drawing.Size(240, 34);
            this.timeEdit_StartTime.TabIndex = 18;
            // 
            // dateEdit_AttendanceDate
            // 
            this.dateEdit_AttendanceDate.EditValue = null;
            this.dateEdit_AttendanceDate.Location = new System.Drawing.Point(20, 336);
            this.dateEdit_AttendanceDate.Name = "dateEdit_AttendanceDate";
            this.dateEdit_AttendanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Size = new System.Drawing.Size(240, 34);
            this.dateEdit_AttendanceDate.TabIndex = 16;
            // 
            // label_AttendanceEndTime
            // 
            this.label_AttendanceEndTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceEndTime.Appearance.Options.UseFont = true;
            this.label_AttendanceEndTime.Location = new System.Drawing.Point(269, 382);
            this.label_AttendanceEndTime.Name = "label_AttendanceEndTime";
            this.label_AttendanceEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_AttendanceEndTime.TabIndex = 10;
            this.label_AttendanceEndTime.Text = "End Time";
            // 
            // label_AttendanceStartTime
            // 
            this.label_AttendanceStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceStartTime.Appearance.Options.UseFont = true;
            this.label_AttendanceStartTime.Location = new System.Drawing.Point(20, 382);
            this.label_AttendanceStartTime.Name = "label_AttendanceStartTime";
            this.label_AttendanceStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_AttendanceStartTime.TabIndex = 11;
            this.label_AttendanceStartTime.Text = "Start Time";
            // 
            // label_AttendanceLocation
            // 
            this.label_AttendanceLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceLocation.Appearance.Options.UseFont = true;
            this.label_AttendanceLocation.Location = new System.Drawing.Point(269, 311);
            this.label_AttendanceLocation.Name = "label_AttendanceLocation";
            this.label_AttendanceLocation.Size = new System.Drawing.Size(61, 25);
            this.label_AttendanceLocation.TabIndex = 12;
            this.label_AttendanceLocation.Text = "Location";
            // 
            // label_AttendanceDate
            // 
            this.label_AttendanceDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceDate.Appearance.Options.UseFont = true;
            this.label_AttendanceDate.Location = new System.Drawing.Point(20, 311);
            this.label_AttendanceDate.Name = "label_AttendanceDate";
            this.label_AttendanceDate.Size = new System.Drawing.Size(34, 25);
            this.label_AttendanceDate.TabIndex = 13;
            this.label_AttendanceDate.Text = "Date";
            // 
            // label_AttendanceDescription
            // 
            this.label_AttendanceDescription.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceDescription.Appearance.Options.UseFont = true;
            this.label_AttendanceDescription.Location = new System.Drawing.Point(17, 116);
            this.label_AttendanceDescription.Name = "label_AttendanceDescription";
            this.label_AttendanceDescription.Size = new System.Drawing.Size(83, 25);
            this.label_AttendanceDescription.TabIndex = 14;
            this.label_AttendanceDescription.Text = "Description";
            // 
            // label_AttendanceTitle
            // 
            this.label_AttendanceTitle.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceTitle.Appearance.Options.UseFont = true;
            this.label_AttendanceTitle.Location = new System.Drawing.Point(17, 37);
            this.label_AttendanceTitle.Name = "label_AttendanceTitle";
            this.label_AttendanceTitle.Size = new System.Drawing.Size(31, 25);
            this.label_AttendanceTitle.TabIndex = 15;
            this.label_AttendanceTitle.Text = "Title";
            // 
            // txt_AttendanceDescription
            // 
            this.txt_AttendanceDescription.Location = new System.Drawing.Point(17, 141);
            this.txt_AttendanceDescription.Name = "txt_AttendanceDescription";
            this.txt_AttendanceDescription.Properties.AutoHeight = false;
            this.txt_AttendanceDescription.Size = new System.Drawing.Size(492, 153);
            this.txt_AttendanceDescription.TabIndex = 7;
            // 
            // txt_AttendanceLocation
            // 
            this.txt_AttendanceLocation.Location = new System.Drawing.Point(269, 336);
            this.txt_AttendanceLocation.Name = "txt_AttendanceLocation";
            this.txt_AttendanceLocation.Properties.AutoHeight = false;
            this.txt_AttendanceLocation.Size = new System.Drawing.Size(243, 34);
            this.txt_AttendanceLocation.TabIndex = 8;
            // 
            // txt_AttendanceTitle
            // 
            this.txt_AttendanceTitle.Location = new System.Drawing.Point(17, 62);
            this.txt_AttendanceTitle.Name = "txt_AttendanceTitle";
            this.txt_AttendanceTitle.Properties.AutoHeight = false;
            this.txt_AttendanceTitle.Size = new System.Drawing.Size(492, 34);
            this.txt_AttendanceTitle.TabIndex = 9;
            // 
            // EditAttendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 558);
            this.Controls.Add(this.lc_EditAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAttendance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEvent_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_EditAttendance)).EndInit();
            this.lc_EditAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceDetails)).EndInit();
            this.gc_AttendanceDetails.ResumeLayout(false);
            this.gc_AttendanceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_EditAttendance;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_AttendanceDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btn_SaveChanges;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TimeEdit timeEdit_EndTime;
        private DevExpress.XtraEditors.TimeEdit timeEdit_StartTime;
        private DevExpress.XtraEditors.DateEdit dateEdit_AttendanceDate;
        private DevExpress.XtraEditors.LabelControl label_AttendanceEndTime;
        private DevExpress.XtraEditors.LabelControl label_AttendanceStartTime;
        private DevExpress.XtraEditors.LabelControl label_AttendanceLocation;
        private DevExpress.XtraEditors.LabelControl label_AttendanceDate;
        private DevExpress.XtraEditors.LabelControl label_AttendanceDescription;
        private DevExpress.XtraEditors.LabelControl label_AttendanceTitle;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceDescription;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceLocation;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceTitle;
    }
}