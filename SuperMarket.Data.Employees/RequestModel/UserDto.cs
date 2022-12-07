using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.RequestModel
{
  public class UserDto
  {
    public UserType UserType { get; set; }
    public string Password { get; set; }
    public string UserName { get; set; }
  }
}