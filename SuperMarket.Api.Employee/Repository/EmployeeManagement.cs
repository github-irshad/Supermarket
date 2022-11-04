using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Api.Employee.Interfaces;
using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Repository
{
  public class EmployeeManagement : IEmployeeManagement
  {
    public void AddNewEmployee(EmployeeModel employee)
    {
      throw new NotImplementedException();
    }

    public void DeleteEmployee(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<EmployeeModel> GetAllEmployees()
    {
      throw new NotImplementedException();
    }

    public EmployeeModel GetEmployeeById(int id)
    {
      throw new NotImplementedException();
    }

    public void UpdateEmployee(int id)
    {
      throw new NotImplementedException();
    }
  }
}