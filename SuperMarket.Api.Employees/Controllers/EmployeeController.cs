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

    public IEnumerable<Employee> GetAllEmployees()
    {
      return employeeService.GetAllEmployeesService();
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetIndividualEmployee(int id)
    {
      if (ModelState.IsValid)
      {
        return employeeService.EmployeeDashboard(id);
      }
      else
      {
        return Content("Model Mismatch");
      }
    }

    [HttpPost("Add")]

    public ActionResult AddNewEmployee(Employee newEmployee)
    {
      employeeService.NewEmployee(newEmployee);
      return Ok("Added successfully");
    }






  }
}