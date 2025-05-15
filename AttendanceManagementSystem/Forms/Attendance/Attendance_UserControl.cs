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
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Forms.Events
{
    public partial class Attendance_UserControl : DevExpress.XtraEditors.XtraUserControl
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

            GridView gridView = gc_Attendance.MainView as GridView;
            gridView.Columns["StartTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView.Columns["StartTime"].DisplayFormat.FormatString = "hh:mm tt";
            gridView.Columns["EndTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView.Columns["EndTime"].DisplayFormat.FormatString = "hh:mm tt";
        }
        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();
            addAttendance_Form.ShowDialog();
        }
        //private void repositoryItem_ActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    int buttonIndex = e.Button.Index;

        //    if (buttonIndex == 0)
        //    {
        //        EditAttendance_Form editAttendance_Form = new EditAttendance_Form();;
        //        editAttendance_Form.ShowDialog();
        //    }
        //    else if (buttonIndex == 1)
        //    {
        //        XtraMessageBox.Show("Are you sure you want to delete this attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    }
        //}
        private void repositoryItem_ActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int buttonIndex = e.Button.Index;

            if (buttonIndex == 0)
            {
                // Get the GridView from the GridControl
                GridView gridView = gc_Attendance.MainView as GridView;
                if (gridView != null)
                {
                    // Get the handle of the focused row (where the button was clicked)
                    int rowHandle = gridView.FocusedRowHandle;
                    if (rowHandle >= 0) // Ensure the row handle is valid
                    {
                        // Retrieve the Attendance object from the row
                        Attendance attendance = gridView.GetRow(rowHandle) as Attendance;
                        if (attendance != null) // Verify the object is an Attendance instance
                        {
                            // Instantiate the form with the Attendance object and show it
                            EditAttendance_Form editAttendance_Form = new EditAttendance_Form(attendance);
                            editAttendance_Form.ShowDialog();
                            gridView.RefreshRow(rowHandle); //Girefresh and edited row
                        }
                    }
                }
            }
            else if (buttonIndex == 1)
            {
                XtraMessageBox.Show("Are you sure you want to delete this attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
