using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Interfaces
{
  public interface IEmployeeManagement
    {
        public IEnumerable<EmployeeModel> GetAllEmployees();
        public EmployeeModel GetEmployeeById(int id);
        public void DeleteEmployee(int id);
        public void AddNewEmployee(AddEmployeeModel employee);
        public EmployeeModel UpdateEmployee(int id, UpdateEmployeeModel updateEmployeeModel);
    }
}