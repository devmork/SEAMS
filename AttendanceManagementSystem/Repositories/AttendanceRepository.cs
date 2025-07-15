﻿using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.Linq;
using ZXing.QrCode.Internal;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        public void AddAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                connection.Open();
                string sql = 
                     @"INSERT INTO Attendance
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
        public List<Attendance> GetAllAttendance()
        {
            using (SQLiteConnection connection = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                connection.Open();
                string sql = @"SELECT * FROM Attendance";
                var attendance = connection.Query<Attendance>(sql).ToList();
                return attendance;
            }
        }
        public void DeleteAttendance(int attendanceId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                connection.Open();
                string sql = "DELETE FROM Attendance WHERE AttendanceId = @AttendanceId";
                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendanceId);
                connection.Execute(sql, parameters);
            }
        }
        public void UpdateAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                connection.Open();
                string sql =
                       @"UPDATE Attendance 
                       SET AttendanceName = @AttendanceName, 
                           AttendanceLocation = @AttendanceLocation, 
                           LogType = @LogType, 
                           Date = @Date, 
                           StartTime = @StartTime, 
                           EndTime = @EndTime
                       WHERE AttendanceId = @AttendanceId";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceId", attendance.AttendanceId);
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date.ToString("yyyy-MM-dd"));
                parameters.Add("StartTime", attendance.StartTime.ToString("hh:mm tt"));
                parameters.Add("EndTime", attendance.EndTime.ToString("hh:mm tt"));
                connection.Execute(sql, parameters);
            }
        }
    }
}

