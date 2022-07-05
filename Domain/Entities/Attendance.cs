using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Attendance: AuditableEntity
    {
        public DateTime AttendanceDate { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan OverTime { get; set; }
        public string Isonleave { get; set; }
        public string LeaveType { get; set; }
    }
}
