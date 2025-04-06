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
	public partial class UserControl_Events: DevExpress.XtraEditors.XtraUserControl
	{
        public UserControl_Events()
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
