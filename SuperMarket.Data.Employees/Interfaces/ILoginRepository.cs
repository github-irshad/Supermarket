using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface ILoginRepository
    {
        public bool LoginCheck(User login_obj); 
    }
}