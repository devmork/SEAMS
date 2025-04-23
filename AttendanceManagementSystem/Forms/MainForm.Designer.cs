namespace AttendanceManagementSystem.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordion_Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.btn_Dashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Attendance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Students = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Reports = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_StudentReports = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_QRScanner = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // accordion_Menu
            // 
            this.accordion_Menu.Appearance.Item.Default.Font = new System.Drawing.Font("Poppins SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Default.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Disabled.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Hovered.BackColor = System.Drawing.Color.White;
            this.accordion_Menu.Appearance.Item.Hovered.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Hovered.Options.UseBackColor = true;
            this.accordion_Menu.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Normal.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Normal.Options.UseFont = true;
            this.accordion_Menu.Appearance.Item.Pressed.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordion_Menu.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordion_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordion_Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Dashboard,
            this.accordionControlSeparator1,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlSeparator5,
            this.btn_QRScanner});
            this.accordion_Menu.Location = new System.Drawing.Point(0, 0);
            this.accordion_Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accordion_Menu.Name = "accordion_Menu";
            this.accordion_Menu.Size = new System.Drawing.Size(250, 734);
            this.accordion_Menu.TabIndex = 5;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dashboard.ImageOptions.SvgImage")));
            this.btn_Dashboard.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement1.Appearance.Default.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.accordionControlElement1.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Attendance,
            this.btn_Students});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Manage";
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Attendance.ImageOptions.SvgImage")));
            this.btn_Attendance.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Attendance.Text = "All Attendance";
            // 
            // btn_Students
            // 
            this.btn_Students.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Students.ImageOptions.SvgImage")));
            this.btn_Students.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Students.Text = "All Students";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Default.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement2.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Reports,
            this.btn_StudentReports});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Reports";
            // 
            // btn_Reports
            // 
            this.btn_Reports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reports.ImageOptions.SvgImage")));
            this.btn_Reports.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Reports.Text = "Attendance";
            // 
            // btn_StudentReports
            // 
            this.btn_StudentReports.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_StudentReports.ImageOptions.SvgImage")));
            this.btn_StudentReports.ImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.btn_StudentReports.Name = "btn_StudentReports";
            this.btn_StudentReports.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_StudentReports.Text = "Students";
            // 
            // accordionControlSeparator5
            // 
            this.accordionControlSeparator5.Name = "accordionControlSeparator5";
            // 
            // btn_QRScanner
            // 
            this.btn_QRScanner.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_QRScanner.ImageOptions.SvgImage")));
            this.btn_QRScanner.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_QRScanner.Name = "btn_QRScanner";
            this.btn_QRScanner.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_QRScanner.Text = "QR Scanner";
            this.btn_QRScanner.Click += new System.EventHandler(this.btn_QRScanner_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(250, 0);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1036, 734);
            this.panel_Body.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 734);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.accordion_Menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DMC SSG Attendance Management System";
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordion_Menu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Dashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Attendance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Reports;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_QRScanner;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_StudentReports;
    }
}