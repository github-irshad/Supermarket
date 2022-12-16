using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Repository
{
  public class UserRepository : IUserRepository
  {
   
    private readonly EmployeeDbContext _employeeDbContext;
    private readonly IMapper mapper;

    public UserRepository(EmployeeDbContext employeeDbContext, IMapper mapper)
    {
      _employeeDbContext = employeeDbContext;
      this.mapper = mapper;
    }

    public bool CheckEmailExist(string email)
    {
      return _employeeDbContext.Users.Any(e=>e.UserName == email);
    }

    public bool CheckUserExist(int id)
    {
      return _employeeDbContext.Users.Any(e=>e.Id==id);
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

    public void UpdateUser(int id, EditEmployee updateEmployeeModel)
    {
      var target = _employeeDbContext.Users.Where(x => x.Id == id).FirstOrDefault();

    target.UserName = updateEmployeeModel.Email;
    target.UserType = updateEmployeeModel.UserType;

    _employeeDbContext.SaveChanges();
      
    }
  }
}