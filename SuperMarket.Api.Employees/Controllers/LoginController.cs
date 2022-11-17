using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("login")]
  public class LoginController : ControllerBase
  {


    private readonly ILoginService loginService;
    


    public LoginController(ILoginService loginService)
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
          return Ok();
        }
          return Unauthorized();
      }
      else
      {
        return Content("Model is not valid");
      }

    }


    
    




  }
}