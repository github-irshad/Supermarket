using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employee.Data
{
    public class EmployeeDbContext : DbContext
    {
        
    }

    public DbSet<Employee> Employees {get; set;}
    public DbSet<User> Users {get; set;}
    public DbSet<SalaryComponents>SalaryComponents {get; set;}
    public Dbset<EmployeeSalary> EmployeeSalary{get; set;}

}