using System;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;
using System.IO;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class AddStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly IQRCodeService _qrCodeService;
        private Student student;
        public AddStudent_Form()
        {
            InitializeComponent();
            _studentsRepository = new StudentRepository();
            _qrCodeService = new QRCodeRepository();
        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                string.IsNullOrWhiteSpace(txt_SchoolStudentId.Text))
            {
                XtraMessageBox.Show("Please fill in all required fields (First Name, Last Name, School ID).");
                return;
            }
            try
            {
                student = new Student
                (
                    firstName: txt_FirstName.Text,
                    middleName: txt_MiddleName.Text,
                    lastName: txt_LastName.Text,
                    schoolStudentId: txt_SchoolStudentId.Text,
                    yearLevel: (int)se_YearLevel.Value,
                    course: cbe_Course.Text,
                    email: txt_EmailAddress.Text
                );
                // Generate QR code  
                _qrCodeService.GenerateQRCode(student.SchoolStudentId);
                pe_QRCode.Image = _qrCodeService.GetQRCodeImage();
                student.QRCodeImage = _qrCodeService.GetQRCodeByteArray();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error generating QR code: {ex.Message}");
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                XtraMessageBox.Show("Please generate a QR code before saving.");
                return;
            }
            try
            {
                _studentsRepository.AddStudent(student);
                XtraMessageBox.Show("Student saved successfully.");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Error saving student: {ex.Message}");
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}