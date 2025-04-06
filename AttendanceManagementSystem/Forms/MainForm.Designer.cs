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
            this.btn_Events = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_Attendance = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator4 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_Students = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator5 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.btn_QRScanner = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
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
            this.btn_Events,
            this.accordionControlSeparator3,
            this.btn_Attendance,
            this.accordionControlSeparator4,
            this.btn_Students,
            this.accordionControlSeparator5,
            this.btn_QRScanner,
            this.accordionControlSeparator2});
            this.accordion_Menu.Location = new System.Drawing.Point(0, 0);
            this.accordion_Menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accordion_Menu.Name = "accordion_Menu";
            this.accordion_Menu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordion_Menu.Size = new System.Drawing.Size(48, 734);
            this.accordion_Menu.TabIndex = 5;
            this.accordion_Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
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
            // btn_Events
            // 
            this.btn_Events.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Events.ImageOptions.SvgImage")));
            this.btn_Events.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Events.Text = "Events";
            this.btn_Events.Click += new System.EventHandler(this.btn_Events_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Attendance.ImageOptions.SvgImage")));
            this.btn_Attendance.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Attendance.Text = "Attendance";
            // 
            // accordionControlSeparator4
            // 
            this.accordionControlSeparator4.Name = "accordionControlSeparator4";
            // 
            // btn_Students
            // 
            this.btn_Students.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Students.ImageOptions.SvgImage")));
            this.btn_Students.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Students.Text = "Students";
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
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // panel_Body
            // 
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(48, 0);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1238, 734);
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Events;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Attendance;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_QRScanner;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraEditors.PanelControl panel_Body;
    }
}