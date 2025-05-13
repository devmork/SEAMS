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
using DevExpress.XtraEditors.Filtering.Templates;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class AddAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        public AddAttendance_Form()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            // Disable past dates in the DateEdit control
            de_Date.Properties.MinValue = DateTime.Today;

            // Set Start Time to the current time
            te_StartTime.EditValue = DateTime.Now;
        }
        private void btn_CreateAttendance_Click(object sender, EventArgs e)
        {
            string attendanceName = txt_AttendanceName.Text;
            string attendanceLocation = txt_AttendanceLocation.Text;
            string logType = cbe_LogType.Text;
            DateTime date = de_Date.DateTime.Date; // Selected date without time
            DateTime startTime = date + te_StartTime.Time.TimeOfDay; // Combine date with start time
            DateTime endTime = date + te_EndTime.Time.TimeOfDay; // Combine date with end time

            if (startTime >= endTime)
            {
                XtraMessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var attendance = new Attendance
            {
                AttendanceId = 0,
                AttendanceName = attendanceName,
                AttendanceLocation = attendanceLocation,
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