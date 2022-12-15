using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class UserService : IUserService
  {
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
    }

    public void UserAddService(User user)
    {
      userRepository.UserAdd(user);
    }

    

  }
}