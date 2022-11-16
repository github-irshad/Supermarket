using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Models;
// using SuperMarket.Api.Employee.Interfaces;
// using SuperMarket.Api.Employee.Models;
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

    [HttpGet]

    public IEnumerable<Employee> GetEmployees()
    {
      return employeeService.GetAllEmployeesService();
    }

    [HttpGet]
    public ActionResult<Employee> UserDashboard([FromForm] User login_obj)
    {
      if(ModelState.IsValid){
        return employeeService.EmployeeDashboard(login_obj);
      }else{
        return Content("Model Mismatch");
      }
    }


          

    }
}