using Microsoft.EntityFrameworkCore;

using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Data
{
  public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {

            
        }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(b => b.user)
            .WithOne(i => i.employee)
            .HasForeignKey<User>(c=>c.Id);
            
    }
        
        public DbSet<Employee> Employees {get; set;}
        public DbSet<User> Users {get; set;}
        public DbSet<SalaryComponents>SalaryComponents {get; set;}
        public DbSet<EmployeeSalary> EmployeeSalary{get; set;}

    }


}