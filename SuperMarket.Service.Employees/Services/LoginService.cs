using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class LoginService : ILoginService
  {

    private readonly ILoginRepository loginRepository;
    private readonly IEmployeeManagement employeeManagement;
    private readonly IMapper mapper;


    public LoginService(ILoginRepository loginRepository, IEmployeeManagement employeeManagement,IMapper mapper)
    {
      this.loginRepository = loginRepository;
      this.employeeManagement = employeeManagement;
      this.mapper = mapper;

    }



    public bool UserLogin(UserDto _login_obj)
    {
      // var login_obj = mapper.Map<UserDto,User>(_login_obj);

      // login_obj.Created_at = DateTime.UtcNow;
      // login_obj.Updated_at = DateTime.UtcNow;
      
      // login_obj.Created_by = 0;
      // login_obj.Updated_by = 0;
      
      return loginRepository.LoginCheck(_login_obj);
    }

    public Employee EmployeeDashboard(User user)
    {
      int user_id = user.Id;
      return employeeManagement.GetEmployeeById(user_id);
    }




  }
}