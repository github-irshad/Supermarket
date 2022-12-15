using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface IMasterSalaryManagement
    {
        public void AddSalary(MasterSalaryDto masterSalaryDto);
        public void DeleteSalary(int employee_id,int salary_component_id);
        public void DeleteFullSalary(int EmpId);
        public List<EmpSalaryReqDto> GetSalariesByEmpId(int employee_id);
    }
}