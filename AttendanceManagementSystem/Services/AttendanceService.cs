using AttendanceManagementSystem.Interfaces.Services;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Services
{
    public class AttendanceService : IAttendanceService
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public void RecordAttendance(int attendanceId, string attendanceName, string logType, string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                var parameters = new DynamicParameters();

                // Check if attendance id exist
                string checkAttendanceSql = "SELECT COUNT(AttendanceId) FROM Attendance WHERE AttendanceId = @AttendanceId";
                if (connection.ExecuteScalar<int>(checkAttendanceSql, parameters) == 0)
                {
                    throw new Exception("Invalid AttendanceId.");
                }

                // Check if student id exist
                string checkStudentIdSql = "SELECT COUNT SchoolStudentId FROM Student WHERE SchoolStudentId = @SchoolStudentId";
                if (connection.ExecuteScalar<int>(checkStudentIdSql, parameters) == 0)
                {
                    throw new Exception("Invalid school student id.");
                }

                // Check for duplicate attendance record
                string checkDuplicateSql = "SELECT COUNT AttendanceId, SchoolStudentId FROM AttendanceRecords WHERE AttendanceId = @AttendanceId AND SchoolStudentId = @SchoolStudentId AND DATE(Timestamp) = DATE('now')";
                if (connection.ExecuteScalar<int>(checkDuplicateSql, parameters) > 0)
                {
                    throw new Exception("Attendance already recorded for this student today.");
                }

                string sql = @"INSERT INTO AttendanceRecords (AttendanceId, AttendanceName, LogType, SchoolStudentId, Timestamp) 
                               VALUES (@AttendanceId, @AttendanceName, @LogType, @SchoolStudentId, @Timestamp)";

                parameters.Add("AttendanceId", attendanceId);
                parameters.Add("AttendanceName", attendanceName);
                parameters.Add("LogType", logType);
                parameters.Add("SchoolStudentId", schoolStudentId);
                parameters.Add("Timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                connection.Execute(sql, parameters);
            }   
        }
        public int GetTotalAbsent(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"SELECT AttendanceId FROM Attendance
                               JOIN AttendanceRecords ON AttendanceRecords.AttendanceId = Attendance.AttendanceId
                               WHERE AttendanceRecords.SchoolStudentId = @SchoolStudentId";

                return connection.ExecuteScalar<int> (sql);
            }
        }
        public int GetTotalPresent(string schoolStudentId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"SELECT COUNT (AttendanceId) FROM AttendanceRecords WHERE SchoolStudentId = @SchoolStudentId";

                var parameters = new DynamicParameters();
                parameters.Add("SchoolStudentId", schoolStudentId);
                return connection.ExecuteScalar<int>(sql, parameters);
            }
        }
    }
}
