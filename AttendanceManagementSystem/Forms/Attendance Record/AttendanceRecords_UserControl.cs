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
using System.Data.SqlTypes;
using System.IO;
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Forms.Attendance_Record
{
	public partial class AttendanceRecords_UserControl: DevExpress.XtraEditors.XtraUserControl
	{
		private readonly IStudentsRepository _studentsRepository;
        private readonly IQRCodeService _qrCodeService;
        public AttendanceRecords_UserControl()
		{
            InitializeComponent();
			_studentsRepository = new StudentRepository();
            _qrCodeService = new QRCodeService();
            LoadStudents();
        }
        private void repositoryItemButton_Action_Click(object sender, EventArgs e)
        {
            StudentAttendanceRecord_Form studentAttendanceRecord_Form = new StudentAttendanceRecord_Form();
            studentAttendanceRecord_Form.ShowDialog();
        }
        private void LoadStudents()
        {
            gc_AttendanceRecords.DataSource = _studentsRepository.GetAllStudent();
        }
        private void gv_AttendanceRecords_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txt_SchoolStudentId.Text = gv_AttendanceRecords.GetFocusedRowCellValue("SchoolStudentId").ToString();
            txt_Name.Text = gv_AttendanceRecords.GetFocusedRowCellValue("FullName").ToString();
            txt_Email.Text = gv_AttendanceRecords.GetFocusedRowCellValue("Email").ToString();
            txt_Course.Text = gv_AttendanceRecords.GetFocusedRowCellValue("Course").ToString();
            txt_YearLevel.Text = gv_AttendanceRecords.GetFocusedRowCellValue("YearLevel").ToString();
            var qrCodeValue = gv_AttendanceRecords.GetFocusedRowCellValue("QRCode");

            if (qrCodeValue != null && qrCodeValue is byte[] qrBytes)
            {
                using (MemoryStream ms = new MemoryStream(qrBytes))
                {
                    pe_QRCode.Image = Image.FromStream(ms);
                }
            }
        }
        private void cbe_Course_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCourse = cbe_Course.SelectedItem.ToString();
            gv_AttendanceRecords.ActiveFilterString = $"[Course] = '{selectedCourse}'";
        }
        private void cbe_YearLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedYearLevel = cbe_YearLevel.SelectedItem.ToString();
            gv_AttendanceRecords.ActiveFilterString = $"[YearLevel] = '{selectedYearLevel}'";
        }

        private void findPanel_TextChanged(object sender, EventArgs e)
        {
            string searchStudentId = findPanel.Text.ToString();

            if (string.IsNullOrEmpty(searchStudentId))
            {
                gv_AttendanceRecords.ActiveFilterString = "";
            }
            else
            {
                gv_AttendanceRecords.ActiveFilterString = $"[SchoolStudentId] = '{searchStudentId}'";
            }
        }
    }
}
