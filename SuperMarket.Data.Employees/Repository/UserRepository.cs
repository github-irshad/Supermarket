using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Repository
{
  public class UserRepository : IUserRepository
  {
    private readonly EmployeeDbContext _employeeDbContext;

    public UserRepository(EmployeeDbContext employeeDbContext)
    {
      _employeeDbContext = employeeDbContext;
    }

    public void Create_Password(string FirstName, string PhoneNum)
    {
      throw new NotImplementedException();
    }

    public void UserAdd(User user)
    {
      _employeeDbContext.Users.Add(user);
    }
  }
}