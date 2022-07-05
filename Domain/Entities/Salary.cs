using Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Salary: AuditableEntity
    {
        public string EmpolyeeId { get; set; }
        public string EmailId { get; set; }
        public long MobileNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }


        public DateTime AttendanceDate { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public TimeSpan Duration { get; set; }
        public TimeSpan OverTime { get; set; }
        public string Isonleave { get; set; }
        public string LeaveType { get; set; }

        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public DateTime DateofJoining { get; set; }
        public int TotalWorkingDays { get; set; }
        public int LOPDays { get; set; }
        public int PaidDays { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public int BankAccountName { get; set; }
        public string IFSCCode { get; set; }

        // Earnings

        public int Basicsalary { get; set; }
        public int HouseRentAllowances { get; set; }
        public int ConveyanceAllowances { get; set; }
        public int MedicalAllowances { get; set; }
        public int SpecialAllowances { get; set; }
        public int GrossSalary { get; set; }

        // Deductions

        public int EPF { get; set; }
        public int HealthInsurance { get; set; }
        public int Professionaltax { get; set; }
        public int TotalDeductions { get; set; }
        public int NetPay { get; set; }
    }
}
