using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("login")]
  public class LoginController : ControllerBase
  {


    private readonly ILoginService loginService;
    private readonly IEmployeeService employeeService;


    public LoginController()
    {

      this.loginService = loginService;

    }

    [HttpPost]

    public ActionResult UserLogin([FromForm] User login_obj)
    {
      if (ModelState.IsValid)
      {
        if (loginService.UserLogin(login_obj))
        {
          return RedirectToAction("UserDashboard", "Employee", new { area = "" });
          // return Ok();
        }
        return Ok();
      }
      else
      {
        return Content("Model is not valid");
      }

    }


    
    




  }
}