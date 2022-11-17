using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class EmployeeService : IEmployeeService
  {

    private readonly IEmployeeManagement employeeManagement;

    public EmployeeService(IEmployeeManagement employeeManagement)
    {
      this.employeeManagement = employeeManagement;
    }




    public void NewEmployee(Employee employee)
    {
      employeeManagement.AddNewEmployee(employee);
    }

    public IEnumerable<Employee> GetAllEmployeesService()
    {
      return employeeManagement.GetAllEmployees();
    }

    public Employee EmployeeDashboard(int id)
    {

      return employeeManagement.GetEmployeeById(id);
    }

    // public void DeleteEmployeeService(int id)
    // {
    //   throw new NotImplementedException();
    // }

    // // public void UpdateEmployeeService(int id, UpdateEmployeeModel updateEmployeeModel)
    // // {
    // //   employeeManagement.UpdateDocument(id);
    // // }


  }
}