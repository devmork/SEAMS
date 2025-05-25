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

namespace AttendanceManagementSystem.Forms.Dashboard
{
	public partial class Dashboard_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        private IAttendanceRepository _attendanceRepository;
        private IStudentsRepository _studentRepository;
        public Dashboard_UserControl()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            _studentRepository = new StudentsRepository();
        }
        private void Dashboard_UserControl_Load(object sender, EventArgs e)
        {
            txt_TotalAttendance.Text = _attendanceRepository.GetTotalAttendance().ToString();
            txt_TotalStudents.Text = _studentRepository.GetTotalStudents().ToString();
        }
    }
}
