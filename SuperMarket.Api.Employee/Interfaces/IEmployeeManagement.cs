using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Interfaces
{
    public interface IEmployeeManagement
    {
        public IEnumerable<EmployeeModel> GetAllEmployees();
        public EmployeeModel GetEmployeeById(int id);
        public void DeleteEmployee(int id);
        public void AddNewEmployee(EmployeeModel employee);
        public void UpdateEmployee(int id);
    }
}