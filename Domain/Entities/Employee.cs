using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee: AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public DateTime DateOfBirth { get; set; }
        public long MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string JobRole { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string ProfilePhoto { get; set; }






         
    }
}
