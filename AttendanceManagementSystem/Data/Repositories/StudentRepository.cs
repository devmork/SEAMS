using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class StudentRepository : IStudentsRepository
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public List<Student> GetAllStudent()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "SELECT * FROM Student;";
                var students = connection.Query<Student>(sql).ToList();
                return students;
            }

        }
        public void AddStudent(Student student)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "INSERT INTO Student (FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email, QRCode) " +
                    "VALUES (@FirstName, @MiddleName, @LastName, @SchoolStudentId, @Course, @YearLevel, @Email, @QRCode)",
                    connection);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@SchoolStudentId", student.SchoolStudentId);
                command.Parameters.AddWithValue("@Course", student.Course);
                command.Parameters.AddWithValue("@YearLevel", student.YearLevel);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@QRCode", student.QRCodeImage); // Fails if QRCode is null
                command.ExecuteNonQuery();
            }
        }

    }
}
