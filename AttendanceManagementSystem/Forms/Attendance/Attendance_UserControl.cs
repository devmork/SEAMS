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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace AttendanceManagementSystem.Forms.Events
{
	public partial class Attendance_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        private readonly IAttendanceRepository _attendanceRepository;
        public Attendance_UserControl()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
        }
        private void Attendance_UserControl_Load(object sender, EventArgs e)
        {
            var attendance = _attendanceRepository.GetAllAttendance();
            gc_Attendance.DataSource = attendance;
        }
        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();
            addAttendance_Form.ShowDialog();
        }
        private void repositoryItem_EditButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditAttendance_Form editAttendance_Form = new EditAttendance_Form();
            editAttendance_Form.ShowDialog();
        }
        private void repositoryItem_EditButton_Click(object sender, EventArgs e)
        {
            EditAttendance_Form editAttendance_Form = new EditAttendance_Form();
            editAttendance_Form.ShowDialog();

        }

        private void gc_Attendance_Click(object sender, EventArgs e)
        {

        }
    }
}
