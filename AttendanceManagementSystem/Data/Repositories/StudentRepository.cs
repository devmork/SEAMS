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
        private string connectionString = @"Data Source=Database/SEAMS.db;Version=3;Mode=ReadWrite;";
        public List<Student> GetStudent()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Student;";
                var students = connection.Query<Student>(sql).ToList();
                return students;
            }

        }
        public void AddStudent(Student student)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = @"INSERT INTO Student 
                                (FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email, QRCode)
                                VALUES (@Firstname, @MiddleName, @LastName, @SchoolStudentId, @Course, @Yearlevel, @Email, @QRCodeValue)";

                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", student.FirstName);
                parameters.Add("@MiddleName", student.MiddleName);
                parameters.Add("@LastName", student.LastName);
                parameters.Add("@SchoolStudentId", student.SchoolStudentId);
                parameters.Add("@Course", student.Course);
                parameters.Add("@YearLevel", student.YearLevel);
                parameters.Add("@Email", student.Email);
                parameters.Add("@QRCodeValue", student.QRCodeValue);
                connection.Execute(sql, parameters);
            }
        }

    }
}
