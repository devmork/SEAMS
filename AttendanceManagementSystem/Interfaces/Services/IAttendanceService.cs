using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Interfaces.Services
{
    public interface IAttendanceService
    {
        void RecordAttendance(int attendanceId, string attendanceName, string logType, string schoolStudentId);
        int GetTotalAbsent(string schoolStudentId);
        int GetTotalPresent(string schoolStudentId);
    }
}
