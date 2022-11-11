using Microsoft.EntityFrameworkCore;

using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Data
{
  public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {

            
        }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //   modelBuilder.Entity<EmployeeSalary>()
    //     .HasOne<Employee>(x=>x.Employees).WithMany(p=>p.employeeSalary).HasForeignKey;
    // }
        
        public DbSet<Employee> Employees {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<SalaryComponents>SalaryComponents {get; set;}
        public DbSet<EmployeeSalary> EmployeeSalary{get; set;}

    }


}