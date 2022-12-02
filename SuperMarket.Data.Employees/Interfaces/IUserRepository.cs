using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface IUserRepository
    {
        public void UserAdd (User user);
        public void Create_Password(string FirstName, string PhoneNum);
    }
}