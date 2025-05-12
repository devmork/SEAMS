using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class StudentRepository : IStudentsRepository
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public BindingList<Student> GetAllStudent()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "SELECT FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email, QRCode FROM Student;";
                var students = connection.Query<Student>(sql).ToList();
                return new BindingList<Student>(students);
            }
        }
        public void AddStudent(Student student)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"INSERT INTO Student (FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email, QRCode)
                             VALUES (@FirstName, @MiddleName, @LastName, @SchoolStudentId, @Course, @YearLevel, @Email, @QRCode)";

                var parameters = new DynamicParameters();
                parameters.Add("@FirstName", student.FirstName);
                parameters.Add("@MiddleName", student.MiddleName);
                parameters.Add("@LastName", student.LastName);
                parameters.Add("@SchoolStudentId", student.SchoolStudentId);
                parameters.Add("@Course", student.Course);
                parameters.Add("@YearLevel", student.YearLevel);
                parameters.Add("@Email", student.Email);
                parameters.Add("@QRCode", student.QRCode); // Fails if QRCode is null
                connection.Execute(sql, parameters);
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"UPDATE Student 
                             SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, 
                                 SchoolStudentId = @SchoolStudentId, Course = @Course, YearLevel = @YearLevel, 
                                 Email = @Email, QRCode = @QRCode
                             WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Id", student.PersonId);
                parameters.Add("@FirstName", student.FirstName);
                parameters.Add("@MiddleName", student.MiddleName);
                parameters.Add("@LastName", student.LastName);
                parameters.Add("@SchoolStudentId", student.SchoolStudentId);
                parameters.Add("@Course", student.Course);
                parameters.Add("@YearLevel", student.YearLevel);
                parameters.Add("@Email", student.Email);
                parameters.Add("@QRCode", student.QRCode);
                connection.Execute(sql, parameters);
            }
        }
    }
}
