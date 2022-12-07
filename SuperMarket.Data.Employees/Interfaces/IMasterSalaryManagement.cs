using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface IMasterSalaryManagement
    {
        public void AddSalary(MasterSalaryDto masterSalaryDto);
    }
}