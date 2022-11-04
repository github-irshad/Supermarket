using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Api.Employee.Data;
using SuperMarket.Api.Employee.Interfaces;
using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Repository
{
  public class EmployeeManagement : IEmployeeManagement
  {

    private readonly EmployeeDbContext _employeeDbContext;

    public EmployeeManagement(EmployeeDbContext employeeDbContext)
    {
      _employeeDbContext = employeeDbContext;
    }

    public void AddNewEmployee(AddEmployeeModel _newEmployee)
    {
        var newEmployee = new EmployeeModel()
        {
            FirstName = _newEmployee.FirstName,
            LastName = _newEmployee.LastName,
            AadharDocument = _newEmployee.AadharDocument,
            AadharNumber = _newEmployee.AadharNumber,
            Address = _newEmployee.Address,
            Designation = _newEmployee.Designation,
            isVerified = false
        };
      _employeeDbContext.Employees.Add(newEmployee);
      _employeeDbContext.SaveChanges();
    }

   

    public void DeleteEmployee(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<EmployeeModel> GetAllEmployees()
    {
      return _employeeDbContext.Employees.ToList();
    }

    public EmployeeModel GetEmployeeById(int id)
    {
      return _employeeDbContext.Employees.Where(x=>x.EmployeeId==id).FirstOrDefault();
    }

    public void UpdateEmployee(int id)
    {
      throw new NotImplementedException();
    }
  }
}