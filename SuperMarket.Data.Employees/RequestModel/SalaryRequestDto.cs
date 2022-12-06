using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.RequestModel
{
    public class SalaryRequestDto
    {
     public string ComponentName { get; set; }   
     public string Description { get; set; }
     public ComponentType ComponentType { get; set; }
    }
}