using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
    public class SalaryComponents : CommonProps
    {
        public int SalaryComponentsId {get; set;}
        public string ComponentName {get;set;}
        public string ComponentType {get; set;}
        public string Description {get; set;}
        
    }
}