using EmployeeMangementSystem.DataAccess;
using EmployeeMangementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangementSystem.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;
        public EmployeeController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _dataAccessProvider.GetEmployeesRecord();
        }
        [HttpPost]
        public IActionResult Create([FromBody]Employee employee)
        {
            if(ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                _dataAccessProvider.AddEmployee(employee);
                return Ok();

            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Edit([FromBody]Employee employee)
        {
            if(ModelState.IsValid)
            {
                _dataAccessProvider.UpdateEmployee(employee);
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{EmployeeID}")]
        public IActionResult DeleteConfirmed(int EmployeeID)
        {
            var data = _dataAccessProvider.GetEmployeeSingleRecord(EmployeeID);
            if(data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteEmployee(EmployeeID);
            return Ok();
        }
    }
}
