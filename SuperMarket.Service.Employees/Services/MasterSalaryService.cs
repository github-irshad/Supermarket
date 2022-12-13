using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class MasterSalaryService : IMasterSalaryService
  {
    private readonly IMasterSalaryManagement masterSalaryManagement;
    private readonly IMapper mapper;

    public MasterSalaryService(IMasterSalaryManagement masterSalaryManagement, IMapper mapper)
    {
      this.masterSalaryManagement = masterSalaryManagement;
      this.mapper = mapper;
    }

    public void AddSalary(MasterSalaryDto salaryDto)
    {
      masterSalaryManagement.AddSalary(salaryDto);
    }

    public void DeleteSalary(int empId, int compId)
    {
      masterSalaryManagement.DeleteSalary(empId, compId);
    }

    public List<EmpSalaryReqDto> GetSalariesofAnEmp(int emp_id)
    {
      
      return masterSalaryManagement.GetSalariesByEmpId(emp_id);
      //  masterSalaryManagement.GetSalariesByEmpId(emp_id);
      // EmpSalaries empSalaries = new EmpSalaries();
      // empSalaries.Employee_id = ListOfSalaries.FirstOrDefault().EmployeeId;

      //   foreach(var values in ListOfSalaries){
      // foreach(var  item in empSalaries.SalaryComps){
      //     item.SalaryCompId = values.SalaryComponentId;
      //     item.Amount = values.Amount;
      //   }
      // }

      // return empSalaries;
    }
  }
}