using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface IMasterSalaryService
    {
        public void AddSalary(MasterSalaryDto salaryDto);
    }
}