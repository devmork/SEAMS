namespace AttendanceManagementSystem.Forms.Events
{
    partial class Attendance_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_UserControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lc_Attendance = new DevExpress.XtraLayout.LayoutControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.btn_AddAttendance = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Attendance = new DevExpress.XtraGrid.GridControl();
            this.gv_Attendance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdclm_AttendanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_AttendanceLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_TimeOfDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_LogType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_AttendanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_StartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdclm_Actions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem_ActionsButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).BeginInit();
            this.lc_Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Attendance
            // 
            this.lc_Attendance.Controls.Add(this.panel_PageHeading);
            this.lc_Attendance.Controls.Add(this.gc_Attendance);
            this.lc_Attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Attendance.Location = new System.Drawing.Point(0, 0);
            this.lc_Attendance.Name = "lc_Attendance";
            this.lc_Attendance.Root = this.Root;
            this.lc_Attendance.Size = new System.Drawing.Size(1038, 768);
            this.lc_Attendance.TabIndex = 0;
            this.lc_Attendance.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.btn_AddAttendance);
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 100);
            this.panel_PageHeading.TabIndex = 7;
            // 
            // btn_AddAttendance
            // 
            this.btn_AddAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAttendance.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddAttendance.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddAttendance.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddAttendance.Appearance.Options.UseBackColor = true;
            this.btn_AddAttendance.Appearance.Options.UseFont = true;
            this.btn_AddAttendance.Appearance.Options.UseForeColor = true;
            this.btn_AddAttendance.Appearance.Options.UseTextOptions = true;
            this.btn_AddAttendance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddAttendance.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddAttendance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddAttendance.ImageOptions.SvgImage")));
            this.btn_AddAttendance.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddAttendance.Location = new System.Drawing.Point(754, 24);
            this.btn_AddAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddAttendance.Name = "btn_AddAttendance";
            this.btn_AddAttendance.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddAttendance.Size = new System.Drawing.Size(235, 52);
            this.btn_AddAttendance.TabIndex = 3;
            this.btn_AddAttendance.Text = "Add Attendance";
            this.btn_AddAttendance.Click += new System.EventHandler(this.btn_AddAttendance_Click);
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 17);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(147, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Attendance";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 53);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(305, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage school attendance.";
            // 
            // gc_Attendance
            // 
            this.gc_Attendance.Location = new System.Drawing.Point(16, 122);
            this.gc_Attendance.MainView = this.gv_Attendance;
            this.gc_Attendance.Name = "gc_Attendance";
            this.gc_Attendance.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem_ActionsButton});
            this.gc_Attendance.Size = new System.Drawing.Size(1006, 630);
            this.gc_Attendance.TabIndex = 8;
            this.gc_Attendance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Attendance});
            // 
            // gv_Attendance
            // 
            this.gv_Attendance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdclm_AttendanceName,
            this.grdclm_AttendanceLocation,
            this.grdclm_TimeOfDay,
            this.grdclm_LogType,
            this.grdclm_AttendanceDate,
            this.grdclm_StartTime,
            this.grdclm_EndTime,
            this.grdclm_Actions});
            this.gv_Attendance.GridControl = this.gc_Attendance;
            this.gv_Attendance.Name = "gv_Attendance";
            this.gv_Attendance.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // grdclm_AttendanceName
            // 
            this.grdclm_AttendanceName.Caption = "Name";
            this.grdclm_AttendanceName.FieldName = "AttendanceName";
            this.grdclm_AttendanceName.Name = "grdclm_AttendanceName";
            this.grdclm_AttendanceName.Visible = true;
            this.grdclm_AttendanceName.VisibleIndex = 0;
            this.grdclm_AttendanceName.Width = 92;
            // 
            // grdclm_AttendanceLocation
            // 
            this.grdclm_AttendanceLocation.Caption = "Location";
            this.grdclm_AttendanceLocation.FieldName = "AttendanceLocation";
            this.grdclm_AttendanceLocation.Name = "grdclm_AttendanceLocation";
            this.grdclm_AttendanceLocation.Visible = true;
            this.grdclm_AttendanceLocation.VisibleIndex = 1;
            this.grdclm_AttendanceLocation.Width = 161;
            // 
            // grdclm_TimeOfDay
            // 
            this.grdclm_TimeOfDay.Caption = "Time of Day";
            this.grdclm_TimeOfDay.FieldName = "TimeOfDay";
            this.grdclm_TimeOfDay.Name = "grdclm_TimeOfDay";
            this.grdclm_TimeOfDay.Visible = true;
            this.grdclm_TimeOfDay.VisibleIndex = 2;
            this.grdclm_TimeOfDay.Width = 106;
            // 
            // grdclm_LogType
            // 
            this.grdclm_LogType.Caption = "Log Type";
            this.grdclm_LogType.FieldName = "LogType";
            this.grdclm_LogType.Name = "grdclm_LogType";
            this.grdclm_LogType.Visible = true;
            this.grdclm_LogType.VisibleIndex = 3;
            this.grdclm_LogType.Width = 107;
            // 
            // grdclm_AttendanceDate
            // 
            this.grdclm_AttendanceDate.Caption = "Date";
            this.grdclm_AttendanceDate.FieldName = "Date";
            this.grdclm_AttendanceDate.Name = "grdclm_AttendanceDate";
            this.grdclm_AttendanceDate.Visible = true;
            this.grdclm_AttendanceDate.VisibleIndex = 4;
            this.grdclm_AttendanceDate.Width = 97;
            // 
            // grdclm_StartTime
            // 
            this.grdclm_StartTime.Caption = "Start Time";
            this.grdclm_StartTime.FieldName = "StartTime";
            this.grdclm_StartTime.Name = "grdclm_StartTime";
            this.grdclm_StartTime.Visible = true;
            this.grdclm_StartTime.VisibleIndex = 5;
            this.grdclm_StartTime.Width = 106;
            // 
            // grdclm_EndTime
            // 
            this.grdclm_EndTime.Caption = "End Time";
            this.grdclm_EndTime.FieldName = "EndTime";
            this.grdclm_EndTime.Name = "grdclm_EndTime";
            this.grdclm_EndTime.Visible = true;
            this.grdclm_EndTime.VisibleIndex = 6;
            this.grdclm_EndTime.Width = 97;
            // 
            // grdclm_Actions
            // 
            this.grdclm_Actions.Caption = "Actions";
            this.grdclm_Actions.ColumnEdit = this.repositoryItem_ActionsButton;
            this.grdclm_Actions.Name = "grdclm_Actions";
            this.grdclm_Actions.Visible = true;
            this.grdclm_Actions.VisibleIndex = 7;
            this.grdclm_Actions.Width = 208;
            // 
            // repositoryItem_ActionsButton
            // 
            this.repositoryItem_ActionsButton.AutoHeight = false;
            editorButtonImageOptions1.ImageUri.Uri = "icon%20builder/actions_edit";
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions2.ImageUri.Uri = "icon%20builder/actions_trash";
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            this.repositoryItem_ActionsButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Edit", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "\"Edit\"", null, DevExpress.Utils.ToolTipAnchor.Default),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "\"Delete\"", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItem_ActionsButton.Name = "repositoryItem_ActionsButton";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelBody});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1038, 768);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 106);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.gc_Attendance;
            this.lci_PanelBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PanelBody.CustomizationFormText = "layoutControlItem2";
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 106);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1012, 636);
            this.lci_PanelBody.Text = "layoutControlItem2";
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // Attendance_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Attendance);
            this.Name = "Attendance_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            this.Load += new System.EventHandler(this.Attendance_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).EndInit();
            this.lc_Attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_ActionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Attendance;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Attendance;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraEditors.SimpleButton btn_AddAttendance;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Attendance;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_StartTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_LogType;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceLocation;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_TimeOfDay;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_AttendanceName;
        private DevExpress.XtraGrid.Columns.GridColumn grdclm_Actions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItem_ActionsButton;
    }
}
