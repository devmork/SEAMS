using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Models.Base
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SchoolStudentId { get; set; }
        public int YearLevel { get; set; }
        public string Course { get; set; }
        public byte[] QRCode { get; set; }

    }
}
