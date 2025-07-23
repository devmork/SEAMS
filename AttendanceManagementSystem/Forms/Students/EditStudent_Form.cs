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
    public partial class EditStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly Student _student;
        public EditStudent_Form(Student student)
        {
            InitializeComponent();
            _studentsRepository = new StudentsRepository();
            _student = student;
        }
        private void EditStudent_Form_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
        private void LoadStudentData()
        {
            txt_FirstName.Text = _student.FirstName;
            txt_MiddleName.Text = _student.MiddleName;
            txt_LastName.Text = _student.LastName;
            txt_SchoolStudentId.Text = _student.SchoolStudentId;
            cbe_YearLevel.Text = _student.YearLevel;
            cbe_Course.Text = _student.Course;
            txt_EmailAddress.Text = _student.Email;
            pe_QRCode.Image = QRCodeService.FetchQRCodeImage(_student.SchoolStudentId, _studentsRepository);

        }
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            QRCodeService.GenerateQRCode(txt_SchoolStudentId.Text);
            pe_QRCode.Image = QRCodeService.GetQRCodeImage();
            _student.QRCode = QRCodeService.GetQRCodeByteArray();
        }
        private void btn_SaveChanges_Click(object sender, EventArgs e)
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
            //if (txt_SchoolStudentId.Text != _student.SchoolStudentId && _studentsRepository.CheckIfStudentIdExist(txt_SchoolStudentId.Text))
            //{
            //    XtraMessageBox.Show($"A student with this {txt_SchoolStudentId.Text}  already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            _student.FirstName = txt_FirstName.Text;
            _student.MiddleName = txt_MiddleName.Text;
            _student.LastName = txt_LastName.Text;
            _student.SchoolStudentId = txt_SchoolStudentId.Text;
            _student.YearLevel = cbe_YearLevel.Text;
            _student.Course = cbe_Course.Text;
            _student.Email = txt_EmailAddress.Text;

            _studentsRepository.UpdateStudent(_student);
            XtraMessageBox.Show("Student info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_SchoolStudentId_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_SchoolStudentId.Text != _student.SchoolStudentId)
            {
                QRCodeService.GenerateQRCode(txt_SchoolStudentId.Text);
                pe_QRCode.Image = QRCodeService.GetQRCodeImage();
                _student.QRCode = QRCodeService.GetQRCodeByteArray();
                btn_Generate.Enabled = true;
                btn_SaveChanges.Enabled = true;
            }
            else
            {
                btn_Generate.Enabled = false;
                btn_SaveChanges.Enabled = false;
            }
        }
        private void txt_SchoolStudentId_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (_studentsRepository.CheckIfStudentIdExist(txt_SchoolStudentId.Text))
            {
                btn_SaveChanges.Enabled = false;
                XtraMessageBox.Show($"A student with this {txt_SchoolStudentId.Text}  already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                btn_SaveChanges.Enabled = true;
            }
        }
    }
}