using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface ISalaryCalculation
    {
         public double NetSalaryCalc(int id);
         public double GrossSalaryCalc(int id);
    }
}