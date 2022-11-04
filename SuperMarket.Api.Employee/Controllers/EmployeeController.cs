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
        public ActionResult GetAllEmployee()
        {
            return new JsonResult(employeeManagement.GetAllEmployees()); 
        }


        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employee = employeeManagement.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult AddNewEmployee(AddEmployeeModel addEmployeeModel)
        {
            employeeManagement.AddNewEmployee(addEmployeeModel);
            return Ok("Added Successfully");
        }

        [HttpPut("{id}")]

        public ActionResult UpdateEmployee(int id,UpdateEmployeeModel updateEmployeeModel)
        {
            employeeManagement.UpdateEmployee(id,updateEmployeeModel);
            return Ok("Edited Successfully");
        }

        [HttpDelete]
        public ActionResult DeleteEmployee(int id)
        {
            employeeManagement.DeleteEmployee(id);
            return Ok("Deleted Successfully");
        }

    }
}