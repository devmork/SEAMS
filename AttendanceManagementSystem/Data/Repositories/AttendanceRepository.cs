using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private string _connectionStrng = "Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";

        public void AddAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = 
                     @"INSERT INTO Attendance
                     (AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime, Status)
                     VALUES (@AttendanceName, @AttendanceLocation, @LogType, @Date, @StartTime, @EndTime, @Status)";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                parameters.Add("Status", attendance.Status ? 1 : 0);
                connection.Execute(sql, parameters);
            }
        }
        public List<Attendance> GetAllAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = 
                    @"SELECT AttendanceId, AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime
                    FROM Attendance";
                var attendance = connection.Query<Attendance>(sql).ToList();
                return attendance;
            }
        }
        public void DeleteAttendance(int attendanceId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "DELETE FROM Attendance WHERE AttendanceId = @AttendanceId";
                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendanceId);  // 'attendanceId' matches the parameter name
                connection.Execute(sql, parameters);
            }
        }
        public void UpdateAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql =
                       @"UPDATE Attendance 
                       SET AttendanceName = @AttendanceName, 
                           AttendanceLocation = @AttendanceLocation, 
                           LogType = @LogType, 
                           Date = @Date, 
                           StartTime = @StartTime, 
                           EndTime = @EndTime,
                           Status = @Status
                       WHERE AttendanceId = @AttendanceId";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendance.AttendanceId);
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                parameters.Add("Status", attendance.Status ? 1 : 0); // Add Status parameter
                parameters.Add("AttendanceId", attendance.AttendanceId);
                connection.Execute(sql, parameters);
            }
        }
        public int GetTotalAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"SELECT COUNT(AttendanceName) FROM Attendance";
                return connection.ExecuteScalar<int>(sql);
            }
        }
    }
}

