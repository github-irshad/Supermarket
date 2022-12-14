

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
    public void AddNewEmployee(AddEmployee newEmployee);
    public void UpdateEmployee(int id, EditEmployee updateEmployeeModel);
    public void ChangeVerification(int id);
    public Dictionary<int, string> ReturnCompTypeEnums();

    public Dictionary<int, string> ReturnUserTypeEnums();

    public bool CheckEmpExist(int id);




  }
}