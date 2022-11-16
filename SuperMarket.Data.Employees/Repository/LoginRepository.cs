using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Repository
{
  public class LoginRepository : ILoginRepository
  {
    private readonly EmployeeDbContext employeeDbContext;

    public LoginRepository(EmployeeDbContext employeeDbContext)
    {
      this.employeeDbContext = employeeDbContext;
    }


    public bool LoginCheck(User login_obj)
    {
      if (employeeDbContext.Users.Any(x => x.UserName == login_obj.UserName && x.Password == login_obj.Password) )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}