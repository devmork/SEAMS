namespace AttendanceManagementSystem.Forms.Events
{
    partial class AddAttendance_Form
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
            this.lc_AddEventForm = new DevExpress.XtraLayout.LayoutControl();
            this.gc_AttendanceDetails = new DevExpress.XtraEditors.GroupControl();
            this.btn_AddAttendance = new DevExpress.XtraEditors.SimpleButton();
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
            this.label_Instruction = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_AttendancDetails = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).BeginInit();
            this.lc_AddEventForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceDetails)).BeginInit();
            this.gc_AttendanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendancDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddEventForm
            // 
            this.lc_AddEventForm.Controls.Add(this.gc_AttendanceDetails);
            this.lc_AddEventForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddEventForm.Location = new System.Drawing.Point(0, 0);
            this.lc_AddEventForm.Name = "lc_AddEventForm";
            this.lc_AddEventForm.Root = this.Root;
            this.lc_AddEventForm.Size = new System.Drawing.Size(558, 558);
            this.lc_AddEventForm.TabIndex = 0;
            this.lc_AddEventForm.Text = "layoutControl1";
            // 
            // gc_AttendanceDetails
            // 
            this.gc_AttendanceDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_AttendanceDetails.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gc_AttendanceDetails.AppearanceCaption.Options.UseFont = true;
            this.gc_AttendanceDetails.Controls.Add(this.btn_AddAttendance);
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
            this.gc_AttendanceDetails.Controls.Add(this.label_Instruction);
            this.gc_AttendanceDetails.Location = new System.Drawing.Point(13, 13);
            this.gc_AttendanceDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gc_AttendanceDetails.Name = "gc_AttendanceDetails";
            this.gc_AttendanceDetails.Size = new System.Drawing.Size(532, 532);
            this.gc_AttendanceDetails.TabIndex = 4;
            this.gc_AttendanceDetails.Text = "Add New Attendance";
            this.gc_AttendanceDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.gc_AttendanceDetails_Paint);
            // 
            // btn_AddAttendance
            // 
            this.btn_AddAttendance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_AddAttendance.Appearance.Options.UseBackColor = true;
            this.btn_AddAttendance.Appearance.Options.UseFont = true;
            this.btn_AddAttendance.Location = new System.Drawing.Point(351, 466);
            this.btn_AddAttendance.Name = "btn_AddAttendance";
            this.btn_AddAttendance.Size = new System.Drawing.Size(158, 41);
            this.btn_AddAttendance.TabIndex = 5;
            this.btn_AddAttendance.Text = "Create Attendance";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(218, 466);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            // 
            // timeEdit_EndTime
            // 
            this.timeEdit_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_EndTime.Location = new System.Drawing.Point(269, 402);
            this.timeEdit_EndTime.Name = "timeEdit_EndTime";
            this.timeEdit_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_EndTime.Size = new System.Drawing.Size(243, 34);
            this.timeEdit_EndTime.TabIndex = 4;
            // 
            // timeEdit_StartTime
            // 
            this.timeEdit_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.timeEdit_StartTime.Location = new System.Drawing.Point(20, 402);
            this.timeEdit_StartTime.Name = "timeEdit_StartTime";
            this.timeEdit_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit_StartTime.Size = new System.Drawing.Size(240, 34);
            this.timeEdit_StartTime.TabIndex = 4;
            // 
            // dateEdit_AttendanceDate
            // 
            this.dateEdit_AttendanceDate.EditValue = null;
            this.dateEdit_AttendanceDate.Location = new System.Drawing.Point(20, 331);
            this.dateEdit_AttendanceDate.Name = "dateEdit_AttendanceDate";
            this.dateEdit_AttendanceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_AttendanceDate.Size = new System.Drawing.Size(240, 34);
            this.dateEdit_AttendanceDate.TabIndex = 3;
            // 
            // label_AttendanceEndTime
            // 
            this.label_AttendanceEndTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceEndTime.Appearance.Options.UseFont = true;
            this.label_AttendanceEndTime.Location = new System.Drawing.Point(269, 371);
            this.label_AttendanceEndTime.Name = "label_AttendanceEndTime";
            this.label_AttendanceEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_AttendanceEndTime.TabIndex = 2;
            this.label_AttendanceEndTime.Text = "End Time";
            // 
            // label_AttendanceStartTime
            // 
            this.label_AttendanceStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceStartTime.Appearance.Options.UseFont = true;
            this.label_AttendanceStartTime.Location = new System.Drawing.Point(20, 371);
            this.label_AttendanceStartTime.Name = "label_AttendanceStartTime";
            this.label_AttendanceStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_AttendanceStartTime.TabIndex = 2;
            this.label_AttendanceStartTime.Text = "Start Time";
            // 
            // label_AttendanceLocation
            // 
            this.label_AttendanceLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceLocation.Appearance.Options.UseFont = true;
            this.label_AttendanceLocation.Location = new System.Drawing.Point(269, 300);
            this.label_AttendanceLocation.Name = "label_AttendanceLocation";
            this.label_AttendanceLocation.Size = new System.Drawing.Size(61, 25);
            this.label_AttendanceLocation.TabIndex = 2;
            this.label_AttendanceLocation.Text = "Location";
            // 
            // label_AttendanceDate
            // 
            this.label_AttendanceDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceDate.Appearance.Options.UseFont = true;
            this.label_AttendanceDate.Location = new System.Drawing.Point(20, 300);
            this.label_AttendanceDate.Name = "label_AttendanceDate";
            this.label_AttendanceDate.Size = new System.Drawing.Size(34, 25);
            this.label_AttendanceDate.TabIndex = 2;
            this.label_AttendanceDate.Text = "Date";
            // 
            // label_AttendanceDescription
            // 
            this.label_AttendanceDescription.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceDescription.Appearance.Options.UseFont = true;
            this.label_AttendanceDescription.Location = new System.Drawing.Point(20, 161);
            this.label_AttendanceDescription.Name = "label_AttendanceDescription";
            this.label_AttendanceDescription.Size = new System.Drawing.Size(83, 25);
            this.label_AttendanceDescription.TabIndex = 2;
            this.label_AttendanceDescription.Text = "Description";
            // 
            // label_AttendanceTitle
            // 
            this.label_AttendanceTitle.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_AttendanceTitle.Appearance.Options.UseFont = true;
            this.label_AttendanceTitle.Location = new System.Drawing.Point(20, 82);
            this.label_AttendanceTitle.Name = "label_AttendanceTitle";
            this.label_AttendanceTitle.Size = new System.Drawing.Size(31, 25);
            this.label_AttendanceTitle.TabIndex = 2;
            this.label_AttendanceTitle.Text = "Title";
            // 
            // txt_AttendanceDescription
            // 
            this.txt_AttendanceDescription.Location = new System.Drawing.Point(20, 192);
            this.txt_AttendanceDescription.Name = "txt_AttendanceDescription";
            this.txt_AttendanceDescription.Properties.AutoHeight = false;
            this.txt_AttendanceDescription.Size = new System.Drawing.Size(492, 99);
            this.txt_AttendanceDescription.TabIndex = 1;
            // 
            // txt_AttendanceLocation
            // 
            this.txt_AttendanceLocation.Location = new System.Drawing.Point(269, 331);
            this.txt_AttendanceLocation.Name = "txt_AttendanceLocation";
            this.txt_AttendanceLocation.Properties.AutoHeight = false;
            this.txt_AttendanceLocation.Size = new System.Drawing.Size(243, 34);
            this.txt_AttendanceLocation.TabIndex = 1;
            // 
            // txt_AttendanceTitle
            // 
            this.txt_AttendanceTitle.Location = new System.Drawing.Point(20, 113);
            this.txt_AttendanceTitle.Name = "txt_AttendanceTitle";
            this.txt_AttendanceTitle.Properties.AutoHeight = false;
            this.txt_AttendanceTitle.Size = new System.Drawing.Size(492, 34);
            this.txt_AttendanceTitle.TabIndex = 1;
            // 
            // label_Instruction
            // 
            this.label_Instruction.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.label_Instruction.Appearance.Options.UseFont = true;
            this.label_Instruction.Location = new System.Drawing.Point(20, 38);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(348, 25);
            this.label_Instruction.TabIndex = 0;
            this.label_Instruction.Text = "Fill in the details below to create a new attendance.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_AttendancDetails});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 558);
            this.Root.TextVisible = false;
            // 
            // lci_AttendancDetails
            // 
            this.lci_AttendancDetails.Control = this.gc_AttendanceDetails;
            this.lci_AttendancDetails.Location = new System.Drawing.Point(0, 0);
            this.lci_AttendancDetails.Name = "lci_AttendancDetails";
            this.lci_AttendancDetails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lci_AttendancDetails.Size = new System.Drawing.Size(532, 532);
            this.lci_AttendancDetails.TextSize = new System.Drawing.Size(0, 0);
            this.lci_AttendancDetails.TextVisible = false;
            // 
            // AddAttendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 558);
            this.Controls.Add(this.lc_AddEventForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).EndInit();
            this.lc_AddEventForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceDetails)).EndInit();
            this.gc_AttendanceDetails.ResumeLayout(false);
            this.gc_AttendanceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_AttendanceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AttendanceTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AttendancDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddEventForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_AttendanceDetails;
        private DevExpress.XtraLayout.LayoutControlItem lci_AttendancDetails;
        private DevExpress.XtraEditors.LabelControl label_Instruction;
        private DevExpress.XtraEditors.TextEdit txt_AttendanceTitle;
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
        private DevExpress.XtraEditors.SimpleButton btn_AddAttendance;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}