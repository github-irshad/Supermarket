using AutoMapper;
using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;
// using SuperMarket.Service.Employees.Services;

namespace SuperMarket.Service.Employees.Services
{
  public class EmployeeService : IEmployeeService
  {

    private readonly IEmployeeManagement employeeManagement;
    private readonly IMapper mapper;
    private readonly IUserRepository userRepository;







    public EmployeeService(IEmployeeManagement employeeManagement, IMapper mapper, IUserRepository userRepository)
    {
      this.employeeManagement = employeeManagement;
      this.mapper = mapper;

      this.userRepository = userRepository;
    }




    public void NewEmployee(AddEmployeeDto _employee)
    {
      // AddEmployee employee = new AddEmployee();
      var employee = mapper.Map<AddEmployeeDto, AddEmployee>(_employee);

      employee.Created_at = DateTime.UtcNow;
      employee.Updated_at = DateTime.UtcNow;
      employee.isVerified = false;
      employee.Created_by = 0;
      employee.Updated_by = 0;




      User user = new User()
      {
        UserName = _employee.Email,
        Password = "123456",
        UserType = _employee.UserType,

        Created_at = DateTime.UtcNow,
        Updated_at = DateTime.UtcNow,

        Created_by = 0,
        Updated_by = 0
      };

      employeeManagement.AddNewEmployee(employee);
      userRepository.NewUser(user);

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
      employeeManagement.UpdateEmployee(id, updateEmployeeModel);
    }

    public void ChangeVerification(int id)
    {
      employeeManagement.ChangeVerification(id);
    }

    public Dictionary<int, string> GetEnum_ComponentType()
    {
      return employeeManagement.ReturnCompTypeEnums();
    }
    public Dictionary<int, string> GetEnum_UserType()
    {
      return employeeManagement.ReturnUserTypeEnums();
    }
  }


}