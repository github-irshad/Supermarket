using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return new JsonResult(employee);
        }

        [HttpPost]
        public IActionResult AddNewEmployee(AddEmployeeModel addEmployeeModel)
        {
            employeeManagement.AddNewEmployee(addEmployeeModel);
            return Ok("Added Successfully");
        }

    }
}