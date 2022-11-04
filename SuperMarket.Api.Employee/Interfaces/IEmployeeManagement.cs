using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employee.Interfaces
{
    public interface IEmployeeManagement
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public void DeleteEmployee(int id);
        public void AddNewEmployee(Employee employee);
        public void UpdateEmployee(int id);
    }
}