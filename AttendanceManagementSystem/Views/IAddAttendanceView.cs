using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Views
{
    public interface IAddAttendanceView
    {

        // MODELS
        int AttendanceId { get; set; }
        string AttendanceName { get; set; } 
        string AttendanceLocation { get; set; }
        string LogType { get; set; }
        DateTime Date { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        event EventHandler CreateAttendance;

        void CloseForm();
        void Cancel();
        void ClearFields();
    }
}
