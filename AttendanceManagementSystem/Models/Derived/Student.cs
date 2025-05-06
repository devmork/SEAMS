using AttendanceManagementSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;

namespace AttendanceManagementSystem.Models.Base
{
    public class Student : Person
    {
        public string SchoolStudentId { get; set; }
        public int YearLevel { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public byte[] QRCodeImage { get; set; }
        public Student(string firstName, string middleName, string lastName, string schoolStudentId, int yearLevel, string course, string email) 
            : base(firstName, middleName, lastName)
        {
            SchoolStudentId = schoolStudentId;
            YearLevel = yearLevel;
            Course = course;
            Email = email;
            QRCodeImage = null;        // Will be set when QR code is generated
        }
    }
}
