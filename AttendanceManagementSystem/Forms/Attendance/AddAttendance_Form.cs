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
using AttendanceManagementSystem.Models.Base;
using System.Data.SQLite;
using Dapper;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class AddAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        public AddAttendance_Form()
		{
            InitializeComponent();
		}
        private void btn_CreateEvent_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}