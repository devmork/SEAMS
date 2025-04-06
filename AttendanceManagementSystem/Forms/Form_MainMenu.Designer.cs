namespace AttendanceManagementSystem.Forms
{
    partial class Form_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainMenu));
            this.layoutControl_Main = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl_Body = new DevExpress.XtraLayout.LayoutControl();
            this.panel_Body = new DevExpress.XtraEditors.PanelControl();
            this.lcg_Body = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.lci_PanelSystemName = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_AccordionMenu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_Body = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Main)).BeginInit();
            this.layoutControl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Body)).BeginInit();
            this.layoutControl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelSystemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AccordionMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Body)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl_Main
            // 
            this.layoutControl_Main.Controls.Add(this.layoutControl_Body);
            this.layoutControl_Main.Controls.Add(this.accordion_Menu);
            this.layoutControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl_Main.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PanelSystemName});
            this.layoutControl_Main.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl_Main.Name = "layoutControl_Main";
            this.layoutControl_Main.Root = this.Root;
            this.layoutControl_Main.Size = new System.Drawing.Size(1286, 734);
            this.layoutControl_Main.TabIndex = 0;
            this.layoutControl_Main.Text = "layoutControl1";
            // 
            // layoutControl_Body
            // 
            this.layoutControl_Body.Controls.Add(this.panel_Body);
            this.layoutControl_Body.Location = new System.Drawing.Point(233, 16);
            this.layoutControl_Body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl_Body.Name = "layoutControl_Body";
            this.layoutControl_Body.Root = this.lcg_Body;
            this.layoutControl_Body.Size = new System.Drawing.Size(1037, 702);
            this.layoutControl_Body.TabIndex = 5;
            this.layoutControl_Body.Text = "layoutControl2";
            // 
            // panel_Body
            // 
            this.panel_Body.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel_Body.Location = new System.Drawing.Point(16, 16);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1005, 670);
            this.panel_Body.TabIndex = 4;
            // 
            // lcg_Body
            // 
            this.lcg_Body.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg_Body.GroupBordersVisible = false;
            this.lcg_Body.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PanelBody});
            this.lcg_Body.Name = "lcg_Body";
            this.lcg_Body.Size = new System.Drawing.Size(1037, 702);
            this.lcg_Body.TextVisible = false;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.panel_Body;
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 0);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1011, 676);
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
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
            this.accordion_Menu.Location = new System.Drawing.Point(16, 16);
            this.accordion_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accordion_Menu.Name = "accordion_Menu";
            this.accordion_Menu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordion_Menu.Size = new System.Drawing.Size(48, 702);
            this.accordion_Menu.StyleController = this.layoutControl_Main;
            this.accordion_Menu.TabIndex = 4;
            this.accordion_Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Dashboard.ImageOptions.SvgImage")));
            this.btn_Dashboard.ImageOptions.SvgImageSize = new System.Drawing.Size(22, 22);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Dashboard.Text = "Dashboard";
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
            // lci_PanelSystemName
            // 
            this.lci_PanelSystemName.Location = new System.Drawing.Point(0, 0);
            this.lci_PanelSystemName.Name = "lci_PanelSystemName";
            this.lci_PanelSystemName.Size = new System.Drawing.Size(1030, 39);
            this.lci_PanelSystemName.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelSystemName.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_AccordionMenu,
            this.lci_Body});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1286, 734);
            this.Root.TextVisible = false;
            // 
            // lci_AccordionMenu
            // 
            this.lci_AccordionMenu.Control = this.accordion_Menu;
            this.lci_AccordionMenu.Location = new System.Drawing.Point(0, 0);
            this.lci_AccordionMenu.Name = "lci_AccordionMenu";
            this.lci_AccordionMenu.Size = new System.Drawing.Size(217, 708);
            this.lci_AccordionMenu.TextSize = new System.Drawing.Size(0, 0);
            this.lci_AccordionMenu.TextVisible = false;
            // 
            // lci_Body
            // 
            this.lci_Body.Control = this.layoutControl_Body;
            this.lci_Body.Location = new System.Drawing.Point(217, 0);
            this.lci_Body.Name = "lci_Body";
            this.lci_Body.Size = new System.Drawing.Size(1043, 708);
            this.lci_Body.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Body.TextVisible = false;
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 734);
            this.Controls.Add(this.layoutControl_Main);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form_MainMenu.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_MainMenu";
            this.Text = "DMC SSG Attendance Management System - Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Main)).EndInit();
            this.layoutControl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Body)).EndInit();
            this.layoutControl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordion_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelSystemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_AccordionMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Body)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl_Main;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl_Body;
        private DevExpress.XtraLayout.LayoutControlGroup lcg_Body;
        private DevExpress.XtraBars.Navigation.AccordionControl accordion_Menu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Dashboard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Events;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Attendance;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Students;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_QRScanner;
        private DevExpress.XtraLayout.LayoutControlItem lci_AccordionMenu;
        private DevExpress.XtraLayout.LayoutControlItem lci_Body;
        private DevExpress.XtraEditors.PanelControl panel_Body;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelSystemName;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator4;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator5;
    }
}