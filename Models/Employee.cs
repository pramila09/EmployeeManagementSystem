using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangementSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public int RoleID { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public int ProjectID { get; set; }
    }
}
