using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Repository
{
  public class MasterSalaryManagement : IMasterSalaryManagement
  {
    private readonly EmployeeDbContext _employeeDbContext;

    private readonly IMapper mapper;
    public MasterSalaryManagement(EmployeeDbContext employeeDbContext, IMapper mapper)
    {
      _employeeDbContext = employeeDbContext;
      this.mapper = mapper;
    }


    public void AddSalary(MasterSalaryDto masterSalaryDto)
    {
      // var SalaryList = new 
      foreach (var item in masterSalaryDto.SalaryComps)
      {
        EmpSalaryDto empSalaryDto = new EmpSalaryDto();
        empSalaryDto.EmployeeId = masterSalaryDto.Employee_id;
        empSalaryDto.Amount = item.Amount;
        empSalaryDto.SalaryComponentId = item.SalaryCompId;

        var finalSalaryDto = mapper.Map<EmpSalaryDto, EmployeeSalary>(empSalaryDto);

        finalSalaryDto.Created_at = DateTime.UtcNow;
        finalSalaryDto.Updated_at = DateTime.UtcNow;
        finalSalaryDto.Created_by = 0;
        finalSalaryDto.Updated_by = 0;

        _employeeDbContext.EmployeeSalary.Add(finalSalaryDto);
        _employeeDbContext.SaveChanges();
      }
    }

    public void DeleteSalary(int employee_id, int salary_component_id)
    {
      _employeeDbContext.EmployeeSalary.Remove(
        _employeeDbContext.EmployeeSalary.Where(
            x=> x.EmployeeId == employee_id && x.SalaryComponentId == salary_component_id)
            .FirstOrDefault()
      );

      _employeeDbContext.SaveChanges();
    }


    public void EditSalaryComp(){
        
    }

    public void GetSalaries(){

    }
    public IEnumerable<EmployeeSalary> GetSalariesByEmpId(int employee_id){

     return _employeeDbContext.EmployeeSalary.Where(x=>x.EmployeeId == employee_id).ToList();

    }
  }
}
