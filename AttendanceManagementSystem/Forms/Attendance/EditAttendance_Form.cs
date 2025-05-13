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
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class EditAttendance_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        private Attendance attendance;

        public EditAttendance_Form(Attendance attendance)
        {
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            this.attendance = attendance ?? throw new ArgumentNullException(nameof(attendance), "Attendance object cannot be null.");
            LoadAttendanceData();
            btn_SaveChanges.Click += btn_SaveChanges_Click;
        }


        private void LoadAttendanceData()
        {
            txt_AttendanceName.Text = attendance.AttendanceName;
            txt_AttedanceLocation.Text = attendance.AttendanceLocation;
            cbe_LogType.Text = attendance.LogType;
            de_AttendanceDate.DateTime = attendance.Date;
            te_StartTime.Time = attendance.StartTime;
            te_EndTime.Time = attendance.EndTime;
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            string attendanceName = txt_AttendanceName.Text;
            string attendanceLocation = txt_AttedanceLocation.Text;
            string logType = cbe_LogType.Text;
            DateTime date = de_AttendanceDate.DateTime.Date;
            DateTime startTime = date + te_StartTime.Time.TimeOfDay;
            DateTime endTime = date + te_EndTime.Time.TimeOfDay;

            if (string.IsNullOrWhiteSpace(attendanceName) || string.IsNullOrWhiteSpace(attendanceLocation) || string.IsNullOrWhiteSpace(logType))
            {
                XtraMessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startTime >= endTime)
            {
                XtraMessageBox.Show("Start time must be before end time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            attendance.AttendanceName = attendanceName;
            attendance.AttendanceLocation = attendanceLocation;
            attendance.LogType = logType;
            attendance.Date = date;
            attendance.StartTime = startTime;
            attendance.EndTime = endTime;

            _attendanceRepository.UpdateAttendance(attendance);

            XtraMessageBox.Show("Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
