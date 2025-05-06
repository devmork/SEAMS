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
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class AddAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        public AddAttendance_Form()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
        }
        private void btn_CreateAttendance_Click(object sender, EventArgs e)
        {
            string attendanceName = txt_AttendanceName.Text;
            string attendanceLocation = txt_AttendanceLocation.Text;
            string timeOfDay = cbe_TimeOfDay.Text;
            string logType = cbe_LogType.Text;
            DateTime date = de_Date.DateTime;
            DateTime startTime = te_StartTime.Time;
            DateTime endTime = te_EndTime.Time;

            var attendance = new Attendance
            {
                AttendanceId = Guid.NewGuid(),
                AttendanceName = attendanceName,
                AttendanceLocation = attendanceLocation,
                TimeOfDay = timeOfDay,
                LogType = logType,
                Date = date,
                StartTime = startTime,
                EndTime = endTime
            };
            _attendanceRepository.AddAttendance(attendance);

            // Show success message and close
            XtraMessageBox.Show("Attendance created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}