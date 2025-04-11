namespace AttendanceManagementSystem.Forms.Students
{
    partial class Students_UserControl
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
            this.lc_Students = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panel_PageHeading = new DevExpress.XtraEditors.PanelControl();
            this.label_PageTitle = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddStudent = new DevExpress.XtraEditors.SimpleButton();
            this.label_PageDescription = new DevExpress.XtraEditors.LabelControl();
            this.lci_PageHeading = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Students = new DevExpress.XtraGrid.GridControl();
            this.gv_Students = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lci_GridControlStudents = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).BeginInit();
            this.lc_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).BeginInit();
            this.panel_PageHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lc_Students
            // 
            this.lc_Students.Controls.Add(this.panel_PageHeading);
            this.lc_Students.Controls.Add(this.gc_Students);
            this.lc_Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Students.Location = new System.Drawing.Point(0, 0);
            this.lc_Students.Name = "lc_Students";
            this.lc_Students.Root = this.Root;
            this.lc_Students.Size = new System.Drawing.Size(1038, 768);
            this.lc_Students.TabIndex = 0;
            this.lc_Students.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_PageHeading,
            this.lci_GridControlStudents});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1038, 768);
            this.Root.TextVisible = false;
            // 
            // panel_PageHeading
            // 
            this.panel_PageHeading.Controls.Add(this.label_PageTitle);
            this.panel_PageHeading.Controls.Add(this.btn_AddStudent);
            this.panel_PageHeading.Controls.Add(this.label_PageDescription);
            this.panel_PageHeading.Location = new System.Drawing.Point(16, 16);
            this.panel_PageHeading.Name = "panel_PageHeading";
            this.panel_PageHeading.Size = new System.Drawing.Size(1006, 98);
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
            this.label_PageTitle.Size = new System.Drawing.Size(110, 42);
            this.label_PageTitle.TabIndex = 0;
            this.label_PageTitle.Text = "Students";
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddStudent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(182)))), ((int)(((byte)(125)))));
            this.btn_AddStudent.Appearance.Font = new System.Drawing.Font("Poppins", 12.08F);
            this.btn_AddStudent.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_AddStudent.Appearance.Options.UseBackColor = true;
            this.btn_AddStudent.Appearance.Options.UseFont = true;
            this.btn_AddStudent.Appearance.Options.UseForeColor = true;
            this.btn_AddStudent.Appearance.Options.UseTextOptions = true;
            this.btn_AddStudent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_AddStudent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_AddStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.btn_AddStudent.Location = new System.Drawing.Point(759, 25);
            this.btn_AddStudent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btn_AddStudent.Size = new System.Drawing.Size(235, 48);
            this.btn_AddStudent.TabIndex = 2;
            this.btn_AddStudent.Text = "Add Student";
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
            this.label_PageDescription.Size = new System.Drawing.Size(311, 28);
            this.label_PageDescription.TabIndex = 1;
            this.label_PageDescription.Text = "View and manage student information.";
            // 
            // lci_PageHeading
            // 
            this.lci_PageHeading.Control = this.panel_PageHeading;
            this.lci_PageHeading.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_PageHeading.CustomizationFormText = "layoutControlItem1";
            this.lci_PageHeading.Location = new System.Drawing.Point(0, 0);
            this.lci_PageHeading.Name = "lci_PageHeading";
            this.lci_PageHeading.Size = new System.Drawing.Size(1012, 104);
            this.lci_PageHeading.Text = "layoutControlItem1";
            this.lci_PageHeading.TextSize = new System.Drawing.Size(0, 0);
            this.lci_PageHeading.TextVisible = false;
            // 
            // gc_Students
            // 
            this.gc_Students.Location = new System.Drawing.Point(16, 120);
            this.gc_Students.MainView = this.gv_Students;
            this.gc_Students.Name = "gc_Students";
            this.gc_Students.Size = new System.Drawing.Size(1006, 632);
            this.gc_Students.TabIndex = 8;
            this.gc_Students.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Students});
            // 
            // gv_Students
            // 
            this.gv_Students.GridControl = this.gc_Students;
            this.gv_Students.Name = "gv_Students";
            // 
            // lci_GridControlStudents
            // 
            this.lci_GridControlStudents.Control = this.gc_Students;
            this.lci_GridControlStudents.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lci_GridControlStudents.CustomizationFormText = "lci_GridControlStudents";
            this.lci_GridControlStudents.Location = new System.Drawing.Point(0, 104);
            this.lci_GridControlStudents.Name = "lci_GridControlStudents";
            this.lci_GridControlStudents.Size = new System.Drawing.Size(1012, 638);
            this.lci_GridControlStudents.Text = "lci_GridControlStudents";
            this.lci_GridControlStudents.TextSize = new System.Drawing.Size(0, 0);
            this.lci_GridControlStudents.TextVisible = false;
            // 
            // Students_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lc_Students);
            this.Name = "Students_UserControl";
            this.Size = new System.Drawing.Size(1038, 768);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Students)).EndInit();
            this.lc_Students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_PageHeading)).EndInit();
            this.panel_PageHeading.ResumeLayout(false);
            this.panel_PageHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lci_PageHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_GridControlStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lc_Students;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panel_PageHeading;
        private DevExpress.XtraEditors.LabelControl label_PageTitle;
        private DevExpress.XtraEditors.SimpleButton btn_AddStudent;
        private DevExpress.XtraEditors.LabelControl label_PageDescription;
        private DevExpress.XtraLayout.LayoutControlItem lci_PageHeading;
        private DevExpress.XtraGrid.GridControl gc_Students;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Students;
        private DevExpress.XtraLayout.LayoutControlItem lci_GridControlStudents;
    }
}
