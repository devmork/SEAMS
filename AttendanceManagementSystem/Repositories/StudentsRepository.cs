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
    public class StudentsRepository : IStudentsRepository
    {
        private string _connectionString = SQLiteDataAccess.LoadConnectionString();
        public List<Student> GetAllStudent()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT FirstName, MiddleName, LastName, SchoolStudentId, Course, YearLevel, Email FROM Student;";
                var students = connection.Query<Student>(sql).ToList();
                return students;
            }
        }
        public void AddStudent(Student student)
        {
            using (var connection = new SQLiteConnection(_connectionString))
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
                parameters.Add("@QRCode", student.QRCode);
                connection.Execute(sql, parameters);
            }
        }
        public void UpdateStudent(Student student)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = @"UPDATE Student 
                             SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, 
                                 SchoolStudentId = @SchoolStudentId, Course = @Course, YearLevel = @YearLevel, 
                                 Email = @Email, QRCode = @QRCode
                             WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("@Id", student.Id);
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
        public int GetTotalStudents()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = @"SELECT COUNT(SchoolStudentId) FROM Student";
                return connection.ExecuteScalar<int>(sql);
            }
        }
        public Student GetStudentById(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT SchoolStudentId, FirstName, MiddleName, LastName, QRCode, Course, YearLevel FROM Student WHERE SchoolStudentId = @SchoolStudentId";
                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                return connection.QueryFirstOrDefault<Student>(sql, parameters);
            }
        }
        public bool CheckIfStudentIdExist(string schoolStudentId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT COUNT(1) FROM Student WHERE SchoolStudentId = @SchoolStudentId";
                var count = connection.ExecuteScalar<int>(query, new { SchoolStudentId = schoolStudentId });
                return count > 0;
            }
        }

        public List<Student> GetStudentQRCode(string schoolStudentId)
        {
            string sql = "SELECT QRCode FROM Student WHERE SchoolStudentId = @SchoolStudentId";
            
            var parameters = new DynamicParameters();
            parameters.Add("SchoolStudentId", schoolStudentId);

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<Student>(sql, parameters).ToList();
            }
        }
    }
}
