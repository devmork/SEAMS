using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace AttendanceManagementSystem.Forms.Reports
{
	public partial class AllAttendanceRecord_Form: DevExpress.XtraEditors.XtraForm
	{
        public AllAttendanceRecord_Form()
		{
            InitializeComponent();
		}
        private void btn_Report_Click(object sender, EventArgs e)
        {
            AllAttendance_Report allAttendance_Report = new AllAttendance_Report();
            allAttendance_Report.ShowPreviewDialog();
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}