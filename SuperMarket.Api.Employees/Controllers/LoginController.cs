using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("login")]
  public class LoginController : ControllerBase
  {
    Nullable<int> EmployeeId;


    private readonly ILoginService loginService;
    


    public LoginController(ILoginService loginService)
    {

      this.loginService = loginService;

    }

    [HttpPost]    

    public ActionResult UserLogin( UserDto login_obj)
    {
      if (ModelState.IsValid)
      {
        if (loginService.UserLogin(login_obj) > 0)
        {
          return Ok(loginService.UserLogin(login_obj));
        }
          return Unauthorized();
      }
      else
      {
        EmployeeId = null;
        return Content("Model is not valid");
      }

    }


    
    




  }
}