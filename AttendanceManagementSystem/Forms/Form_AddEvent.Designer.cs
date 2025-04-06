namespace AttendanceManagementSystem.Forms
{
    partial class Form_AddEvent
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.te_EventTitle = new DevExpress.XtraEditors.TextEdit();
            this.lci_EventTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_EventDescription = new DevExpress.XtraEditors.TextEdit();
            this.lci_EventDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_Date = new DevExpress.XtraEditors.TextEdit();
            this.lci_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.te_Location = new DevExpress.XtraEditors.TextEdit();
            this.lci_Location = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_StartTime = new DevExpress.XtraEditors.TextEdit();
            this.lci_StartTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_CreateEvent = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_EndTime = new DevExpress.XtraEditors.TextEdit();
            this.lci_EndTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbl_EditEvent = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_EditEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_Cancel);
            this.layoutControl1.Controls.Add(this.btn_CreateEvent);
            this.layoutControl1.Controls.Add(this.te_StartTime);
            this.layoutControl1.Controls.Add(this.te_Location);
            this.layoutControl1.Controls.Add(this.te_Date);
            this.layoutControl1.Controls.Add(this.te_EventDescription);
            this.layoutControl1.Controls.Add(this.te_EventTitle);
            this.layoutControl1.Controls.Add(this.te_EndTime);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(827, 523);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_EventTitle,
            this.lci_EventDescription,
            this.lci_Date,
            this.simpleSeparator2,
            this.lci_Location,
            this.layoutControlItem7,
            this.lci_EndTime,
            this.emptySpaceItem1,
            this.layoutControlItem9,
            this.lci_StartTime,
            this.lbl_EditEvent});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(827, 523);
            this.Root.TextVisible = false;
            // 
            // te_EventTitle
            // 
            this.te_EventTitle.Location = new System.Drawing.Point(16, 117);
            this.te_EventTitle.Name = "te_EventTitle";
            this.te_EventTitle.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_EventTitle.Properties.Appearance.Options.UseBorderColor = true;
            this.te_EventTitle.Properties.AutoHeight = false;
            this.te_EventTitle.Size = new System.Drawing.Size(795, 34);
            this.te_EventTitle.StyleController = this.layoutControl1;
            this.te_EventTitle.TabIndex = 4;
            // 
            // lci_EventTitle
            // 
            this.lci_EventTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_EventTitle.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EventTitle.Control = this.te_EventTitle;
            this.lci_EventTitle.Location = new System.Drawing.Point(0, 59);
            this.lci_EventTitle.Name = "lci_EventTitle";
            this.lci_EventTitle.Size = new System.Drawing.Size(801, 82);
            this.lci_EventTitle.Text = "Event Title";
            this.lci_EventTitle.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EventTitle.TextSize = new System.Drawing.Size(152, 36);
            // 
            // te_EventDescription
            // 
            this.te_EventDescription.Location = new System.Drawing.Point(16, 193);
            this.te_EventDescription.Name = "te_EventDescription";
            this.te_EventDescription.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_EventDescription.Properties.Appearance.Options.UseBorderColor = true;
            this.te_EventDescription.Properties.AutoHeight = false;
            this.te_EventDescription.Size = new System.Drawing.Size(795, 117);
            this.te_EventDescription.StyleController = this.layoutControl1;
            this.te_EventDescription.TabIndex = 5;
            // 
            // lci_EventDescription
            // 
            this.lci_EventDescription.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_EventDescription.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EventDescription.Control = this.te_EventDescription;
            this.lci_EventDescription.Location = new System.Drawing.Point(0, 141);
            this.lci_EventDescription.Name = "lci_EventDescription";
            this.lci_EventDescription.Size = new System.Drawing.Size(801, 159);
            this.lci_EventDescription.Text = "Event Description";
            this.lci_EventDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EventDescription.TextSize = new System.Drawing.Size(152, 30);
            // 
            // te_Date
            // 
            this.te_Date.Location = new System.Drawing.Point(16, 352);
            this.te_Date.Name = "te_Date";
            this.te_Date.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_Date.Properties.Appearance.Options.UseBorderColor = true;
            this.te_Date.Size = new System.Drawing.Size(394, 34);
            this.te_Date.StyleController = this.layoutControl1;
            this.te_Date.TabIndex = 6;
            // 
            // lci_Date
            // 
            this.lci_Date.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_Date.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Date.Control = this.te_Date;
            this.lci_Date.Location = new System.Drawing.Point(0, 300);
            this.lci_Date.Name = "lci_Date";
            this.lci_Date.Size = new System.Drawing.Size(400, 76);
            this.lci_Date.Text = "Date";
            this.lci_Date.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Date.TextSize = new System.Drawing.Size(152, 30);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 496);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(801, 1);
            // 
            // te_Location
            // 
            this.te_Location.Location = new System.Drawing.Point(416, 352);
            this.te_Location.Name = "te_Location";
            this.te_Location.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_Location.Properties.Appearance.Options.UseBorderColor = true;
            this.te_Location.Size = new System.Drawing.Size(395, 34);
            this.te_Location.StyleController = this.layoutControl1;
            this.te_Location.TabIndex = 7;
            // 
            // lci_Location
            // 
            this.lci_Location.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_Location.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Location.Control = this.te_Location;
            this.lci_Location.Location = new System.Drawing.Point(400, 300);
            this.lci_Location.Name = "lci_Location";
            this.lci_Location.Size = new System.Drawing.Size(401, 76);
            this.lci_Location.Text = "Location";
            this.lci_Location.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Location.TextSize = new System.Drawing.Size(152, 30);
            // 
            // te_StartTime
            // 
            this.te_StartTime.Location = new System.Drawing.Point(16, 428);
            this.te_StartTime.Name = "te_StartTime";
            this.te_StartTime.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_StartTime.Properties.Appearance.Options.UseBorderColor = true;
            this.te_StartTime.Size = new System.Drawing.Size(394, 34);
            this.te_StartTime.StyleController = this.layoutControl1;
            this.te_StartTime.TabIndex = 8;
            // 
            // lci_StartTime
            // 
            this.lci_StartTime.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_StartTime.AppearanceItemCaption.Options.UseFont = true;
            this.lci_StartTime.Control = this.te_StartTime;
            this.lci_StartTime.Location = new System.Drawing.Point(0, 376);
            this.lci_StartTime.Name = "lci_StartTime";
            this.lci_StartTime.Size = new System.Drawing.Size(400, 76);
            this.lci_StartTime.Text = "Start Time";
            this.lci_StartTime.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_StartTime.TextSize = new System.Drawing.Size(152, 30);
            // 
            // btn_CreateEvent
            // 
            this.btn_CreateEvent.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateEvent.Appearance.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateEvent.Appearance.Options.UseBorderColor = true;
            this.btn_CreateEvent.Appearance.Options.UseFont = true;
            this.btn_CreateEvent.Location = new System.Drawing.Point(632, 468);
            this.btn_CreateEvent.Name = "btn_CreateEvent";
            this.btn_CreateEvent.Size = new System.Drawing.Size(179, 38);
            this.btn_CreateEvent.StyleController = this.layoutControl1;
            this.btn_CreateEvent.TabIndex = 9;
            this.btn_CreateEvent.Text = "Create Event";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btn_CreateEvent;
            this.layoutControlItem7.Location = new System.Drawing.Point(616, 452);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(185, 44);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // te_EndTime
            // 
            this.te_EndTime.Location = new System.Drawing.Point(416, 428);
            this.te_EndTime.Name = "te_EndTime";
            this.te_EndTime.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_EndTime.Properties.Appearance.Options.UseBorderColor = true;
            this.te_EndTime.Size = new System.Drawing.Size(395, 34);
            this.te_EndTime.StyleController = this.layoutControl1;
            this.te_EndTime.TabIndex = 8;
            // 
            // lci_EndTime
            // 
            this.lci_EndTime.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.lci_EndTime.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EndTime.Control = this.te_EndTime;
            this.lci_EndTime.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_EndTime.CustomizationFormText = "Start Time";
            this.lci_EndTime.Location = new System.Drawing.Point(400, 376);
            this.lci_EndTime.Name = "lci_EndTime";
            this.lci_EndTime.Size = new System.Drawing.Size(401, 76);
            this.lci_EndTime.Text = "End Time";
            this.lci_EndTime.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EndTime.TextSize = new System.Drawing.Size(152, 30);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 452);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(453, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseBorderColor = true;
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(469, 468);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(157, 38);
            this.btn_Cancel.StyleController = this.layoutControl1;
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btn_Cancel;
            this.layoutControlItem9.Location = new System.Drawing.Point(453, 452);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(163, 44);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // lbl_EditEvent
            // 
            this.lbl_EditEvent.AllowHotTrack = false;
            this.lbl_EditEvent.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditEvent.AppearanceItemCaption.Options.UseFont = true;
            this.lbl_EditEvent.Location = new System.Drawing.Point(0, 0);
            this.lbl_EditEvent.Name = "lbl_EditEvent";
            this.lbl_EditEvent.Size = new System.Drawing.Size(801, 59);
            this.lbl_EditEvent.Text = "Edit Event";
            this.lbl_EditEvent.TextSize = new System.Drawing.Size(152, 53);
            // 
            // Form_AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form_AddEvent";
            this.Size = new System.Drawing.Size(827, 523);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_EditEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit te_StartTime;
        private DevExpress.XtraEditors.TextEdit te_Location;
        private DevExpress.XtraEditors.TextEdit te_Date;
        private DevExpress.XtraEditors.TextEdit te_EventDescription;
        private DevExpress.XtraEditors.TextEdit te_EventTitle;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventTitle;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_Date;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.LayoutControlItem lci_StartTime;
        private DevExpress.XtraLayout.LayoutControlItem lci_Location;
        private DevExpress.XtraEditors.SimpleButton btn_CreateEvent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TextEdit te_EndTime;
        private DevExpress.XtraLayout.LayoutControlItem lci_EndTime;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.SimpleLabelItem lbl_EditEvent;
    }
}
