using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employee.Models
{
    public class SalaryComponents
    {
        public int SalaryComponentsId {get; set;}
        public string ComponentName {get;set;}
        public string ComponentType {get; set;}
        public string Description {get; set;}
        
    }
}