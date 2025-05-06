using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Models.Base
{
    public class Attendance : Event
    {
        public Guid AttendanceId { get; set; }
        public string AttendanceName { get; set; }
        public string AttendanceLocation { get; set; }
        public string TimeOfDay { get; set; }
        public string LogType { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Attendance(string eventName, string eventLocation, string attendanceLocation, string timeOfDay, string logType, DateTime date, DateTime startTime, DateTime endTime) 
            : base(eventName, eventLocation)
        {
            AttendanceLocation = attendanceLocation;
            TimeOfDay = timeOfDay;
            LogType = logType;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
        }

    }
}
