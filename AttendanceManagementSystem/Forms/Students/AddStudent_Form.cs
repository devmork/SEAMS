using System;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using AttendanceManagementSystem.Models.Base;
using Dapper;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class AddStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        public AddStudent_Form()
        {
            InitializeComponent();
        }

        private Student student;
        private string connectionString = @"Data Source=Data/SEAMS.db;Version=3;Mode=ReadWrite;";

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_FirstName.Text) ||
                    string.IsNullOrWhiteSpace(txt_LastName.Text) ||
                    string.IsNullOrWhiteSpace(txt_SchoolStudentId.Text))
                {
                    XtraMessageBox.Show("Please fill in all required fields (First Name, Last Name, School ID).");
                    return;
                }

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
                pe_QRCode.Image = student.QRCode.GenerateQRCode();
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

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();
                string sql = @"INSERT INTO Student
                                 (FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email, QRCode)
                                 VALUES (@FirstName, @MiddleName, @LastName, @SchoolStudentId, @Course, @YearLevel, @Email, @QRCode)";

                var parameters = new DynamicParameters();
                parameters.Add("FirstName", student.FirstName);
                parameters.Add("MiddleName", student.MiddleName);
                parameters.Add("LastName", student.LastName);
                parameters.Add("SchoolStudentId", student.SchoolStudentId);
                parameters.Add("Course", student.Course);
                parameters.Add("YearLevel", student.YearLevel);
                parameters.Add("Email", student.Email);
                parameters.Add("QRCode", student.QRCode.QRCodeValue);
                connection.Execute(sql, parameters);
            }

            XtraMessageBox.Show("Student saved successfully.");

        }
    }
}