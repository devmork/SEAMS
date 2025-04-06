namespace AttendanceManagementSystem.Forms
{
    partial class Form_EditEvent
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
            this.dataLayoutControl_Details = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lbl_EditEvent = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControl_TextEdits = new DevExpress.XtraLayout.LayoutControl();
            this.lci_Details = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcg_Details = new DevExpress.XtraLayout.LayoutControlGroup();
            this.te_EventTitle = new DevExpress.XtraEditors.TextEdit();
            this.lci_EventTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.te_EventDescription = new DevExpress.XtraEditors.TextEdit();
            this.lci_EventDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_SaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.lci_SaveChanges = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.lci_Changes = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_Date = new DevExpress.XtraEditors.TextEdit();
            this.lci_Date = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_Location = new DevExpress.XtraEditors.TextEdit();
            this.lci_Location = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_StartTime = new DevExpress.XtraEditors.TextEdit();
            this.lci_StartTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.te_EndTime = new DevExpress.XtraEditors.TextEdit();
            this.lci_EndTime = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl_Details)).BeginInit();
            this.dataLayoutControl_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_EditEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_TextEdits)).BeginInit();
            this.layoutControl_TextEdits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Changes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Location.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EndTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl_Details
            // 
            this.dataLayoutControl_Details.Controls.Add(this.layoutControl_TextEdits);
            this.dataLayoutControl_Details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl_Details.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl_Details.Name = "dataLayoutControl_Details";
            this.dataLayoutControl_Details.Root = this.Root;
            this.dataLayoutControl_Details.Size = new System.Drawing.Size(827, 523);
            this.dataLayoutControl_Details.TabIndex = 0;
            this.dataLayoutControl_Details.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lbl_EditEvent,
            this.lci_Details});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(827, 523);
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
            this.lbl_EditEvent.TextSize = new System.Drawing.Size(149, 53);
            // 
            // layoutControl_TextEdits
            // 
            this.layoutControl_TextEdits.Controls.Add(this.btn_Cancel);
            this.layoutControl_TextEdits.Controls.Add(this.btn_SaveChanges);
            this.layoutControl_TextEdits.Controls.Add(this.te_EventDescription);
            this.layoutControl_TextEdits.Controls.Add(this.te_EventTitle);
            this.layoutControl_TextEdits.Controls.Add(this.te_Date);
            this.layoutControl_TextEdits.Controls.Add(this.te_Location);
            this.layoutControl_TextEdits.Controls.Add(this.te_StartTime);
            this.layoutControl_TextEdits.Controls.Add(this.te_EndTime);
            this.layoutControl_TextEdits.Location = new System.Drawing.Point(16, 75);
            this.layoutControl_TextEdits.Name = "layoutControl_TextEdits";
            this.layoutControl_TextEdits.Root = this.lcg_Details;
            this.layoutControl_TextEdits.Size = new System.Drawing.Size(795, 432);
            this.layoutControl_TextEdits.TabIndex = 4;
            this.layoutControl_TextEdits.Text = "layoutControl1";
            // 
            // lci_Details
            // 
            this.lci_Details.Control = this.layoutControl_TextEdits;
            this.lci_Details.Location = new System.Drawing.Point(0, 59);
            this.lci_Details.Name = "lci_Details";
            this.lci_Details.Size = new System.Drawing.Size(801, 438);
            this.lci_Details.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Details.TextVisible = false;
            // 
            // lcg_Details
            // 
            this.lcg_Details.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcg_Details.GroupBordersVisible = false;
            this.lcg_Details.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_EventTitle,
            this.emptySpaceItem1,
            this.lci_EventDescription,
            this.lci_SaveChanges,
            this.lci_Changes,
            this.lci_Date,
            this.lci_Location,
            this.lci_StartTime,
            this.lci_EndTime});
            this.lcg_Details.Name = "lcg_Details";
            this.lcg_Details.Size = new System.Drawing.Size(795, 432);
            this.lcg_Details.TextVisible = false;
            // 
            // te_EventTitle
            // 
            this.te_EventTitle.Location = new System.Drawing.Point(16, 58);
            this.te_EventTitle.Name = "te_EventTitle";
            this.te_EventTitle.Properties.AutoHeight = false;
            this.te_EventTitle.Size = new System.Drawing.Size(763, 34);
            this.te_EventTitle.StyleController = this.layoutControl_TextEdits;
            this.te_EventTitle.TabIndex = 4;
            // 
            // lci_EventTitle
            // 
            this.lci_EventTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_EventTitle.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EventTitle.Control = this.te_EventTitle;
            this.lci_EventTitle.Location = new System.Drawing.Point(0, 0);
            this.lci_EventTitle.Name = "lci_EventTitle";
            this.lci_EventTitle.Size = new System.Drawing.Size(769, 82);
            this.lci_EventTitle.Text = "Event Title";
            this.lci_EventTitle.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EventTitle.TextSize = new System.Drawing.Size(182, 36);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 363);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(368, 43);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // te_EventDescription
            // 
            this.te_EventDescription.Location = new System.Drawing.Point(16, 140);
            this.te_EventDescription.Name = "te_EventDescription";
            this.te_EventDescription.Properties.AutoHeight = false;
            this.te_EventDescription.Size = new System.Drawing.Size(763, 81);
            this.te_EventDescription.StyleController = this.layoutControl_TextEdits;
            this.te_EventDescription.TabIndex = 5;
            // 
            // lci_EventDescription
            // 
            this.lci_EventDescription.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_EventDescription.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EventDescription.Control = this.te_EventDescription;
            this.lci_EventDescription.Location = new System.Drawing.Point(0, 82);
            this.lci_EventDescription.Name = "lci_EventDescription";
            this.lci_EventDescription.Size = new System.Drawing.Size(769, 129);
            this.lci_EventDescription.Text = "Event Description";
            this.lci_EventDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EventDescription.TextSize = new System.Drawing.Size(182, 36);
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Appearance.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChanges.Appearance.Options.UseFont = true;
            this.btn_SaveChanges.Location = new System.Drawing.Point(581, 379);
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Size = new System.Drawing.Size(198, 37);
            this.btn_SaveChanges.StyleController = this.layoutControl_TextEdits;
            this.btn_SaveChanges.TabIndex = 6;
            this.btn_SaveChanges.Text = "Save Changes";
            // 
            // lci_SaveChanges
            // 
            this.lci_SaveChanges.Control = this.btn_SaveChanges;
            this.lci_SaveChanges.Location = new System.Drawing.Point(565, 363);
            this.lci_SaveChanges.Name = "lci_SaveChanges";
            this.lci_SaveChanges.Size = new System.Drawing.Size(204, 43);
            this.lci_SaveChanges.TextSize = new System.Drawing.Size(0, 0);
            this.lci_SaveChanges.TextVisible = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Location = new System.Drawing.Point(384, 379);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(191, 37);
            this.btn_Cancel.StyleController = this.layoutControl_TextEdits;
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            // 
            // lci_Changes
            // 
            this.lci_Changes.Control = this.btn_Cancel;
            this.lci_Changes.Location = new System.Drawing.Point(368, 363);
            this.lci_Changes.Name = "lci_Changes";
            this.lci_Changes.Size = new System.Drawing.Size(197, 43);
            this.lci_Changes.TextSize = new System.Drawing.Size(0, 0);
            this.lci_Changes.TextVisible = false;
            // 
            // te_Date
            // 
            this.te_Date.Location = new System.Drawing.Point(16, 263);
            this.te_Date.Name = "te_Date";
            this.te_Date.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_Date.Properties.Appearance.Options.UseBorderColor = true;
            this.te_Date.Size = new System.Drawing.Size(349, 34);
            this.te_Date.StyleController = this.layoutControl_TextEdits;
            this.te_Date.TabIndex = 6;
            // 
            // lci_Date
            // 
            this.lci_Date.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.lci_Date.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Date.Control = this.te_Date;
            this.lci_Date.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_Date.CustomizationFormText = "Date";
            this.lci_Date.Location = new System.Drawing.Point(0, 211);
            this.lci_Date.Name = "lci_Date";
            this.lci_Date.Size = new System.Drawing.Size(355, 76);
            this.lci_Date.Text = "Date";
            this.lci_Date.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Date.TextSize = new System.Drawing.Size(182, 30);
            // 
            // te_Location
            // 
            this.te_Location.Location = new System.Drawing.Point(371, 263);
            this.te_Location.Name = "te_Location";
            this.te_Location.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_Location.Properties.Appearance.Options.UseBorderColor = true;
            this.te_Location.Size = new System.Drawing.Size(408, 34);
            this.te_Location.StyleController = this.layoutControl_TextEdits;
            this.te_Location.TabIndex = 6;
            // 
            // lci_Location
            // 
            this.lci_Location.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.lci_Location.AppearanceItemCaption.Options.UseFont = true;
            this.lci_Location.Control = this.te_Location;
            this.lci_Location.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_Location.CustomizationFormText = "Date";
            this.lci_Location.Location = new System.Drawing.Point(355, 211);
            this.lci_Location.Name = "lci_Location";
            this.lci_Location.Size = new System.Drawing.Size(414, 76);
            this.lci_Location.Text = "Location";
            this.lci_Location.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_Location.TextSize = new System.Drawing.Size(182, 30);
            // 
            // te_StartTime
            // 
            this.te_StartTime.Location = new System.Drawing.Point(16, 339);
            this.te_StartTime.Name = "te_StartTime";
            this.te_StartTime.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_StartTime.Properties.Appearance.Options.UseBorderColor = true;
            this.te_StartTime.Size = new System.Drawing.Size(349, 34);
            this.te_StartTime.StyleController = this.layoutControl_TextEdits;
            this.te_StartTime.TabIndex = 6;
            // 
            // lci_StartTime
            // 
            this.lci_StartTime.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.lci_StartTime.AppearanceItemCaption.Options.UseFont = true;
            this.lci_StartTime.Control = this.te_StartTime;
            this.lci_StartTime.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_StartTime.CustomizationFormText = "Date";
            this.lci_StartTime.Location = new System.Drawing.Point(0, 287);
            this.lci_StartTime.Name = "lci_StartTime";
            this.lci_StartTime.Size = new System.Drawing.Size(355, 76);
            this.lci_StartTime.Text = "Start Time";
            this.lci_StartTime.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_StartTime.TextSize = new System.Drawing.Size(182, 30);
            // 
            // te_EndTime
            // 
            this.te_EndTime.Location = new System.Drawing.Point(371, 339);
            this.te_EndTime.Name = "te_EndTime";
            this.te_EndTime.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.te_EndTime.Properties.Appearance.Options.UseBorderColor = true;
            this.te_EndTime.Size = new System.Drawing.Size(408, 34);
            this.te_EndTime.StyleController = this.layoutControl_TextEdits;
            this.te_EndTime.TabIndex = 6;
            // 
            // lci_EndTime
            // 
            this.lci_EndTime.AppearanceItemCaption.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold);
            this.lci_EndTime.AppearanceItemCaption.Options.UseFont = true;
            this.lci_EndTime.Control = this.te_EndTime;
            this.lci_EndTime.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_EndTime.CustomizationFormText = "Date";
            this.lci_EndTime.Location = new System.Drawing.Point(355, 287);
            this.lci_EndTime.Name = "lci_EndTime";
            this.lci_EndTime.Size = new System.Drawing.Size(414, 76);
            this.lci_EndTime.Text = "End Time";
            this.lci_EndTime.TextLocation = DevExpress.Utils.Locations.Top;
            this.lci_EndTime.TextSize = new System.Drawing.Size(182, 30);
            // 
            // Form_EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl_Details);
            this.Name = "Form_EditEvent";
            this.Size = new System.Drawing.Size(827, 523);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl_Details)).EndInit();
            this.dataLayoutControl_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_EditEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_TextEdits)).EndInit();
            this.layoutControl_TextEdits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lci_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcg_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EventDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EventDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SaveChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Changes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_Location.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_StartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_StartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_EndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_EndTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl_Details;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem lbl_EditEvent;
        private DevExpress.XtraLayout.LayoutControl layoutControl_TextEdits;
        private DevExpress.XtraLayout.LayoutControlGroup lcg_Details;
        private DevExpress.XtraLayout.LayoutControlItem lci_Details;
        private DevExpress.XtraEditors.TextEdit te_EventDescription;
        private DevExpress.XtraEditors.TextEdit te_EventTitle;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventTitle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lci_EventDescription;
        private DevExpress.XtraEditors.SimpleButton btn_SaveChanges;
        private DevExpress.XtraLayout.LayoutControlItem lci_SaveChanges;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraLayout.LayoutControlItem lci_Changes;
        private DevExpress.XtraEditors.TextEdit te_Date;
        private DevExpress.XtraEditors.TextEdit te_Location;
        private DevExpress.XtraEditors.TextEdit te_StartTime;
        private DevExpress.XtraEditors.TextEdit te_EndTime;
        private DevExpress.XtraLayout.LayoutControlItem lci_Date;
        private DevExpress.XtraLayout.LayoutControlItem lci_Location;
        private DevExpress.XtraLayout.LayoutControlItem lci_StartTime;
        private DevExpress.XtraLayout.LayoutControlItem lci_EndTime;
    }
}
