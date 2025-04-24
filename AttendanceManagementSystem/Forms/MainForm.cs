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
using AttendanceManagementSystem.Forms.Dashboard;
using AttendanceManagementSystem.Forms.Students;
using AttendanceManagementSystem.Forms.QRScanner;
using AttendanceManagementSystem.Forms.Attendance_Report;

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
            Dashboard_UserControl dashboard_UserControl = new Dashboard_UserControl();
            dashboard_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(dashboard_UserControl);
        }

        private void btn_QRScanner_Click(object sender, EventArgs e)
        {
            QRScanner_UserControl qrScanner_UserControl = new QRScanner_UserControl();
            qrScanner_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(qrScanner_UserControl);
        }

        private void btn_Events_Click_1(object sender, EventArgs e)
        {
            Events_UserControl events_UserControl = new Events_UserControl();
            events_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(events_UserControl);
        }

        private void btn_Students_Click_1(object sender, EventArgs e)
        {
            Students_UserControl students_UserControl = new Students_UserControl();
            students_UserControl.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(students_UserControl);
        }

        private void btn_AttendanceRecord_Click_1(object sender, EventArgs e)
        {
            AttendanceRecords attedanceRecords = new AttendanceRecords();
            attedanceRecords.Dock = DockStyle.Fill;
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(attedanceRecords);
        }
    }
}