using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using ZXing;
using System.Drawing.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using System.Data;
using AttendanceManagementSystem.Models.Base;

namespace AttendanceManagementSystem.Forms.Students
{
    public partial class AddStudent_Form : DevExpress.XtraEditors.XtraForm
    {
        public AddStudent_Form()
        {
            InitializeComponent();
        }

        private Student student;
        //private string connectionString = @"Data Source=.\Data\SEAMS.db;Version=3;";
        private string connectionString = @"Data Source=.\Data\SEAMS.db;Version=3;Journal Mode=WAL;";

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

                SQLiteCommand cmd = new SQLiteCommand(sql, connection);

                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@SchoolStudentId", student.SchoolStudentId);
                cmd.Parameters.AddWithValue("@Course", student.Course);
                cmd.Parameters.AddWithValue("@YearLevel", student.YearLevel);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@QRCode", student.QRCode.QRCodeValue);
                cmd.ExecuteNonQuery();
                
            }

            XtraMessageBox.Show("Student data saved successfully!");

        }
    }
}