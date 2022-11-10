using Microsoft.AspNetCore.Mvc;
// using SuperMarket.Api.Employee.Interfaces;
// using SuperMarket.Api.Employee.Models;
using SuperMarket.Service.Employee.Interfaces;

namespace SuperMarket.Api.Employee.Controllers
{
  [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // private readonly IEmployeeManagement employeeManagement;

        // public EmployeeController(IEmployeeManagement employeeManagement)
        // {
        // this.employeeManagement = employeeManagement;
        // }

        private readonly IEmployeeService employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
      this.employeeService = employeeService;
    }



    [HttpGet]
        public ActionResult GetAllEmployee()
        {
            return Ok(employeeService.GetAllEmployeesService()); 
        }


        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employee = employeeService.GetEmployeeByIdService(id);
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


        [HttpPost]
        public IActionResult UploadDocument(IFormFile files)
        {
            employeeManagement.AddDocuments(files);
            return Ok("Uploaded successfully");
        }

    }
}