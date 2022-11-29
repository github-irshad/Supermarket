using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
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




    public void NewEmployee(AddEmployee employee)
    {
      employeeManagement.AddNewEmployee(employee);
    }

    public IEnumerable<Employee> GetAllEmployeesService()
    {
      // throw new Exception("test");
      return employeeManagement.GetAllEmployees();
    }

    public Employee EmployeeDashboard(int id)
    {

      return employeeManagement.GetEmployeeById(id);
    }

    public void DeleteEmployeeService(int id)
    {
      employeeManagement.DeleteEmployee(id);
    }

    public void UpdateEmployeeService(int id, EditEmployee updateEmployeeModel)
    {
      employeeManagement.UpdateEmployee(id,updateEmployeeModel);
    }


  }
}