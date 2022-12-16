using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface IUserRepository
    {
        
        public void NewUser (User user);
        public void DeleteUser(int id);

        public void UpdateUser(int id, EditEmployee updateEmployeeModel);

        public bool CheckUserExist(int id);

        public bool CheckEmailExist(string email);
       
    }
}