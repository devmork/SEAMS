using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Models.Base
{
    public class Attendance
    {
        public Guid AttendanceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime{ get; set; }
        public bool IsActive { get; set; }
    }
}
