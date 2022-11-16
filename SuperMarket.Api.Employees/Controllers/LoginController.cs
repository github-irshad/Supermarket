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
          // return RedirectToAction("UserDashboard");
          return Ok();
        }
        return Ok();
      }
      else
      {
        return Content("Model is not valid");
      }

    }


    [HttpGet]
    public ActionResult<Employee> User_Dash([FromForm] User login_obj)
    {
      if(ModelState.IsValid){
        return loginService.EmployeeDashboard(login_obj);
      }else{
        return Content("Model Mismatch");
      }
    }




  }
}