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
using AttendanceManagementSystem.Models.Base;
using DevExpress.Utils.MVVM;

namespace AttendanceManagementSystem.Forms.QRScanner
{
	public partial class QRScanner_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
        private readonly IAttendanceRepository _attendanceRepository;
        public QRScanner_UserControl()
		{
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
		}
        private void QRScanner_UserControl_Load(object sender, EventArgs e)
        {
            foreach (var attendance in _attendanceRepository.GetAllAttendance())
            {
                cbe_ChooseAttendance.Properties.Items.Add(attendance.AttendanceName);
            }
        }
    }
}
