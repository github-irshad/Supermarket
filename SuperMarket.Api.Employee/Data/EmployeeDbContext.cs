using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperMarket.Api.Employee.Models;

namespace SuperMarket.Api.Employee.Data
{
    public class EmployeeDbContext : DbContext
    {
        
    }

    public DbSet<EmployeeModel> Employees {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<SalaryComponents>SalaryComponents {get; set;}
    public Dbset<EmployeeSalary> EmployeeSalary{get; set;}

}