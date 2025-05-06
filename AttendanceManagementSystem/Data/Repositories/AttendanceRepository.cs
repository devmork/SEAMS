using AttendanceManagementSystem.Interfaces.Repositories;
using AttendanceManagementSystem.Models.Base;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Data.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private string _connectionStrng ="Data Source=SEAMS.db;Version=3;Mode=ReadWrite;";
        public void AddAttendance(Attendance attendance)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionStrng))
            {
                connection.Open();
                string sql = @"INSERT INTO Attendance
                                 (AttendanceName, AttendanceLocation, TimeOfDay, LogType, Date, StartTime, EndTime)
                                 VALUES (@AttendanceName, @AttendanceLocation, @TimeOfDay, @LogType, @Date, @StartTime, @EndTime)";

                var parameters = new DynamicParameters();
                parameters.Add("AttendanceName", attendance.AttendanceName);
                parameters.Add("AttendanceLocation", attendance.AttendanceLocation);
                parameters.Add("TimeOfDay", attendance.TimeOfDay);
                parameters.Add("LogType", attendance.LogType);
                parameters.Add("Date", attendance.Date);
                parameters.Add("StartTime", attendance.StartTime);
                parameters.Add("EndTime", attendance.EndTime);
                connection.Execute(sql, parameters); 
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
