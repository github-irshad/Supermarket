using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Service.Employees.Interfaces
{
  public interface IEmployeeService
  {
    public IEnumerable<Employee> GetAllEmployeesService();

    public Employee EmployeeDashboard(int id);

    public void UpdateEmployeeService(int id,EditEmployee updateEmployeeModel);

    public string NewEmployee(AddEmployeeDto employee);

    public void DeleteEmployeeService(int id);

    public void ChangeVerification(int id);

    public Dictionary<int, string> GetEnum_ComponentType();
    public Dictionary<int, string> GetEnum_UserType();
  }
}