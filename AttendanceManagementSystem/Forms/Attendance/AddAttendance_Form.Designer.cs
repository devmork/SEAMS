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
            this.gc_EventDetails = new DevExpress.XtraEditors.GroupControl();
            this.cbe_LogType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_CreateEvent = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.te_EndTime = new DevExpress.XtraEditors.TimeEdit();
            this.te_StartTime = new DevExpress.XtraEditors.TimeEdit();
            this.de_Date = new DevExpress.XtraEditors.DateEdit();
            this.label_EventEndTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventStartTime = new DevExpress.XtraEditors.LabelControl();
            this.label_EventLocation = new DevExpress.XtraEditors.LabelControl();
            this.label_EventDate = new DevExpress.XtraEditors.LabelControl();
            this.label_EventName = new DevExpress.XtraEditors.LabelControl();
            this.txt_Location = new DevExpress.XtraEditors.TextEdit();
            this.txt_Title = new DevExpress.XtraEditors.TextEdit();
            this.label_Instruction = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_EventDetails = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).BeginInit();
            this.lc_AddEventForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).BeginInit();
            this.gc_EventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_AddEventForm
            // 
            this.lc_AddEventForm.Controls.Add(this.gc_EventDetails);
            this.lc_AddEventForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_AddEventForm.Location = new System.Drawing.Point(0, 0);
            this.lc_AddEventForm.Name = "lc_AddEventForm";
            this.lc_AddEventForm.Root = this.Root;
            this.lc_AddEventForm.Size = new System.Drawing.Size(558, 600);
            this.lc_AddEventForm.TabIndex = 0;
            this.lc_AddEventForm.Text = "layoutControl1";
            // 
            // gc_EventDetails
            // 
            this.gc_EventDetails.AppearanceCaption.Font = new System.Drawing.Font("Poppins", 12.8F, System.Drawing.FontStyle.Bold);
            this.gc_EventDetails.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gc_EventDetails.AppearanceCaption.Options.UseFont = true;
            this.gc_EventDetails.Controls.Add(this.comboBoxEdit1);
            this.gc_EventDetails.Controls.Add(this.labelControl3);
            this.gc_EventDetails.Controls.Add(this.labelControl2);
            this.gc_EventDetails.Controls.Add(this.textEdit1);
            this.gc_EventDetails.Controls.Add(this.cbe_LogType);
            this.gc_EventDetails.Controls.Add(this.labelControl1);
            this.gc_EventDetails.Controls.Add(this.btn_CreateEvent);
            this.gc_EventDetails.Controls.Add(this.btn_Cancel);
            this.gc_EventDetails.Controls.Add(this.te_EndTime);
            this.gc_EventDetails.Controls.Add(this.te_StartTime);
            this.gc_EventDetails.Controls.Add(this.de_Date);
            this.gc_EventDetails.Controls.Add(this.label_EventEndTime);
            this.gc_EventDetails.Controls.Add(this.label_EventStartTime);
            this.gc_EventDetails.Controls.Add(this.label_EventLocation);
            this.gc_EventDetails.Controls.Add(this.label_EventDate);
            this.gc_EventDetails.Controls.Add(this.label_EventName);
            this.gc_EventDetails.Controls.Add(this.txt_Location);
            this.gc_EventDetails.Controls.Add(this.txt_Title);
            this.gc_EventDetails.Controls.Add(this.label_Instruction);
            this.gc_EventDetails.Location = new System.Drawing.Point(13, 13);
            this.gc_EventDetails.Margin = new System.Windows.Forms.Padding(0);
            this.gc_EventDetails.Name = "gc_EventDetails";
            this.gc_EventDetails.Size = new System.Drawing.Size(532, 574);
            this.gc_EventDetails.TabIndex = 4;
            this.gc_EventDetails.Text = "Create New Attendance";
            // 
            // cbe_LogType
            // 
            this.cbe_LogType.Location = new System.Drawing.Point(269, 398);
            this.cbe_LogType.Name = "cbe_LogType";
            this.cbe_LogType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_LogType.Properties.Items.AddRange(new object[] {
            "Sign In",
            "Sign Out"});
            this.cbe_LogType.Size = new System.Drawing.Size(243, 34);
            this.cbe_LogType.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(269, 367);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 25);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Log Type";
            // 
            // btn_CreateEvent
            // 
            this.btn_CreateEvent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_CreateEvent.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_CreateEvent.Appearance.Options.UseBackColor = true;
            this.btn_CreateEvent.Appearance.Options.UseFont = true;
            this.btn_CreateEvent.Location = new System.Drawing.Point(324, 521);
            this.btn_CreateEvent.Name = "btn_CreateEvent";
            this.btn_CreateEvent.Size = new System.Drawing.Size(185, 41);
            this.btn_CreateEvent.TabIndex = 5;
            this.btn_CreateEvent.Text = "Create Attendance";
            this.btn_CreateEvent.Click += new System.EventHandler(this.btn_CreateEvent_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 9.25F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(191, 521);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 41);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // te_EndTime
            // 
            this.te_EndTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.te_EndTime.Location = new System.Drawing.Point(269, 469);
            this.te_EndTime.Name = "te_EndTime";
            this.te_EndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_EndTime.Size = new System.Drawing.Size(243, 34);
            this.te_EndTime.TabIndex = 4;
            // 
            // te_StartTime
            // 
            this.te_StartTime.EditValue = new System.DateTime(2025, 4, 6, 0, 0, 0, 0);
            this.te_StartTime.Location = new System.Drawing.Point(20, 469);
            this.te_StartTime.Name = "te_StartTime";
            this.te_StartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.te_StartTime.Size = new System.Drawing.Size(240, 34);
            this.te_StartTime.TabIndex = 4;
            // 
            // de_Date
            // 
            this.de_Date.EditValue = null;
            this.de_Date.Location = new System.Drawing.Point(20, 398);
            this.de_Date.Name = "de_Date";
            this.de_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Date.Size = new System.Drawing.Size(240, 34);
            this.de_Date.TabIndex = 3;
            // 
            // label_EventEndTime
            // 
            this.label_EventEndTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventEndTime.Appearance.Options.UseFont = true;
            this.label_EventEndTime.Location = new System.Drawing.Point(269, 438);
            this.label_EventEndTime.Name = "label_EventEndTime";
            this.label_EventEndTime.Size = new System.Drawing.Size(64, 25);
            this.label_EventEndTime.TabIndex = 2;
            this.label_EventEndTime.Text = "End Time";
            // 
            // label_EventStartTime
            // 
            this.label_EventStartTime.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventStartTime.Appearance.Options.UseFont = true;
            this.label_EventStartTime.Location = new System.Drawing.Point(20, 438);
            this.label_EventStartTime.Name = "label_EventStartTime";
            this.label_EventStartTime.Size = new System.Drawing.Size(74, 25);
            this.label_EventStartTime.TabIndex = 2;
            this.label_EventStartTime.Text = "Start Time";
            // 
            // label_EventLocation
            // 
            this.label_EventLocation.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventLocation.Appearance.Options.UseFont = true;
            this.label_EventLocation.Location = new System.Drawing.Point(20, 144);
            this.label_EventLocation.Name = "label_EventLocation";
            this.label_EventLocation.Size = new System.Drawing.Size(104, 25);
            this.label_EventLocation.TabIndex = 2;
            this.label_EventLocation.Text = "Event Location";
            // 
            // label_EventDate
            // 
            this.label_EventDate.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventDate.Appearance.Options.UseFont = true;
            this.label_EventDate.Location = new System.Drawing.Point(20, 367);
            this.label_EventDate.Name = "label_EventDate";
            this.label_EventDate.Size = new System.Drawing.Size(34, 25);
            this.label_EventDate.TabIndex = 2;
            this.label_EventDate.Text = "Date";
            // 
            // label_EventName
            // 
            this.label_EventName.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.label_EventName.Appearance.Options.UseFont = true;
            this.label_EventName.Location = new System.Drawing.Point(20, 70);
            this.label_EventName.Name = "label_EventName";
            this.label_EventName.Size = new System.Drawing.Size(86, 25);
            this.label_EventName.TabIndex = 2;
            this.label_EventName.Text = "Event Name";
            // 
            // txt_Location
            // 
            this.txt_Location.Location = new System.Drawing.Point(20, 175);
            this.txt_Location.Name = "txt_Location";
            this.txt_Location.Properties.AutoHeight = false;
            this.txt_Location.Size = new System.Drawing.Size(492, 37);
            this.txt_Location.TabIndex = 1;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(20, 101);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Properties.AutoHeight = false;
            this.txt_Title.Size = new System.Drawing.Size(492, 34);
            this.txt_Title.TabIndex = 1;
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
            this.lci_EventDetails});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(558, 600);
            this.Root.TextVisible = false;
            // 
            // lci_EventDetails
            // 
            this.lci_EventDetails.Control = this.gc_EventDetails;
            this.lci_EventDetails.Location = new System.Drawing.Point(0, 0);
            this.lci_EventDetails.Name = "lci_EventDetails";
            this.lci_EventDetails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lci_EventDetails.Size = new System.Drawing.Size(532, 574);
            this.lci_EventDetails.TextSize = new System.Drawing.Size(0, 0);
            this.lci_EventDetails.TextVisible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 220);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(149, 25);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Attendance Location";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(20, 251);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Size = new System.Drawing.Size(492, 37);
            this.textEdit1.TabIndex = 8;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(20, 327);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(489, 34);
            this.comboBoxEdit1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 10.54F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 296);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 25);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Day Time";
            // 
            // AddAttendance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 600);
            this.Controls.Add(this.lc_AddEventForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendance_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.lc_AddEventForm)).EndInit();
            this.lc_AddEventForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_EventDetails)).EndInit();
            this.gc_EventDetails.ResumeLayout(false);
            this.gc_EventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_LogType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Title.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_AddEventForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl gc_EventDetails;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventDetails;
        private DevExpress.XtraEditors.LabelControl label_Instruction;
        private DevExpress.XtraEditors.TextEdit txt_Title;
        private DevExpress.XtraEditors.TimeEdit te_EndTime;
        private DevExpress.XtraEditors.TimeEdit te_StartTime;
        private DevExpress.XtraEditors.DateEdit de_Date;
        private DevExpress.XtraEditors.LabelControl label_EventEndTime;
        private DevExpress.XtraEditors.LabelControl label_EventStartTime;
        private DevExpress.XtraEditors.LabelControl label_EventLocation;
        private DevExpress.XtraEditors.LabelControl label_EventDate;
        private DevExpress.XtraEditors.LabelControl label_EventName;
        private DevExpress.XtraEditors.TextEdit txt_Location;
        private DevExpress.XtraEditors.SimpleButton btn_CreateEvent;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_LogType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}