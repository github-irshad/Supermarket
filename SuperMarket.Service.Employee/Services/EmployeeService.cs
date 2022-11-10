using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employee.Models;
using SuperMarket.Service.Employee.Interfaces;

namespace SuperMarket.Service.Employee.Services
{
  public class EmployeeService : IEmployeeService
  {
    public IEnumerable<EmployeeModel> GetAllEmployees()
    {
      throw new NotImplementedException();
    }
  }
}