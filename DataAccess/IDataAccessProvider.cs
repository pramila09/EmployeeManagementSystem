using EmployeeMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangementSystem.DataAccess
{
    interface IDataAccessProvider
    {
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int EmployeeID);
        Employee GetEmployeeSingleRecord(int EmployeeID);
        List<Employee> GetEmployeesRecord();
    }
}
