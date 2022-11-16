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


    

    public void UserAddService(User user)
    {
      employeeManagement.AddNewUser(user);
    }

    public IEnumerable<Employee> GetAllEmployeesService()
    {
      return employeeManagement.GetAllEmployees();
    }

    public Employee EmployeeDashboard(User user){
      int user_id = user.Id;
      return employeeManagement.GetEmployeeById(user_id);
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