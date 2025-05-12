using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
                string sql = @"INSERT INTO Attendance
                             (AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime)
                             VALUES (@AttendanceName, @AttendanceLocation, @LogType, @Date, @StartTime, @EndTime)";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", $"{attendance.StartTime.Hour:D2}:{attendance.StartTime.Minute:D2}");
                parameters.Add("EndTime", $"{attendance.EndTime.Hour:D2}:{attendance.EndTime.Minute:D2}");
                connection.Execute(sql, parameters); 
            }
        }
        public List<Attendance> GetAllAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "SELECT AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime FROM Attendance";
                return connection.Query<Attendance>(sql).ToList();
            }
        }
        public void DeleteAttendance()
        {
            throw new NotImplementedException();
        }
        public void UpdateAttendance()
        {

            throw new NotImplementedException();
        }
    }
}
