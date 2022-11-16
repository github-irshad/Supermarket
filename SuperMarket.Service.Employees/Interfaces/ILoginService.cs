using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface ILoginService
    {
        public bool UserLogin(User login_obj);
        public Employee EmployeeDashboard(User user);
        
    }
}