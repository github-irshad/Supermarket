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
        private readonly EmployeeDbContext employeeDbContext;

        private readonly ILoginService loginService;

    public LoginController(EmployeeDbContext employeeDbContext,ILoginService loginService )
    {
      this.employeeDbContext = employeeDbContext;
      this.loginService = loginService;
    }

    [HttpPost]

        public ActionResult UserLogin(User login_obj){
            if (ModelState.IsValid){
                if ((employeeDbContext.Users.Any(x=>x.UserName == login_obj.UserName && x.Password == login_obj.Password))){
                    return RedirectToAction("UserDashboard");
                }
                else{
                    return NotFound("Invalid Login Credentials");
                }
            }
            else{
                return Content("Model Mismatch");
            }
        }

        [HttpGet]
        public ActionResult UserDashboard(User login_obj){
            return Ok(employeeDbContext.Employees.Where(x=>x.Id == login_obj.Id).FirstOrDefault());
        }
    }
}