using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.RequestModel
{
  public class EmpSalarybreakdown
  {
    public string SalaryComp { get; set; }
    public double Amount { get; set; }
  }
}