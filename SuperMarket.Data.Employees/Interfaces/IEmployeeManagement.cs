

using Microsoft.AspNetCore.Http;
using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Interfaces
{
  public interface IEmployeeManagement
  {
    public IEnumerable<Employee> GetAllEmployees();
    public Employee GetEmployeeById(int id);
    public void DeleteEmployee(int id);
    public int AddNewEmployee(AddEmployee newEmployee);
    public void UpdateEmployee(int id, EditEmployee updateEmployeeModel);
    public void ChangeVerification(int id);
    public Dictionary<int, string> ReturnCompTypeEnums();

    public Dictionary<int, string> ReturnUserTypeEnums();




  }
}