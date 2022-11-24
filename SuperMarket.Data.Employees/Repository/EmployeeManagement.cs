
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Models;
using Microsoft.AspNetCore.Http;
using SuperMarket.Data.Employees.RequestModel;
using AutoMapper;

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






    public void AddNewEmployee(AddEmployee _newEmployee)
    {
      // Employee newEmployee = new Employee(){
      //   Id = _newEmployee.Id,
      //   AadharDocument = _newEmployee.AadharDocument,
      //   AadharNumber = _newEmployee.AadharNumber,
      //   Address = _newEmployee.Address,
      //   Created_at = _newEmployee.Created_at,
      //   Created_by = _newEmployee.Created_by,
      //   Designation = _newEmployee.Designation,
      //   FirstName = _newEmployee.FirstName,
      //   isVerified = _newEmployee.isVerified,
      //   LastName = _newEmployee.LastName,
      //   Updated_at = _newEmployee.Updated_at,
      //   Updated_by = _newEmployee.Updated_by,
      //   employeeSalary = _newEmployee.employeeSalary
      // };

      var newEmployee = mapper.Map<AddEmployee, Employee>(_newEmployee);
      _employeeDbContext.Employees.Add(newEmployee);
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

    
    public void UpdateEmployee(int id,EditEmployee editEmployeeModel)
    {
        var target = _employeeDbContext.Employees.Where(x=>x.Id==id).FirstOrDefault();


        // target.FirstName = editEmployeeModel.FirstName;
        // target.LastName = editEmployeeModel.LastName;
        // target.AadharDocument = editEmployeeModel.AadharDocument;
        // target.AadharNumber = editEmployeeModel.AadharNumber;
        // target.Address = editEmployeeModel.Address;
        // target.Designation = editEmployeeModel.Designation;
        // target.Created_at = editEmployeeModel.Created_at;
        // target.Created_by = editEmployeeModel.Created_by;
        // target.Updated_at = editEmployeeModel.Updated_at;
        // target.Updated_by = editEmployeeModel.Updated_by;
        // target.isVerified = editEmployeeModel.isVerified;
        // target.employeeSalary = editEmployeeModel.employeeSalary;


        

        var editEmployee = mapper.Map<EditEmployee,Employee>(editEmployeeModel);
        // target = editEmployee;

        _employeeDbContext.Employees.Update(editEmployee);

        
      

        _employeeDbContext.SaveChanges();
        

    }
    
  
    public Employee GetEmployeeById(int id)
    {
      return _employeeDbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
    }

    

  }
}