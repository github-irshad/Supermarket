using AutoMapper;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class EmployeeService : IEmployeeService
  {

    private readonly IEmployeeManagement employeeManagement;
    private readonly IMapper mapper;

    public EmployeeService(IEmployeeManagement employeeManagement,IMapper mapper)
    {
      this.employeeManagement = employeeManagement;
      this.mapper = mapper;
    }




    public void NewEmployee(AddEmployeeDto _employee)
    {
      // AddEmployee employee = new AddEmployee();
      var employee = mapper.Map<AddEmployeeDto,AddEmployee>(_employee);

      employee.Created_at = DateTime.UtcNow;
      employee.Updated_at = DateTime.UtcNow;
      employee.isVerified = false;
      employee.Created_by = 0;
      employee.Updated_by = 0;


      employeeManagement.AddNewEmployee(employee);
    }

    public IEnumerable<Employee> GetAllEmployeesService()
    {
      // throw new Exception("test");
      return employeeManagement.GetAllEmployees();
    }

    public Employee EmployeeDashboard(int id)
    {

      return employeeManagement.GetEmployeeById(id);
    }

    public void DeleteEmployeeService(int id)
    {
      employeeManagement.DeleteEmployee(id);
    }

    public void UpdateEmployeeService(int id, EditEmployee updateEmployeeModel)
    {
      employeeManagement.UpdateEmployee(id,updateEmployeeModel);
    }

    public void ChangeVerification(int id)
    {
      employeeManagement.ChangeVerification(id);
    }
  }
}