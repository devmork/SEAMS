namespace AttendanceManagementSystem.Forms.Attendance
{
    partial class Events_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events_UserControl));
            this.lc_Events = new DevExpress.XtraLayout.LayoutControl();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddEvent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.gc_Event = new DevExpress.XtraGrid.GridControl();
            this.cv_Event = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gc_EventTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EventDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EventDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EventStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EventEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_EventLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_PanelBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Events)).BeginInit();
            this.lc_Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Events
            // 
            this.lc_Events.Controls.Add(this.panel_PageHeading);
            this.lc_Events.Controls.Add(this.gc_Event);
            this.lc_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Events.Location = new System.Drawing.Point(0, 0);
            this.lc_Events.Name = "lc_Events";
            this.lc_Events.Root = this.Root;
            this.lc_Events.Size = new System.Drawing.Size(1038, 768);
            this.lc_Events.TabIndex = 0;
            this.lc_Events.Text = "layoutControl1";
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddEvent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 103);
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
            this.label_PageTitle.Size = new System.Drawing.Size(82, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Events";
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
            this.btn_AddEvent.Size = new System.Drawing.Size(235, 53);
            this.btn_AddEvent.TabIndex = 2;
            this.btn_AddEvent.Text = "Add Event";
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
            this.label_PageDescription.Size = new System.Drawing.Size(263, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage school events.";
            // 
            // gc_Event
            // 
            this.gc_Event.Location = new System.Drawing.Point(16, 125);
            this.gc_Event.MainView = this.cv_Event;
            this.gc_Event.Name = "gc_Event";
            this.gc_Event.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gc_Event.Size = new System.Drawing.Size(1006, 627);
            this.gc_Event.TabIndex = 8;
            this.gc_Event.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cv_Event});
            // 
            // cv_Event
            // 
            this.cv_Event.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_EventTitle,
            this.gc_EventDescription,
            this.gc_EventDate,
            this.gc_EventStartTime,
            this.gc_EventEndTime,
            this.gc_EventLocation});
            this.cv_Event.GridControl = this.gc_Event;
            this.cv_Event.Name = "cv_Event";
            this.cv_Event.OptionsBehavior.FieldAutoHeight = true;
            this.cv_Event.PaintStyleName = "Flat";
            // 
            // gc_EventTitle
            // 
            this.gc_EventTitle.Caption = "Title:";
            this.gc_EventTitle.Name = "gc_EventTitle";
            this.gc_EventTitle.Visible = true;
            this.gc_EventTitle.VisibleIndex = 0;
            // 
            // gc_EventDescription
            // 
            this.gc_EventDescription.Caption = "Description:";
            this.gc_EventDescription.Name = "gc_EventDescription";
            this.gc_EventDescription.Visible = true;
            this.gc_EventDescription.VisibleIndex = 5;
            // 
            // gc_EventDate
            // 
            this.gc_EventDate.Caption = "Date:";
            this.gc_EventDate.Name = "gc_EventDate";
            this.gc_EventDate.Visible = true;
            this.gc_EventDate.VisibleIndex = 1;
            // 
            // gc_EventStartTime
            // 
            this.gc_EventStartTime.Caption = "Start Time:";
            this.gc_EventStartTime.Name = "gc_EventStartTime";
            this.gc_EventStartTime.Visible = true;
            this.gc_EventStartTime.VisibleIndex = 2;
            // 
            // gc_EventEndTime
            // 
            this.gc_EventEndTime.Caption = "End Time:";
            this.gc_EventEndTime.Name = "gc_EventEndTime";
            this.gc_EventEndTime.Visible = true;
            this.gc_EventEndTime.VisibleIndex = 3;
            // 
            // gc_EventLocation
            // 
            this.gc_EventLocation.Caption = "Location";
            this.gc_EventLocation.Name = "gc_EventLocation";
            this.gc_EventLocation.Visible = true;
            this.gc_EventLocation.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
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
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 109);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // lci_PanelBody
            // 
            this.lci_PanelBody.Control = this.gc_Event;
            this.lci_PanelBody.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PanelBody.CustomizationFormText = "layoutControlItem2";
            this.lci_PanelBody.Location = new System.Drawing.Point(0, 109);
            this.lci_PanelBody.Name = "lci_PanelBody";
            this.lci_PanelBody.Size = new System.Drawing.Size(1012, 633);
            this.lci_PanelBody.Text = "layoutControlItem2";
            this.lci_PanelBody.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PanelBody.TextVisible = false;
            // 
            // Events_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Events);
            this.Name = "Events_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Events)).EndInit();
            this.lc_Events.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cv_Event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PanelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Events;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.SimpleButton btn_AddEvent;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Event;
        private DevExpress.XtraGrid.Views.Card.CardView cv_Event;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventTitle;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_EventLocation;
        private DevExpress.XtraLayout.LayoutControlItem lci_PanelBody;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
