namespace AttendanceManagementSystem.Forms.Attendance
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
            this.lc_Attendance = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddEvent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Attendance = new DevExpress.XtraGrid.GridControl();
            this.cv_Attendance = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gc_AttendanceTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_AttendanceDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_AttendanceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_AttendanceStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_AttendanceEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_AttendanceLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).BeginInit();
            this.lc_Attendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Attendance)).BeginInit();
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
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddEvent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 99);
            this.panel_PageHeading.TabIndex = 7;
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
            // btn_AddEvent
            // 
            this.btn_AddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddEvent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddEvent.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddEvent.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddEvent.Appearance.Options.UseBackColor = true;
            this.btn_AddEvent.Appearance.Options.UseFont = true;
            this.btn_AddEvent.Appearance.Options.UseForeColor = true;
            this.btn_AddEvent.Appearance.Options.UseTextOptions = true;
            this.btn_AddEvent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddEvent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddEvent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AddEvent.ImageOptions.SvgImage")));
            this.btn_AddEvent.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddEvent.Location = new System.Drawing.Point(759, 25);
            this.btn_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddEvent.Size = new System.Drawing.Size(235, 49);
            this.btn_AddEvent.TabIndex = 2;
            this.btn_AddEvent.Text = "Add Attendance";
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
            this.label_PageDescription.Size = new System.Drawing.Size(225, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "Manage school attendance.";
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 105);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // gc_Attendance
            // 
            this.gc_Attendance.Location = new System.Drawing.Point(16, 121);
            this.gc_Attendance.MainView = this.cv_Attendance;
            this.gc_Attendance.Name = "gc_Attendance";
            this.gc_Attendance.Size = new System.Drawing.Size(1006, 631);
            this.gc_Attendance.TabIndex = 8;
            this.gc_Attendance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cv_Attendance});
            // 
            // cv_Attendance
            // 
            this.cv_Attendance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_AttendanceTitle,
            this.gc_AttendanceDescription,
            this.gc_AttendanceDate,
            this.gc_AttendanceStart,
            this.gc_AttendanceEnd,
            this.gc_AttendanceLocation});
            this.cv_Attendance.GridControl = this.gc_Attendance;
            this.cv_Attendance.Name = "cv_Attendance";
            this.cv_Attendance.OptionsBehavior.FieldAutoHeight = true;
            this.cv_Attendance.OptionsView.ShowLines = false;
            // 
            // gc_AttendanceTitle
            // 
            this.gc_AttendanceTitle.Caption = "Title:";
            this.gc_AttendanceTitle.Name = "gc_AttendanceTitle";
            this.gc_AttendanceTitle.Visible = true;
            this.gc_AttendanceTitle.VisibleIndex = 0;
            // 
            // gc_AttendanceDescription
            // 
            this.gc_AttendanceDescription.Caption = "Description:";
            this.gc_AttendanceDescription.Name = "gc_AttendanceDescription";
            this.gc_AttendanceDescription.Visible = true;
            this.gc_AttendanceDescription.VisibleIndex = 5;
            // 
            // gc_AttendanceDate
            // 
            this.gc_AttendanceDate.Caption = "Date:";
            this.gc_AttendanceDate.Name = "gc_AttendanceDate";
            this.gc_AttendanceDate.Visible = true;
            this.gc_AttendanceDate.VisibleIndex = 1;
            // 
            // gc_AttendanceStart
            // 
            this.gc_AttendanceStart.Caption = "Start Time:";
            this.gc_AttendanceStart.Name = "gc_AttendanceStart";
            this.gc_AttendanceStart.Visible = true;
            this.gc_AttendanceStart.VisibleIndex = 2;
            // 
            // gc_AttendanceEnd
            // 
            this.gc_AttendanceEnd.Caption = "End Time:";
            this.gc_AttendanceEnd.Name = "gc_AttendanceEnd";
            this.gc_AttendanceEnd.Visible = true;
            this.gc_AttendanceEnd.VisibleIndex = 3;
            // 
            // gc_AttendanceLocation
            // 
            this.gc_AttendanceLocation.Caption = "Location";
            this.gc_AttendanceLocation.Name = "gc_AttendanceLocation";
            this.gc_AttendanceLocation.Visible = true;
            this.gc_AttendanceLocation.VisibleIndex = 4;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.gc_Attendance;
            this.lci_PanelBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PanelBody.CustomizationFormText = "layoutControlItem2";
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 105);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1012, 637);
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
            ((System.ComponentModel.ISupportInitialize)(this.lc_Attendance)).EndInit();
            this.lc_Attendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Attendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Attendance;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.SimpleButton btn_AddEvent;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Attendance;
        private DevExpress.XtraGrid.Views.Card.CardView cv_Attendance;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceTitle;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceStart;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gc_AttendanceLocation;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
    }
}
