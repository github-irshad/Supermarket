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
    private readonly ISalaryManagement salaryManagement;

    public MasterSalaryService(IMasterSalaryManagement masterSalaryManagement, IMapper mapper, ISalaryManagement salaryManagement)
    {
      this.masterSalaryManagement = masterSalaryManagement;
      this.mapper = mapper;
      this.salaryManagement = salaryManagement;
    }

    public void AddSalary(MasterSalaryDto salaryDto)
    {
      masterSalaryManagement.AddSalary(salaryDto);
    }

    public void DeleteSalary(int empId, int compId)
    {
      masterSalaryManagement.DeleteSalary(empId, compId);
    }

    public List<EmpSalarybreakdown> GetSalariesofAnEmp(int emp_id)
    {

      var convertable = masterSalaryManagement.GetSalariesByEmpId(emp_id);

      List<EmpSalarybreakdown> empSalarybreakdown = new List<EmpSalarybreakdown>();

      empSalarybreakdown = convertable.Select(s => new EmpSalarybreakdown
      {
        Amount = s.Amount,
        SalaryComp = salaryManagement.CompToString(s.SalaryCompId)

      }).ToList();


      return empSalarybreakdown;
    }


  }
}
