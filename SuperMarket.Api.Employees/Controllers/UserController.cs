using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

    public UserController(IUserService userService)
    {
      this.userService = userService;
    }

    [HttpPost("Add")]
        public ActionResult AddUSer(User user)
        {
            userService.UserAddService(user);
            return Ok("Added user");
        }
        
    }
}