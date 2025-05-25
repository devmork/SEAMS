using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Models.Base
{
    public class AttendanceRecords
    {
        public int RecordId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Remarks { get; set; }
    }
}
