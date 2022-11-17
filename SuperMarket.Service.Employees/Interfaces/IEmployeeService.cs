using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Service.Employees.Interfaces
{
  public interface IEmployeeService
  {
    public IEnumerable<Employee> GetAllEmployeesService();

    public Employee EmployeeDashboard(int id);

    // // public void UpdateEmployeeService(int id,UpdateEmployeeModel updateEmployeeModel);

    public void NewEmployee(Employee employee);

    // public void DeleteEmployeeService(int id);
  }
}