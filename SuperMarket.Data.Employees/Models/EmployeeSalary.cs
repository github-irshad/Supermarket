using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("EmployeeSalary")]
  public class EmployeeSalary : CommonProps
  {
    // [ForeignKey]
    [Column("employee_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int EmployeeId { get; set; }



    // [ForeignKey]
    [Column("salary_component_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int SalaryComponentId { get; set; }



    [Column("amount", TypeName = EntityDataType.EntityDataType.DoubleType)]
    public double Amount { get; set; }


    // public ICollection<Employee>? Employees {get; set;}
    // public ICollection<SalaryComponents>? SalaryComponents{get; set;}
   

    
    
  }
}