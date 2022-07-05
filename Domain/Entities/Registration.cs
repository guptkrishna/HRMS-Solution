using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Registration: AuditableEntity
    {
        public string EmpolyeeId { get; set; }
        public string EmailId { get; set; }
        public long MobileNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
