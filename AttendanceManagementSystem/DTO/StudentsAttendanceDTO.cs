using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.DTO
{
    public class StudentsAttendanceDTO
    {
        public string SchoolStudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string YearLevel { get; set; }
        public int TotalAbsent { get; set; }
    }
}
