using EmployeeMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangementSystem.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.employees.Add(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int EmployeeID)
        {
            var entity = _context.employees.FirstOrDefault(t => t.EmployeeID == EmployeeID);
            _context.employees.Remove(entity);
            _context.SaveChanges();
        }

        public Employee GetEmployeeSingleRecord(int EmployeeID)
        {
            return _context.employees.FirstOrDefault(t => t.EmployeeID == EmployeeID);
        }

        public List<Employee> GetEmployeesRecord()
        {
            return _context.employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
