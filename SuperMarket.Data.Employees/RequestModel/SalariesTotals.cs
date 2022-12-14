using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.RequestModel
{
    public class SalariesTotals
    {
        public double NetSalary { get; set; }
        public double  TotalGross { get; set; }
        public double  TotalDeduction { get; set; }
    }
}