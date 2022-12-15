using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface IMasterSalaryService
    {
        public void AddSalary(int id,MasterSalaryReq salaryDto);

        public void DeleteSalary(int empId, int compId);
        public List<EmpSalarybreakdown> GetSalariesofAnEmp(int emp_id);
    }
}