using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.RequestModel
{
    public class EmpSalaryReqDto
    {
        public int SalaryCompId { get; set; }
        public double Amount { get; set; }
    }
}