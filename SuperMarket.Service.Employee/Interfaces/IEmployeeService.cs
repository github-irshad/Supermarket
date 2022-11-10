using SuperMarket.Data.Employee.Models;

namespace SuperMarket.Service.Employee.Interfaces
{
  public interface IEmployeeService
    {
        public IEnumerable<EmployeeModel>GetAllEmployeesService();

        public EmployeeModel GetEmployeeByIdService(int id);

        public void UpdateEmployeeService(int id,UpdateEmployeeModel updateEmployeeModel);
    }
}