using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface IUserService
    {
        public void UserAddService(User user);
    }
}