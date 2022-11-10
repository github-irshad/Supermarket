using SuperMarket.Data.Employee.Models;

namespace SuperMarket.Service.Employee.Interfaces
{
  public interface IEmployeeService
    {
        public IEnumerable<Employee>GetAllEmployeesService();

        public Employee GetEmployeeByIdService(int id);

        public void UpdateEmployeeService(int id,UpdateEmployeeModel updateEmployeeModel);

        public void AddNewEmployeeService(AddEmployeeModel addEmployeeModel);

        public void DeleteEmployeeService(int id);
    }
}