using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Repository
{
  public class LoginRepository : ILoginRepository
  {
    private readonly EmployeeDbContext employeeDbContext;

    public LoginRepository(EmployeeDbContext employeeDbContext)
    {
      this.employeeDbContext = employeeDbContext;
    }

    

    public int LoginCheck(UserDto login_obj)
    {
      
      if (employeeDbContext.Users.Any(x => x.UserName == login_obj.UserName && x.Password == login_obj.Password && x.UserType == login_obj.UserType) )
      {
        return employeeDbContext.Employees.Where(y=>y.Email == login_obj.UserName).FirstOrDefault().Id;
        
      }
      else
      {
        
        // EmpId = null;
        return 0;
      }
    }
  }
}