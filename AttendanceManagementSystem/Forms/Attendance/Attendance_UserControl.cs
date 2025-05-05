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

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class Attendance_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        public Attendance_UserControl()
		{
            InitializeComponent();
		}
        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();
            addAttendance_Form.ShowDialog();
        }

    }
}
