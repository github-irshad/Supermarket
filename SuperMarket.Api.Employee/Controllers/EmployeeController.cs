using Microsoft.AspNetCore.Mvc;
using SuperMarket.Api.Employee.Interfaces;
using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Controllers
{
  [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManagement employeeManagement;

        public EmployeeController(IEmployeeManagement employeeManagement)
        {
        this.employeeManagement = employeeManagement;
        }

        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            return new JsonResult(employeeManagement.GetAllEmployees()); 
        }


        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = employeeManagement.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddNewEmployee(AddEmployeeModel addEmployeeModel)
        {
            employeeManagement.AddNewEmployee(addEmployeeModel);
            return Ok("Added Successfully");
        }

        [HttpPut("{id}")]

        public IActionResult UpdateEmployee(int id,UpdateEmployeeModel updateEmployeeModel)
        {
            employeeManagement.UpdateEmployee(updateEmployeeModel);
            return Ok("Edited Successfully");
        }

    }
}