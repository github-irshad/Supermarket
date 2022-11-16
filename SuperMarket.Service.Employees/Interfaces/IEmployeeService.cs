using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Service.Employees.Interfaces
{
  public interface IEmployeeService
    {
        // public IEnumerable<Employee>GetAllEmployeesService();

        // public Employee GetEmployeeByIdService(int id);

        // // public void UpdateEmployeeService(int id,UpdateEmployeeModel updateEmployeeModel);

        public void UserAddService(User user);

        // public void DeleteEmployeeService(int id);
    }
}