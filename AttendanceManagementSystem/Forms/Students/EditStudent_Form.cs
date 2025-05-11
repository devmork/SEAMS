using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AttendanceManagementSystem.Models.Base;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Data.Repositories;

namespace AttendanceManagementSystem.Forms.Students
{
	public partial class EditStudent_Form: DevExpress.XtraEditors.XtraForm
	{
        private readonly IStudentsRepository _studentRepository;
        private readonly IQRCodeService _qrCodeService;
        private readonly Student _student;
        public EditStudent_Form(Student student = null)
		{
            InitializeComponent();
            _studentRepository = new StudentRepository();
            _qrCodeService = new QRCodeService();
            _student = student;
            if (_student != null)
            {
                LoadStudentData();
            }
        }
        private void LoadStudentData()
        {
            txt_FirstName.Text = _student.FirstName;
            txt_MiddleName.Text = _student.MiddleName;
            txt_LastName.Text = _student.LastName;
            txt_SchoolStudentId.Text = _student.SchoolStudentId;
            se_YearLevel.Value = _student.YearLevel;
            cbe_Course.Text = _student.Course;
            txt_EmailAddress.Text = _student.Email;

            if (_student.QRCode != null)
            {
                using (var ms = new System.IO.MemoryStream(_student.QRCode))
                {
                    pe_QRCode.Image = Image.FromStream(ms);
                }
            }
        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            _qrCodeService.GenerateQRCode(_student.SchoolStudentId);
            pe_QRCode.Image = _qrCodeService.GetQRCodeImage();
            _student.QRCode = _qrCodeService.GetQRCodeByteArray();


        }
        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            _student.FirstName = txt_FirstName.Text;
            _student.MiddleName = txt_MiddleName.Text;
            _student.LastName = txt_LastName.Text;
            _student.SchoolStudentId = txt_SchoolStudentId.Text;
            _student.YearLevel = (int)se_YearLevel.Value;
            _student.Course = cbe_Course.Text;
            _student.Email = txt_EmailAddress.Text;

            _studentRepository.UpdateStudent(_student);
            XtraMessageBox.Show("Student updated successfully.");
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}