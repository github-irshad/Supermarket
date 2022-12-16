using Microsoft.AspNetCore.Mvc;
using SuperMarket.Api.Employees.Exception;
using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;
using SuperMarket.Service.Employees.Services;

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

    [HttpGet]
    [Route("Enum/CType")]
    public ActionResult<Dictionary<int, string>> GetCompType()
    {
      return Ok(employeeService.GetEnum_ComponentType());
    }

    [HttpGet]
    [Route("Enum/UType")]
    public ActionResult<Dictionary<int, string>> GetUserType()
    {
      return Ok(employeeService.GetEnum_UserType());
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

    public ActionResult AddNewEmployee(AddEmployeeDto newEmployee)  {

      
     
      
      return Ok(employeeService.NewEmployee(newEmployee));

    }
    

    [HttpDelete("Delete/{id}")]
    public ActionResult DeleteEmployee(int id)
    {

      employeeService.DeleteEmployeeService(id);
      return Ok();

    }

    [HttpPut("edit/{id}")]
    public ActionResult EditEmployee(int id, EditEmployee editEmployee)
    {
      employeeService.UpdateEmployeeService(id, editEmployee);
      return Ok();
    }

    [HttpPost("Verify/{id}")]
    public ActionResult VerifyAlter(int id)
    {
      employeeService.ChangeVerification(id);
      return Ok();
    }

  }
}