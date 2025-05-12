namespace AttendanceManagementSystem.Forms.Attendance_Report
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
            this.gc_AttendanceRecord = new DevExpress.XtraGrid.GridControl();
            this.gv_AttendanceRecord = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Marked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel_TotalAttendance = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.caption_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.panel_TotalAbsent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalAbsent = new DevExpress.XtraEditors.LabelControl();
            this.caption_Absent = new DevExpress.XtraEditors.LabelControl();
            this.panel_TotalPresent = new DevExpress.XtraEditors.PanelControl();
            this.label_TotalPresent = new DevExpress.XtraEditors.LabelControl();
            this.caption_Present = new DevExpress.XtraEditors.LabelControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalAbsent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalPresent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalAttendance = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_gridControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).BeginInit();
            this.lc_StudentAttendanceRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).BeginInit();
            this.panel_TotalAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).BeginInit();
            this.panel_TotalAbsent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).BeginInit();
            this.panel_TotalPresent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_StudentAttendanceRecord
            // 
            this.lc_StudentAttendanceRecord.Controls.Add(this.gc_AttendanceRecord);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAttendance);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalAbsent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_TotalPresent);
            this.lc_StudentAttendanceRecord.Controls.Add(this.panel_PageHeading);
            this.lc_StudentAttendanceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_StudentAttendanceRecord.Location = new System.Drawing.Point(0, 0);
            this.lc_StudentAttendanceRecord.Name = "lc_StudentAttendanceRecord";
            this.lc_StudentAttendanceRecord.Root = this.Root;
            this.lc_StudentAttendanceRecord.Size = new System.Drawing.Size(778, 543);
            this.lc_StudentAttendanceRecord.TabIndex = 0;
            this.lc_StudentAttendanceRecord.Text = "layoutControl1";
            // 
            // gc_AttendanceRecord
            // 
            this.gc_AttendanceRecord.Location = new System.Drawing.Point(16, 169);
            this.gc_AttendanceRecord.MainView = this.gv_AttendanceRecord;
            this.gc_AttendanceRecord.Name = "gc_AttendanceRecord";
            this.gc_AttendanceRecord.Size = new System.Drawing.Size(746, 358);
            this.gc_AttendanceRecord.TabIndex = 8;
            this.gc_AttendanceRecord.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_AttendanceRecord});
            // 
            // gv_AttendanceRecord
            // 
            this.gv_AttendanceRecord.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_Title,
            this.grdclm_Data,
            this.grdclm_LogType,
            this.grdclm_StartTime,
            this.grdclm_EndTime,
            this.grdclm_Marked});
            this.gv_AttendanceRecord.GridControl = this.gc_AttendanceRecord;
            this.gv_AttendanceRecord.Name = "gv_AttendanceRecord";
            // 
            // grdclm_Title
            // 
            this.grdclm_Title.Caption = "Title";
            this.grdclm_Title.Name = "grdclm_Title";
            this.grdclm_Title.Visible = true;
            this.grdclm_Title.VisibleIndex = 0;
            // 
            // grdclm_Data
            // 
            this.grdclm_Data.Caption = "Date";
            this.grdclm_Data.Name = "grdclm_Data";
            this.grdclm_Data.Visible = true;
            this.grdclm_Data.VisibleIndex = 1;
            // 
            // grdclm_LogType
            // 
            this.grdclm_LogType.Caption = "Log Type";
            this.grdclm_LogType.Name = "grdclm_LogType";
            this.grdclm_LogType.Visible = true;
            this.grdclm_LogType.VisibleIndex = 2;
            // 
            // grdclm_StartTime
            // 
            this.grdclm_StartTime.Caption = "Start Time";
            this.grdclm_StartTime.Name = "grdclm_StartTime";
            this.grdclm_StartTime.Visible = true;
            this.grdclm_StartTime.VisibleIndex = 3;
            // 
            // grdclm_EndTime
            // 
            this.grdclm_EndTime.Caption = "End Time";
            this.grdclm_EndTime.Name = "grdclm_EndTime";
            this.grdclm_EndTime.Visible = true;
            this.grdclm_EndTime.VisibleIndex = 4;
            // 
            // grdclm_Marked
            // 
            this.grdclm_Marked.Caption = "Marked";
            this.grdclm_Marked.Name = "grdclm_Marked";
            this.grdclm_Marked.Visible = true;
            this.grdclm_Marked.VisibleIndex = 5;
            // 
            // panel_TotalAttendance
            // 
            this.panel_TotalAttendance.Controls.Add(this.label_TotalAttendance);
            this.panel_TotalAttendance.Controls.Add(this.caption_TotalAttendance);
            this.panel_TotalAttendance.Location = new System.Drawing.Point(507, 67);
            this.panel_TotalAttendance.Name = "panel_TotalAttendance";
            this.panel_TotalAttendance.Size = new System.Drawing.Size(255, 96);
            this.panel_TotalAttendance.TabIndex = 7;
            // 
            // label_TotalAttendance
            // 
            this.label_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 14.58F);
            this.label_TotalAttendance.Appearance.Options.UseFont = true;
            this.label_TotalAttendance.Location = new System.Drawing.Point(122, 31);
            this.label_TotalAttendance.Name = "label_TotalAttendance";
            this.label_TotalAttendance.Size = new System.Drawing.Size(12, 34);
            this.label_TotalAttendance.TabIndex = 3;
            this.label_TotalAttendance.Text = "6";
            // 
            // caption_TotalAttendance
            // 
            this.caption_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.caption_TotalAttendance.Appearance.Options.UseFont = true;
            this.caption_TotalAttendance.Location = new System.Drawing.Point(68, 66);
            this.caption_TotalAttendance.Name = "caption_TotalAttendance";
            this.caption_TotalAttendance.Size = new System.Drawing.Size(118, 25);
            this.caption_TotalAttendance.TabIndex = 2;
            this.caption_TotalAttendance.Text = "Total Attendance";
            // 
            // panel_TotalAbsent
            // 
            this.panel_TotalAbsent.Controls.Add(this.label_TotalAbsent);
            this.panel_TotalAbsent.Controls.Add(this.caption_Absent);
            this.panel_TotalAbsent.Location = new System.Drawing.Point(251, 67);
            this.panel_TotalAbsent.Name = "panel_TotalAbsent";
            this.panel_TotalAbsent.Size = new System.Drawing.Size(250, 96);
            this.panel_TotalAbsent.TabIndex = 6;
            // 
            // label_TotalAbsent
            // 
            this.label_TotalAbsent.Appearance.Font = new System.Drawing.Font("Poppins", 14.58F);
            this.label_TotalAbsent.Appearance.Options.UseFont = true;
            this.label_TotalAbsent.Location = new System.Drawing.Point(120, 31);
            this.label_TotalAbsent.Name = "label_TotalAbsent";
            this.label_TotalAbsent.Size = new System.Drawing.Size(11, 34);
            this.label_TotalAbsent.TabIndex = 3;
            this.label_TotalAbsent.Text = "3";
            // 
            // caption_Absent
            // 
            this.caption_Absent.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.caption_Absent.Appearance.Options.UseFont = true;
            this.caption_Absent.Location = new System.Drawing.Point(101, 66);
            this.caption_Absent.Name = "caption_Absent";
            this.caption_Absent.Size = new System.Drawing.Size(48, 25);
            this.caption_Absent.TabIndex = 2;
            this.caption_Absent.Text = "Absent";
            // 
            // panel_TotalPresent
            // 
            this.panel_TotalPresent.Controls.Add(this.label_TotalPresent);
            this.panel_TotalPresent.Controls.Add(this.caption_Present);
            this.panel_TotalPresent.Location = new System.Drawing.Point(16, 67);
            this.panel_TotalPresent.Name = "panel_TotalPresent";
            this.panel_TotalPresent.Size = new System.Drawing.Size(229, 96);
            this.panel_TotalPresent.TabIndex = 5;
            // 
            // label_TotalPresent
            // 
            this.label_TotalPresent.Appearance.Font = new System.Drawing.Font("Poppins", 14.58F);
            this.label_TotalPresent.Appearance.Options.UseFont = true;
            this.label_TotalPresent.Location = new System.Drawing.Point(109, 31);
            this.label_TotalPresent.Name = "label_TotalPresent";
            this.label_TotalPresent.Size = new System.Drawing.Size(11, 34);
            this.label_TotalPresent.TabIndex = 2;
            this.label_TotalPresent.Text = "3";
            // 
            // caption_Present
            // 
            this.caption_Present.Appearance.Font = new System.Drawing.Font("Poppins", 10.54F);
            this.caption_Present.Appearance.Options.UseFont = true;
            this.caption_Present.Location = new System.Drawing.Point(88, 66);
            this.caption_Present.Name = "caption_Present";
            this.caption_Present.Size = new System.Drawing.Size(52, 25);
            this.caption_Present.TabIndex = 1;
            this.caption_Present.Text = "Present";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(746, 45);
            this.panel_PageHeading.TabIndex = 4;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(38, 8);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(231, 28);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Student Attendance Record";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_TotalAbsent,
            this.lci_TotalPresent,
            this.lci_TotalAttendance,
            this.lci_gridControl});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(778, 543);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(752, 51);
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_TotalAbsent
            // 
            this.lci_TotalAbsent.Control = this.panel_TotalAbsent;
            this.lci_TotalAbsent.Location = new System.Drawing.Point(235, 51);
            this.lci_TotalAbsent.Name = "lci_TotalAbsent";
            this.lci_TotalAbsent.Size = new System.Drawing.Size(256, 102);
            this.lci_TotalAbsent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalAbsent.TextVisible = false;
            // 
            // lci_TotalPresent
            // 
            this.lci_TotalPresent.Control = this.panel_TotalPresent;
            this.lci_TotalPresent.Location = new System.Drawing.Point(0, 51);
            this.lci_TotalPresent.Name = "lci_TotalPresent";
            this.lci_TotalPresent.Size = new System.Drawing.Size(235, 102);
            this.lci_TotalPresent.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalPresent.TextVisible = false;
            // 
            // lci_TotalAttendance
            // 
            this.lci_TotalAttendance.Control = this.panel_TotalAttendance;
            this.lci_TotalAttendance.Location = new System.Drawing.Point(491, 51);
            this.lci_TotalAttendance.Name = "lci_TotalAttendance";
            this.lci_TotalAttendance.Size = new System.Drawing.Size(261, 102);
            this.lci_TotalAttendance.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalAttendance.TextVisible = false;
            // 
            // lci_gridControl
            // 
            this.lci_gridControl.Control = this.gc_AttendanceRecord;
            this.lci_gridControl.Location = new System.Drawing.Point(0, 153);
            this.lci_gridControl.Name = "lci_gridControl";
            this.lci_gridControl.Size = new System.Drawing.Size(752, 364);
            this.lci_gridControl.TextSize = new System.Drawing.Size(0, 0);
            this.lci_gridControl.TextVisible = false;
            // 
            // StudentAttendanceRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 543);
            this.Controls.Add(this.lc_StudentAttendanceRecord);
            this.Name = "StudentAttendanceRecord_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendanceRecord_Form";
            ((System.ComponentModel.ISupportInitialize)(this.lc_StudentAttendanceRecord)).EndInit();
            this.lc_StudentAttendanceRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_AttendanceRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAttendance)).EndInit();
            this.panel_TotalAttendance.ResumeLayout(false);
            this.panel_TotalAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalAbsent)).EndInit();
            this.panel_TotalAbsent.ResumeLayout(false);
            this.panel_TotalAbsent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalPresent)).EndInit();
            this.panel_TotalPresent.ResumeLayout(false);
            this.panel_TotalPresent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAbsent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalPresent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_gridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_StudentAttendanceRecord;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gc_AttendanceRecord;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_AttendanceRecord;
        private DevExpress.XtraEditors.PanelControl panel_TotalAttendance;
        private DevExpress.XtraEditors.PanelControl panel_TotalAbsent;
        private DevExpress.XtraEditors.PanelControl panel_TotalPresent;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalAbsent;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalPresent;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalAttendance;
        private DevExpress.XtraLayout.LayoutControlItem lci_gridControl;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl caption_TotalAttendance;
        private DevExpress.XtraEditors.LabelControl caption_Absent;
        private DevExpress.XtraEditors.LabelControl caption_Present;
        private DevExpress.XtraEditors.LabelControl label_TotalPresent;
        private DevExpress.XtraEditors.LabelControl label_TotalAttendance;
        private DevExpress.XtraEditors.LabelControl label_TotalAbsent;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Title;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Data;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_LogType;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Marked;
    }
}