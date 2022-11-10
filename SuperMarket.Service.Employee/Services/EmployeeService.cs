using SuperMarket.Data.Employee.Interfaces;
using SuperMarket.Data.Employee.Models;
using SuperMarket.Service.Employee.Interfaces;

namespace SuperMarket.Service.Employee.Services
{
  public class EmployeeService : IEmployeeService
  {

    private readonly IEmployeeManagement employeeManagement;

    public EmployeeService(IEmployeeManagement employeeManagement)
    {
      this.employeeManagement = employeeManagement;
    }

    public IEnumerable<EmployeeModel> GetAllEmployeesService()
    {
      return employeeManagement.GetAllEmployees();
    }

    public EmployeeModel GetEmployeeByIdService(int id)
    {
      return employeeManagement.GetEmployeeById(id);
    }
  }
}