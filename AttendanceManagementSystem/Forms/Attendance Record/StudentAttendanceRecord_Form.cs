using System;
using AttendanceManagementSystem.Interfaces.Services;
using AttendanceManagementSystem.Models.Base;
using AttendanceManagementSystem.Services;

namespace AttendanceManagementSystem.Forms.Attendance_Report
{
	public partial class StudentAttendanceRecord_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IAttendanceService _attendanceService;
        private Student _student;
        public StudentAttendanceRecord_Form(Student student)
		{
            InitializeComponent();
            _attendanceService = new AttendanceService();
            _student = student;
            LoadAttendanceRecord();
		}
        private void LoadAttendanceRecord()
        {
            txt_SchoolStudentId.Text = _student.SchoolStudentId;
            txt_Name.Text = _student.FullName;

            
            int totalPresent = _attendanceService.GetTotalPresent(_student.SchoolStudentId);
            txt_TotalPresent.EditValue = totalPresent.ToString();

        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}