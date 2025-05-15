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
                string sql = @"INSERT INTO Attendance
                     (AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime)
                     VALUES (@AttendanceName, @AttendanceLocation, @LogType, @Date, @StartTime, @EndTime)";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                connection.Execute(sql, parameters);
            }
        }
        //public List<Attendance> GetAllAttendance()
        //{
        //    using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
        //    {
        //        connection.Open();
        //        string sql = "SELECT AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime FROM Attendance";
        //        return connection.Query<Attendance>(sql).ToList();
        //    }
        //}
        public List<Attendance> GetAllAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = "SELECT AttendanceId, AttendanceName, AttendanceLocation, LogType, Date, StartTime, EndTime FROM Attendance";
                return connection.Query<Attendance>(sql).ToList();
            }
        }
        public void DeleteAttendance()
        {
            //using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            //{
            //    connection.Open();
            //    string sql = "DELETE FROM Attendance WHERE Id = @Id";

            //}

            throw new NotImplementedException();
        }

        public void UpdateAttendance(Attendance attendance)
        {
            //using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            //{
            //    connection.Open();
            //    string sql = @"UPDATE Attendance 
            //           SET AttendanceName = @AttendanceName, 
            //               AttendanceLocation = @AttendanceLocation, 
            //               LogType = @LogType, 
            //               Date = @Date, 
            //               StartTime = @StartTime, 
            //               EndTime = @EndTime 
            //           WHERE AttendanceId = @AttendanceId";

            //    var parameters = new DynamicParameters();
            //    parameters.Add("AttendanceName", attendance.AttendanceName);
            //    parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
            //    parameters.Add("LogType", attendance.LogType);
            //    parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
            //    parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
            //    parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
            //    parameters.Add("AttendanceId", attendance.AttendanceId);

            //    connection.Execute(sql, parameters);
            //}

            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"UPDATE Attendance 
                       SET AttendanceName = @AttendanceName, 
                           AttendanceLocation = @AttendanceLocation, 
                           LogType = @LogType, 
                           Date = @Date, 
                           StartTime = @StartTime, 
                           EndTime = @EndTime 
                       WHERE AttendanceId = @AttendanceId";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                parameters.Add("AttendanceId", attendance.AttendanceId);

                int rowsAffected = connection.Execute(sql, parameters);
                if (rowsAffected == 0)
                {
                    throw new Exception($"No attendance record found with AttendanceId: {attendance.AttendanceId}");
                }
            }

            //using (var connection = new SQLiteConnection(_connectionStrng))
            //{
            //    connection.Open();
            //    string query = "UPDATE Attendance SET AttendanceName = @AttendanceName, AttendanceLocation =
            //                    @AttendanceLocation, LogType = @LogType, Date = @Date, StartTime = @StartTime,
            //                    EndTime = @EndTime WHERE AttendanceId = @AttendanceId";
            //    int rowsAffected = connection.Execute(query, attendance);
            //    if (rowsAffected == 0)
            //    {
            //        throw new Exception($"Update failed for AttendanceId: {attendance.AttendanceId}");
            //    }
            //}
        }
    }
}

