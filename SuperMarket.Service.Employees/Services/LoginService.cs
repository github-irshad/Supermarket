using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class LoginService : ILoginService
  {

    private readonly ILoginRepository loginRepository;
    private readonly IEmployeeManagement employeeManagement;


    public LoginService(ILoginRepository loginRepository, IEmployeeManagement employeeManagement)
    {
      this.loginRepository = loginRepository;
      this.employeeManagement = employeeManagement;

    }



    public bool UserLogin(User login_obj)
    {
      return loginRepository.LoginCheck(login_obj);
    }

    public Employee EmployeeDashboard(User user)
    {
      int user_id = user.Id;
      return employeeManagement.GetEmployeeById(user_id);
    }




  }
}