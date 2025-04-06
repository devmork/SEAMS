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
using AttendanceManagementSystem.Forms.Events;
using AttendanceManagementSystem.Forms.Attendance;

namespace AttendanceManagementSystem.Forms
{
	public partial class MainForm: DevExpress.XtraEditors.XtraForm
	{
        public MainForm()
		{
            InitializeComponent();
		}
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

        }
        private void btn_Events_Click_1(object sender, EventArgs e)
        {
            panel_Body.Controls.Clear();
            UserControl_Attendance userControl_Attendance = new UserControl_Attendance();
            userControl_Attendance.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(userControl_Attendance);

        }
    }
}