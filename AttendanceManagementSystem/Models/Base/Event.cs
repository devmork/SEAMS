using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Models.Base
{
    public class Event
    {
        public int EventId{ get; set; }
        public string EventName { get; set; }
        public string EventLocation { get; set; }

        public Event (string eventName, string evenLocation)
        {
            EventName = string.Empty;
            EventLocation = string.Empty;
        }

    }
}
