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
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace AttendanceManagementSystem.Forms.Events
{
    public partial class Attendance_UserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public Attendance_UserControl()
        {
            InitializeComponent();
            _attendanceRepository = new AttendanceRepository();
            LoadData();
        }
        private void Attendance_UserControl_Load(object sender, EventArgs e)
        {
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

            if (addAttendance_Form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void repositoryItem_ActionButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                Attendance selectedRow = gv_Attendance.GetFocusedRow() as Attendance;

                if (selectedRow != null)
                {
                    EditAttendance_Form editAttendance_Form = new EditAttendance_Form(selectedRow);
                    if (editAttendance_Form.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            else if (e.Button.Index == 1)
            {
                if (XtraMessageBox.Show("Are you sure you want to delete this attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Attendance selectedRow = gv_Attendance.GetFocusedRow() as Attendance;

                    if (selectedRow != null)
                    {
                        _attendanceRepository.DeleteAttendance(selectedRow.AttendanceId);
                        XtraMessageBox.Show("Attendance deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();

                    }
                }
            }
        }
        private void LoadData()
        {
            gc_Attendance.DataSource = _attendanceRepository.GetAllAttendance();
        }
    }
}
