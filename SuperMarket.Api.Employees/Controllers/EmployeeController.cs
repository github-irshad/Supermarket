using Microsoft.AspNetCore.Mvc;
using SuperMarket.Api.Employees.Exception;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("Employee")]
  public class EmployeeController : ControllerBase
  {

    private readonly IEmployeeService employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
      this.employeeService = employeeService;
    }



    [HttpGet("All")]

    public ActionResult<IEnumerable<Employee>> GetAllEmployees()
    {
      // throw new System.Exception("test");
      return Ok(employeeService.GetAllEmployeesService());
    }



    [HttpGet("{id}")]
    public ActionResult<Employee> GetIndividualEmployee(int id)
    {
      
        return employeeService.EmployeeDashboard(id);
     
    }



    [HttpPost("Add")]

    public ActionResult AddNewEmployee( AddEmployeeDto newEmployee)
    {
      
        employeeService.NewEmployee(newEmployee);
        return Ok("Added");
    
    }

    [HttpDelete("Delete/{id}")]
    public ActionResult DeleteEmployee(int id){
      
        employeeService.DeleteEmployeeService(id);
        return Ok();
      
    }

    [HttpPut("id")]
    public ActionResult EditEmployee(int id,EditEmployee editEmployee){
      employeeService.UpdateEmployeeService(id,editEmployee);
      return Ok();
    }

    [HttpPost("Verify")]
    public ActionResult VerifyAlter(int id){
      employeeService.ChangeVerification(id);
      return Ok();
    }

  }
}