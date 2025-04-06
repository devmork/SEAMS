namespace AttendanceManagementSystem.Forms.Events
{
    partial class UserControl_Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Events));
            this.lc_Events = new DevExpress.XtraLayout.LayoutControl();
            this.panel_EventsBody = new DevExpress.XtraEditors.PanelControl();
            this.gc_Events = new DevExpress.XtraGrid.GridControl();
            this.gv_Events = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_AddEvent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Events)).BeginInit();
            this.lc_Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_EventsBody)).BeginInit();
            this.panel_EventsBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Events)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Events)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Events
            // 
            this.lc_Events.Controls.Add(this.panel_EventsBody);
            this.lc_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Events.Location = new System.Drawing.Point(0, 0);
            this.lc_Events.Margin = new System.Windows.Forms.Padding(4);
            this.lc_Events.Name = "lc_Events";
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_Events.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lc_Events.Root = this.Root;
            this.lc_Events.Size = new System.Drawing.Size(1288, 768);
            this.lc_Events.TabIndex = 0;
            this.lc_Events.Text = "layoutControl1";
            // 
            // panel_EventsBody
            // 
            this.panel_EventsBody.Controls.Add(this.gc_Events);
            this.panel_EventsBody.Controls.Add(this.btn_AddEvent);
            this.panel_EventsBody.Controls.Add(this.label_PageTitle);
            this.panel_EventsBody.Controls.Add(this.label_PageDescription);
            this.panel_EventsBody.Location = new System.Drawing.Point(16, 16);
            this.panel_EventsBody.Margin = new System.Windows.Forms.Padding(4);
            this.panel_EventsBody.Name = "panel_EventsBody";
            this.panel_EventsBody.Size = new System.Drawing.Size(1256, 736);
            this.panel_EventsBody.TabIndex = 5;
            // 
            // gc_Events
            // 
            this.gc_Events.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gc_Events.Location = new System.Drawing.Point(2, 95);
            this.gc_Events.MainView = this.gv_Events;
            this.gc_Events.Name = "gc_Events";
            this.gc_Events.Size = new System.Drawing.Size(1252, 639);
            this.gc_Events.TabIndex = 3;
            this.gc_Events.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Events});
            // 
            // gv_Events
            // 
            this.gv_Events.GridControl = this.gc_Events;
            this.gv_Events.Name = "gv_Events";
            // 
            // btn_AddEvent
            // 
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
            this.btn_AddEvent.Location = new System.Drawing.Point(1061, 24);
            this.btn_AddEvent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddEvent.Name = "btn_AddEvent";
            this.btn_AddEvent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddEvent.Size = new System.Drawing.Size(180, 48);
            this.btn_AddEvent.TabIndex = 2;
            this.btn_AddEvent.Text = "Add Event";
            // 
            // label_PageTitle
            // 
            this.label_PageTitle.Appearance.Font = new System.Drawing.Font("Poppins", 17.71F, System.Drawing.FontStyle.Bold);
            this.label_PageTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.label_PageTitle.Appearance.Options.UseFont = true;
            this.label_PageTitle.Location = new System.Drawing.Point(34, 24);
            this.label_PageTitle.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageTitle.Name = "label_PageTitle";
            this.label_PageTitle.Size = new System.Drawing.Size(82, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Events";
            // 
            // label_PageDescription
            // 
            this.label_PageDescription.Appearance.Font = new System.Drawing.Font("Poppins", 12F);
            this.label_PageDescription.Appearance.Options.UseFont = true;
            this.label_PageDescription.Location = new System.Drawing.Point(34, 60);
            this.label_PageDescription.Margin = new System.Windows.Forms.Padding(4);
            this.label_PageDescription.Name = "label_PageDescription";
            this.label_PageDescription.Size = new System.Drawing.Size(183, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "Manage school events.";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1288, 768);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panel_EventsBody;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1262, 742);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // UserControl_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Events);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Events";
            this.Size = new System.Drawing.Size(1288, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Events)).EndInit();
            this.lc_Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_EventsBody)).EndInit();
            this.panel_EventsBody.ResumeLayout(false);
            this.panel_EventsBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Events)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Events)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Events;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_EventsBody;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraGrid.GridControl gc_Events;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Events;
        private DevExpress.XtraEditors.SimpleButton btn_AddEvent;
    }
}
