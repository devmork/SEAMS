using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Forms.Events;

namespace AttendanceManagementSystem.Forms.Attendance
{
	public partial class UserControl_Attendance: DevExpress.XtraEditors.XtraUserControl
	{
        public UserControl_Attendance()
		{
            InitializeComponent();
		}
        private void btn_AddEvent_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();
            addAttendance_Form.ShowDialog();
        }

    }
}
