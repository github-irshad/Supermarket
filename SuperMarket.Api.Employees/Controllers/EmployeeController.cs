using Microsoft.AspNetCore.Mvc;
// using SuperMarket.Api.Employee.Interfaces;
// using SuperMarket.Api.Employee.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
    //     // private readonly IEmployeeManagement employeeManagement;

    //     // public EmployeeController(IEmployeeManagement employeeManagement)
    //     // {
    //     // this.employeeManagement = employeeManagement;
    //     // }

    //     private readonly IEmployeeService employeeService;
    //     private readonly IDocumentService documentService;

    // public EmployeeController(IEmployeeService employeeService, IDocumentService documentService)
    // {
    //   this.employeeService = employeeService;
    //   this.documentService = documentService;
    // }



    // [HttpGet]
    //     public ActionResult GetAllEmployee()
    //     {
    //         return Ok(employeeService.GetAllEmployeesService()); 
    //     }


    //     [HttpGet("{id}")]
    //     public ActionResult GetEmployeeById(int id)
    //     {
    //         var employee = employeeService.GetEmployeeByIdService(id);
    //         return Ok(employee);
    //     }

    //     // [HttpPost]
    //     // public ActionResult AddNewEmployee(AddEmployeeModel addEmployeeModel)
    //     // {
    //     //     employeeService.AddNewEmployeeService(addEmployeeModel);
    //     //     return Ok("Added Successfully");
    //     // }

    //     // [HttpPut("{id}")]

    //     // public ActionResult UpdateEmployee(int id,UpdateEmployeeModel updateEmployeeModel)
    //     // {
    //     //     employeeService.UpdateEmployeeService(id,updateEmployeeModel);
    //     //     return Ok("Edited Successfully");
    //     // }

    //     [HttpDelete]
    //     public ActionResult DeleteEmployee(int id)
    //     {
    //         employeeService.DeleteEmployeeService(id);
    //         return Ok("Deleted Successfully");
    //     }


    //     [HttpPost]
    //     public IActionResult UploadDocument(IFormFile files)
    //     {
    //         documentService.AddDocumentsService(files);
    //         return Ok("Uploaded successfully");
    //     }

    }
}