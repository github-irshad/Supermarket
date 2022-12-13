using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;

namespace SuperMarket.Data.Employees.Repository
{
  public class SalaryCalculation : ISalaryCalculation
  {
    private readonly EmployeeDbContext employeeDbContext;

    public SalaryCalculation(EmployeeDbContext employeeDbContext)
    {
      this.employeeDbContext = employeeDbContext;
    }

    public double GrossSalaryCalc(int id)
    {
      double gross = 0;

      var listOfCompsid = employeeDbContext.EmployeeSalary.Where(
          x => x.EmployeeId == id
      ).ToList();

      foreach (var item in listOfCompsid)
      {

        int CompId = item.SalaryComponentId;
        var CompType = (int)(employeeDbContext.SalaryComponents.Where(y => y.Id == CompId).FirstOrDefault().ComponentType);

        if (CompType == 1)
        {
          gross += item.Amount;
        }

      }

        return gross;
    }



    public double NetSalaryCalc(int id)
    {

      double netSalary = 0;

      var listOfCompsid = employeeDbContext.EmployeeSalary.Where(
          x => x.EmployeeId == id
      ).ToList();

      foreach (var item in listOfCompsid)
      {

        int CompId = item.SalaryComponentId;
        var CompType = (int)(employeeDbContext.SalaryComponents.Where(y => y.Id == CompId).FirstOrDefault().ComponentType);

        if (CompType == 1)
        {
          netSalary = netSalary + item.Amount;
        }
        else if (CompType == 2)
        {
          netSalary = netSalary - item.Amount;
        }
      }

      return netSalary;
    }

  }
}