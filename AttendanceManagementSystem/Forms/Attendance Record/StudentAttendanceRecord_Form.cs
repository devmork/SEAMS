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
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;

namespace AttendanceManagementSystem.Forms.Attendance_Report
{
	public partial class StudentAttendanceRecord_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceRepository _attendanceRepository;
        private readonly string _schoolStudentId;
        public StudentAttendanceRecord_Form(string schoolStudentId)
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            _schoolStudentId = schoolStudentId;
            LoadAttendanceRecord();

		}
        private void LoadAttendanceRecord()
        {
            try
            {
                // Fetch attendance records for the student
                var records = _attendanceRepository.GetAttendanceRecordsByStudentId(_schoolStudentId);
                gc_AttendanceRecord.DataSource = records;

                // Calculate total attendance events
                int totalAttendance = _attendanceRepository.GetTotalAttendance();
                txt_TotalAttendance.EditValue = totalAttendance.ToString();

                // Calculate total absent
                int totalAbsent = _attendanceRepository.GetTotalAbsentCount(_schoolStudentId);
                txt_TotalAbsent.EditValue = totalAbsent.ToString();

                // Calculate total present (records where Remarks is "Present")
                int totalPresent = records.Count(r => r.Remarks == "Present");
                txt_TotalPresent.EditValue = totalPresent.ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error loading attendance data: {ex.Message}");
            }
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}