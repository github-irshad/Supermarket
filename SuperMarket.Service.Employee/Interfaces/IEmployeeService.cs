using SuperMarket.Data.Employee.Models;

namespace SuperMarket.Service.Employee.Interfaces
{
  public interface IEmployeeService
    {
        public IEnumerable<EmployeeModel>GetAllEmployees();
    }
}