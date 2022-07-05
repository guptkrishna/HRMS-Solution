using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Leave: AuditableEntity
    {
        public DateTime ApplicationDate { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string LeaveReason { get; set; }
        public DateTime LeaveDateFrom { get; set; }
        public DateTime LeaveDateTo { get; set; }
        public string Comments { get; set; }
    }
}
