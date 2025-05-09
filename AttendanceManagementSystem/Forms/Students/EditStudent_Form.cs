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

namespace AttendanceManagementSystem.Forms.Students
{
	public partial class EditStudent_Form: DevExpress.XtraEditors.XtraForm
	{
        public readonly IStudentsRepository _studentRepository;
        private readonly Student _student;
        public EditStudent_Form(Student student = null)
		{
            InitializeComponent();
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
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}