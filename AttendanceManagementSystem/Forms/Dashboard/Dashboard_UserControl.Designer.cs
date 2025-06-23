namespace AttendanceManagementSystem.Forms.Dashboard
{
    partial class Dashboard_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_UserControl));
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint17 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint18 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(15D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint19 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(20D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint20 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(25D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView5 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.lc_Dashboard = new DevExpress.XtraLayout.LayoutControl();
            this.panel_TotalStudents = new DevExpress.XtraEditors.PanelControl();
            this.icon_Students = new DevExpress.XtraEditors.PictureEdit();
            this.txt_TotalStudents = new DevExpress.XtraEditors.LabelControl();
            this.label_TotalStudents = new DevExpress.XtraEditors.LabelControl();
            this.panel_BarGraph = new DevExpress.XtraEditors.PanelControl();
            this.chartControl_AttendaceSummary = new DevExpress.XtraCharts.ChartControl();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            this.icon_Calendar = new DevExpress.XtraEditors.PictureEdit();
            this.txt_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.label_TotalAttendance = new DevExpress.XtraEditors.LabelControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_ChartControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TotalStudents = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbe_FilterCourse = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).BeginInit();
            this.lc_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalStudents)).BeginInit();
            this.panel_TotalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Students.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_BarGraph)).BeginInit();
            this.panel_BarGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_AttendaceSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Calendar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Dashboard
            // 
            this.lc_Dashboard.Controls.Add(this.panelControl1);
            this.lc_Dashboard.Controls.Add(this.panel_TotalStudents);
            this.lc_Dashboard.Controls.Add(this.panel_BarGraph);
            this.lc_Dashboard.Controls.Add(this.panel_Body);
            this.lc_Dashboard.Controls.Add(this.panel_PageHeading);
            this.lc_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.lc_Dashboard.Name = "lc_Dashboard";
            this.lc_Dashboard.Root = this.Root;
            this.lc_Dashboard.Size = new System.Drawing.Size(1440, 1024);
            this.lc_Dashboard.TabIndex = 0;
            this.lc_Dashboard.Text = "layoutControl1";
            // 
            // panel_TotalStudents
            // 
            this.panel_TotalStudents.Controls.Add(this.icon_Students);
            this.panel_TotalStudents.Controls.Add(this.txt_TotalStudents);
            this.panel_TotalStudents.Controls.Add(this.label_TotalStudents);
            this.panel_TotalStudents.Location = new System.Drawing.Point(723, 126);
            this.panel_TotalStudents.Name = "panel_TotalStudents";
            this.panel_TotalStudents.Size = new System.Drawing.Size(701, 154);
            this.panel_TotalStudents.TabIndex = 6;
            // 
            // icon_Students
            // 
            this.icon_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_Students.EditValue = ((object)(resources.GetObject("icon_Students.EditValue")));
            this.icon_Students.Location = new System.Drawing.Point(577, 48);
            this.icon_Students.Name = "icon_Students";
            this.icon_Students.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Students.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.icon_Students.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Students.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Students.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Students.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Students.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Students.Size = new System.Drawing.Size(80, 80);
            this.icon_Students.TabIndex = 21;
            // 
            // txt_TotalStudents
            // 
            this.txt_TotalStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TotalStudents.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 36.62F);
            this.txt_TotalStudents.Appearance.Options.UseFont = true;
            this.txt_TotalStudents.Location = new System.Drawing.Point(30, 51);
            this.txt_TotalStudents.Name = "txt_TotalStudents";
            this.txt_TotalStudents.Size = new System.Drawing.Size(31, 87);
            this.txt_TotalStudents.TabIndex = 1;
            this.txt_TotalStudents.Text = "0";
            // 
            // label_TotalStudents
            // 
            this.label_TotalStudents.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.label_TotalStudents.Appearance.Options.UseFont = true;
            this.label_TotalStudents.Location = new System.Drawing.Point(30, 16);
            this.label_TotalStudents.Name = "label_TotalStudents";
            this.label_TotalStudents.Size = new System.Drawing.Size(146, 36);
            this.label_TotalStudents.TabIndex = 0;
            this.label_TotalStudents.Text = "Total Students";
            // 
            // panel_BarGraph
            // 
            this.panel_BarGraph.Controls.Add(this.chartControl_AttendaceSummary);
            this.panel_BarGraph.Location = new System.Drawing.Point(16, 369);
            this.panel_BarGraph.Name = "panel_BarGraph";
            this.panel_BarGraph.Size = new System.Drawing.Size(1408, 639);
            this.panel_BarGraph.TabIndex = 0;
            // 
            // chartControl_AttendaceSummary
            // 
            xyDiagram5.AxisX.MinorCount = 1;
            xyDiagram5.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram5.AxisX.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Custom;
            xyDiagram5.AxisX.NumericScaleOptions.GridAlignmentStartPoint = DevExpress.XtraCharts.NumericStartPoint.MinRangeValue;
            xyDiagram5.AxisX.NumericScaleOptions.MinGridSpacingLength = 1;
            xyDiagram5.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual;
            xyDiagram5.AxisX.Title.Text = "Year Level";
            xyDiagram5.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisX.WholeRange.Auto = false;
            xyDiagram5.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram5.AxisX.WholeRange.EndSideMargin = 1D;
            xyDiagram5.AxisX.WholeRange.MaxValueSerializable = "4";
            xyDiagram5.AxisX.WholeRange.MinValueSerializable = "1";
            xyDiagram5.AxisX.WholeRange.StartSideMargin = 1D;
            xyDiagram5.AxisY.MinorCount = 4;
            xyDiagram5.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram5.AxisY.NumericScaleOptions.GridSpacing = 2D;
            xyDiagram5.AxisY.Title.Text = "Present Count";
            xyDiagram5.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl_AttendaceSummary.Diagram = xyDiagram5;
            this.chartControl_AttendaceSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl_AttendaceSummary.Legend.LegendID = -1;
            this.chartControl_AttendaceSummary.Location = new System.Drawing.Point(2, 2);
            this.chartControl_AttendaceSummary.Name = "chartControl_AttendaceSummary";
            series5.Name = "AttendanceSummary";
            series5.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint17,
            seriesPoint18,
            seriesPoint19,
            seriesPoint20});
            series5.SeriesID = 0;
            sideBySideBarSeriesView5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            series5.View = sideBySideBarSeriesView5;
            this.chartControl_AttendaceSummary.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl_AttendaceSummary.Size = new System.Drawing.Size(1404, 635);
            this.chartControl_AttendaceSummary.TabIndex = 0;
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.icon_Calendar);
            this.panel_Body.Controls.Add(this.txt_TotalAttendance);
            this.panel_Body.Controls.Add(this.label_TotalAttendance);
            this.panel_Body.Location = new System.Drawing.Point(16, 126);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(701, 154);
            this.panel_Body.TabIndex = 5;
            // 
            // icon_Calendar
            // 
            this.icon_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_Calendar.EditValue = ((object)(resources.GetObject("icon_Calendar.EditValue")));
            this.icon_Calendar.Location = new System.Drawing.Point(577, 48);
            this.icon_Calendar.Name = "icon_Calendar";
            this.icon_Calendar.Properties.AllowZoom = DevExpress.Utils.DefaultBoolean.True;
            this.icon_Calendar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.icon_Calendar.Properties.Appearance.Options.UseBackColor = true;
            this.icon_Calendar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.icon_Calendar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.icon_Calendar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.icon_Calendar.Properties.SvgImageSize = new System.Drawing.Size(14, 14);
            this.icon_Calendar.Size = new System.Drawing.Size(80, 80);
            this.icon_Calendar.TabIndex = 20;
            // 
            // txt_TotalAttendance
            // 
            this.txt_TotalAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 36.62F);
            this.txt_TotalAttendance.Appearance.Options.UseFont = true;
            this.txt_TotalAttendance.Location = new System.Drawing.Point(31, 51);
            this.txt_TotalAttendance.Name = "txt_TotalAttendance";
            this.txt_TotalAttendance.Size = new System.Drawing.Size(31, 87);
            this.txt_TotalAttendance.TabIndex = 1;
            this.txt_TotalAttendance.Text = "0";
            // 
            // label_TotalAttendance
            // 
            this.label_TotalAttendance.Appearance.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalAttendance.Appearance.Options.UseFont = true;
            this.label_TotalAttendance.Location = new System.Drawing.Point(31, 16);
            this.label_TotalAttendance.Name = "label_TotalAttendance";
            this.label_TotalAttendance.Size = new System.Drawing.Size(175, 36);
            this.label_TotalAttendance.TabIndex = 0;
            this.label_TotalAttendance.Text = "Total Attendance";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1408, 104);
            this.panel_PageHeading.TabIndex = 4;
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(31, 22);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(136, 42);
            this.label_PageTitle.TabIndex = 2;
            this.label_PageTitle.Text = "Dashboard";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(31, 59);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(300, 28);
            this.label_PageDescription.TabIndex = 3;
            this.label_PageDescription.Text = "Overview of school event attendance.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_PanelBody,
            this.lci_ChartControl,
            this.lci_TotalStudents,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1440, 1024);
            this.Root.TextVisible = false;
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1414, 110);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.panel_Body;
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 110);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(707, 160);
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // lci_ChartControl
            // 
            this.lci_ChartControl.Control = this.panel_BarGraph;
            this.lci_ChartControl.Location = new System.Drawing.Point(0, 353);
            this.lci_ChartControl.Name = "lci_ChartControl";
            this.lci_ChartControl.Size = new System.Drawing.Size(1414, 645);
            this.lci_ChartControl.TextSize = new System.Drawing.Size(0, 0);
            this.lci_ChartControl.TextVisible = false;
            // 
            // lci_TotalStudents
            // 
            this.lci_TotalStudents.Control = this.panel_TotalStudents;
            this.lci_TotalStudents.Location = new System.Drawing.Point(707, 110);
            this.lci_TotalStudents.Name = "lci_TotalStudents";
            this.lci_TotalStudents.Size = new System.Drawing.Size(707, 160);
            this.lci_TotalStudents.TextSize = new System.Drawing.Size(0, 0);
            this.lci_TotalStudents.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 270);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1414, 83);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbe_FilterCourse);
            this.panelControl1.Location = new System.Drawing.Point(16, 286);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1408, 77);
            this.panelControl1.TabIndex = 1;
            // 
            // cbe_FilterCourse
            // 
            this.cbe_FilterCourse.EditValue = "Filter by Course";
            this.cbe_FilterCourse.Location = new System.Drawing.Point(46, 16);
            this.cbe_FilterCourse.Name = "cbe_FilterCourse";
            this.cbe_FilterCourse.Properties.AutoHeight = false;
            this.cbe_FilterCourse.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbe_FilterCourse.Properties.Items.AddRange(new object[] {
            "All Course",
            "BSN",
            "BSMT",
            "BS-RADTECH",
            "BS-PHARMA",
            "BSPT",
            "BSIT",
            "BSHM",
            "BSBA",
            "BSED"});
            this.cbe_FilterCourse.Size = new System.Drawing.Size(200, 45);
            this.cbe_FilterCourse.TabIndex = 0;
            this.cbe_FilterCourse.SelectedIndexChanged += new System.EventHandler(this.cbe_FilterCourse_SelectedIndexChanged);
            // 
            // Dashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Dashboard);
            this.Name = "Dashboard_UserControl";
            this.Size = new System.Drawing.Size(1440, 1024);
            this.Load += new System.EventHandler(this.Dashboard_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Dashboard)).EndInit();
            this.lc_Dashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_TotalStudents)).EndInit();
            this.panel_TotalStudents.ResumeLayout(false);
            this.panel_TotalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Students.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_BarGraph)).EndInit();
            this.panel_BarGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl_AttendaceSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Calendar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_ChartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TotalStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbe_FilterCourse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Dashboard;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraEditors.PanelControl panel_BarGraph;
        private DevExpress.XtraLayout.LayoutControlItem lci_ChartControl;
        private DevExpress.XtraEditors.PanelControl panel_TotalStudents;
        private DevExpress.XtraEditors.LabelControl label_TotalStudents;
        private DevExpress.XtraEditors.LabelControl label_TotalAttendance;
        private DevExpress.XtraLayout.LayoutControlItem lci_TotalStudents;
        private DevExpress.XtraEditors.LabelControl txt_TotalStudents;
        private DevExpress.XtraEditors.LabelControl txt_TotalAttendance;
        private DevExpress.XtraEditors.PictureEdit icon_Calendar;
        private DevExpress.XtraEditors.PictureEdit icon_Students;
        private DevExpress.XtraCharts.ChartControl chartControl_AttendaceSummary;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbe_FilterCourse;
    }
}
