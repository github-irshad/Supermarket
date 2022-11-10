using Microsoft.EntityFrameworkCore;
using SuperMarket.Data.Employee.Models;

namespace SuperMarket.Data.Employee.Data
{
  public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {
            
        }
        
        public DbSet<EmployeeModel> Employees {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<SalaryComponents>SalaryComponents {get; set;}
        public DbSet<EmployeeSalary> EmployeeSalary{get; set;}

    }


}