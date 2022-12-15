using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class UserService : IUserService
  {

    public UserService()
    {
      
    }
    private readonly IUserRepository userRepository;

    private UserService(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
    }

    public void UserAddService(AddEmployeeDto _employee,int id)
    {
       User user = new User(){
        Id = id,
        UserName = _employee.Email,
        Password = "123456",
        UserType = _employee.UserType,
        Created_at = DateTime.UtcNow,
      Updated_at = DateTime.UtcNow,
      
      Created_by = 0,
      Updated_by = 0

      
    };
    userRepository.UserAdd(user);
    }
    

  }
}