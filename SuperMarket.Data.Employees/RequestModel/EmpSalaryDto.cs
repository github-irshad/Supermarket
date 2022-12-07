using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.RequestModel
{
    public class EmpSalaryDto
    {
         public int SalaryComponentId { get; set; }
         public double Amount { get; set; }
         public int EmployeeId { get; set; }

    }
}