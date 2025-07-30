using System;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class AddStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly Student student = new Student();
        public AddStudent_Form()
        {
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_SchoolStudentId.Text) ||
                string.IsNullOrWhiteSpace(cbe_YearLevel.Text) ||
                string.IsNullOrWhiteSpace(cbe_Course.Text) ||
                string.IsNullOrWhiteSpace(txt_EmailAddress.Text))
            {
                XtraMessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_studentsRepository.CheckIfStudentIdExist(txt_SchoolStudentId.Text))
            {
                XtraMessageBox.Show($"A student with this ID: {txt_SchoolStudentId.Text} already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            student.FirstName = txt_FirstName.Text;
            student.MiddleName = txt_MiddleName.Text;
            student.LastName = txt_LastName.Text;
            student.SchoolStudentId = txt_SchoolStudentId.Text;
            student.YearLevel = cbe_YearLevel.Text;
            student.Course = cbe_Course.Text;
            student.Email = txt_EmailAddress.Text;
            student.QRCode = QRCodeService.GetQRCodeByteArray();

            try
            {
                _studentsRepository.AddStudent(student);
                XtraMessageBox.Show("Student saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving student: {ex.Message}");
            }
        }
        private void txt_SchoolStudentId_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_SchoolStudentId.Text))
            {
                btn_Add.Enabled = true;
                QRCodeService.GenerateQRCode(txt_SchoolStudentId.Text);
                pe_QRCode.Image = QRCodeService.GetQRCodeImage();
                student.QRCode = QRCodeService.GetQRCodeByteArray();
            }
            else
            {
                btn_Add.Enabled = false;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearFields()
        {
            txt_FirstName.Text = string.Empty;
            txt_MiddleName.Text = string.Empty;
            txt_LastName.Text = string.Empty;
            txt_SchoolStudentId.Text = string.Empty;
            cbe_YearLevel.SelectedIndex = -1;
            cbe_Course.SelectedIndex = -1;
            txt_EmailAddress.Text = string.Empty;
            pe_QRCode.Image = null;
        }
    }
}