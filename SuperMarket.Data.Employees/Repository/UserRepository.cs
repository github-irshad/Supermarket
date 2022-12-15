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

    public void DeleteUser(int id)
    {
      var dUser = _employeeDbContext.Users.Where(e=>e.Id == id).FirstOrDefault();
      _employeeDbContext.Remove(dUser);
      _employeeDbContext.SaveChanges();
    }

    public void NewUser(User user)
    {
      _employeeDbContext.Users.Add(user);
      _employeeDbContext.SaveChanges();

    }
  }
}