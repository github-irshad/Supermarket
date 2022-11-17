using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Models;

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
      return Ok (employeeService.GetAllEmployeesService());
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetIndividualEmployee(int id)
    {
      try
      {
        return employeeService.EmployeeDashboard(id);
      }
      catch (System.Exception)
      {
        
        return NotFound();
      }
    }

    [HttpPost("Add")]

    public ActionResult AddNewEmployee([FromForm]Employee newEmployee)
    {
      try
      {
        employeeService.NewEmployee(newEmployee);
      return Ok("Added successfully");
      }
      catch (System.Exception)
      {
        
        // throw;
        return new BadRequestResult();
      }
    }






  }
}