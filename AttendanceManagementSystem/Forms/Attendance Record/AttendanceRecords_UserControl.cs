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
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using AttendanceManagementSystem.Forms.Attendance_Report;

namespace AttendanceManagementSystem.Forms.Attendance_Record
{
	public partial class AttendanceRecords_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
		private readonly IStudentsRepository _studentsRepository;
        public AttendanceRecords_UserControl()
		{
            InitializeComponent();
			_studentsRepository = new StudentRepository();
        }

        private void gridControl_Reports_Load(object sender, EventArgs e)
        {
            gc_AttendanceRecords.DataSource = _studentsRepository.GetAllStudent();
        }

        private void repositoryItemButton_Action_Click(object sender, EventArgs e)
        {
            StudentAttendanceRecord_Form studentAttendanceRecord_Form = new StudentAttendanceRecord_Form();
            studentAttendanceRecord_Form.ShowDialog();
        }
    }
}
