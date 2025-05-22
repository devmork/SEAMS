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
            // Ensure Status column is visible and displayed as text
            gridView.Columns["Status"].ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit(); //gichange ang editor type into text para dili na sya magcheckbox
            gridView.CustomColumnDisplayText += GridView_CustomColumnDisplayText; //gahandle sa converting sa boolean status which is Active ug Inactive
        }

        private void GridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Status")
            {
                bool status = (bool)e.Value;
                e.DisplayText = status ? "ACTIVE" : "INACTIVE";
            }
        }

        private void btn_AddAttendance_Click(object sender, EventArgs e)
        {
            AddAttendance_Form addAttendance_Form = new AddAttendance_Form();
            addAttendance_Form.ShowDialog();
        }
        
        private void repositoryItem_ActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int buttonIndex = e.Button.Index;
            GridView gridView = gc_Attendance.MainView as GridView;
            if (gridView == null) return;

            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle < 0) return;

            // Declare 'attendance' here so it's accessible in all branches
            Attendance attendance = gridView.GetRow(rowHandle) as Attendance;
            if (attendance == null) return;

            if (buttonIndex == 0)
            {
                // Edit functionality
                EditAttendance_Form editAttendance_Form = new EditAttendance_Form(attendance);
                editAttendance_Form.ShowDialog();
                gridView.RefreshRow(rowHandle);
            }
            else if (buttonIndex == 1)
            {

                if (XtraMessageBox.Show("Are you sure you want to delete this attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        _attendanceRepository.DeleteAttendance(attendance.AttendanceId);
                        LoadAttendanceData();
                        XtraMessageBox.Show("Attendance deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"An error occurred while deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadAttendanceData()
        {
            var attendanceList = _attendanceRepository.GetAllAttendance();
            foreach (var att in attendanceList)
            {
                bool shouldBeActive = (DateTime.Now >= att.StartTime && DateTime.Now <= att.EndTime);
                if (att.Status != shouldBeActive)
                {
                    att.Status = shouldBeActive;
                    _attendanceRepository.UpdateAttendance(att);
                }
            }
            gc_Attendance.DataSource = attendanceList;
        }
    }
}
