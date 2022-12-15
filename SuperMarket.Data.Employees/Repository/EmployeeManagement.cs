
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Models;
using Microsoft.AspNetCore.Http;
using SuperMarket.Data.Employees.RequestModel;
using AutoMapper;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Api.Employees.Repository
{
  public class EmployeeManagement : IEmployeeManagement
  {

    private readonly EmployeeDbContext _employeeDbContext;
    private readonly IMapper mapper;

    public EmployeeManagement(EmployeeDbContext employeeDbContext, IMapper mapper)
    {
      _employeeDbContext = employeeDbContext;
      this.mapper = mapper;
    }






    public void AddNewEmployee(AddEmployee _newEmployee, User user)
    {

      var newEmployee = mapper.Map<AddEmployee, Employee>(_newEmployee);


      _employeeDbContext.Employees.Add(newEmployee);

      _employeeDbContext.SaveChanges();
      int id = newEmployee.Id;

      _employeeDbContext.Users.Add(user);
      _employeeDbContext.SaveChanges();
    }


    public void DeleteEmployee(int id)
    {
      var result = _employeeDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
      _employeeDbContext.Employees.Remove(result);
      _employeeDbContext.SaveChanges();

    }


    public IEnumerable<Employee> GetAllEmployees()
    {
      return _employeeDbContext.Employees.ToList();
    }


    public void UpdateEmployee(int id, EditEmployee editEmployeeModel)
    {
      var target = _employeeDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();


      /*target.FirstName = editEmployeeModel.FirstName;
       target.LastName = editEmployeeModel.LastName;
       target.AadharDocument = editEmployeeModel.AadharDocument;
       target.AadharNumber = editEmployeeModel.AadharNumber;
       target.Address = editEmployeeModel.Address;
       target.Designation = editEmployeeModel.Designation;
       target.Created_at = editEmployeeModel.Created_at;
       target.Created_by = editEmployeeModel.Created_by;
       target.Updated_at = editEmployeeModel.Updated_at;
       target.Updated_by = editEmployeeModel.Updated_by;
       target.isVerified = editEmployeeModel.isVerified;
       target.employeeSalary = editEmployeeModel.employeeSalary;*/




      // target = mapper.Map<EditEmployee,Employee>(editEmployeeModel,target);
      mapper.Map<EditEmployee, Employee>(editEmployeeModel, target);
      // target = editEmployee;

      // _employeeDbContext.Employees.Update(target);




      _employeeDbContext.SaveChanges();


    }


    public Employee GetEmployeeById(int id)
    {
      return _employeeDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
    }

    public void ChangeVerification(int id)
    {
      var empStatus = _employeeDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
      empStatus.IsVerified = !empStatus.IsVerified;

      _employeeDbContext.SaveChanges();
    }

    public List<ComponentType> EnumToList()
    {
      return Enum.GetValues(typeof(ComponentType)).Cast<ComponentType>().ToList();
    }

    public Dictionary<int, string> ReturnCompTypeEnums()
    {
      Dictionary<int, string> myDic = new Dictionary<int, string>();

      foreach (ComponentType foo in Enum.GetValues(typeof(ComponentType)))
      {
        myDic.Add((int)foo, foo.ToString());
      }

      return myDic;
    }
    public Dictionary<int, string> ReturnUserTypeEnums()
    {
      Dictionary<int, string> myDic = new Dictionary<int, string>();

      foreach (UserType foo in Enum.GetValues(typeof(UserType)))
      {
        myDic.Add((int)foo, foo.ToString());
      }

      return myDic;
    }
  }
}