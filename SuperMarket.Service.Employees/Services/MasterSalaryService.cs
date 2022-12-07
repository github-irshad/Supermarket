using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class MasterSalaryService : IMasterSalaryService
  {
    private readonly IMasterSalaryManagement masterSalaryManagement;

    public MasterSalaryService(IMasterSalaryManagement masterSalaryManagement)
    {
      this.masterSalaryManagement = masterSalaryManagement;
    }

    public void AddSalary(MasterSalaryDto salaryDto)
    {
      masterSalaryManagement.AddSalary(salaryDto);
    }

    public void DeleteSalary(int empId, int compId)
    {
      masterSalaryManagement.DeleteSalary(empId, compId);
    }

    public IEnumerable<EmployeeSalary> GetSalariesofAnEmp(int emp_id)
    {
      return masterSalaryManagement.GetSalariesByEmpId(emp_id);
    }
  }
}