using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Service.Employees.Interfaces
{
  public interface IEmployeeService
  {
    public IEnumerable<Employee> GetAllEmployeesService();

    public Employee EmployeeDashboard(int id);

    public void UpdateEmployeeService(int id,EditEmployee updateEmployeeModel);

    public void NewEmployee(AddEmployee employee);

    public void DeleteEmployeeService(int id);
  }
}