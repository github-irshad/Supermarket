using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("EmployeeSalary")]
  public class EmployeeSalary : CommonProps
  {
    [Column("employee_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int EmployeeId { get; set; }

    
    [Column("salary_component_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int SalaryComponentId { get; set; }


    [Column("amount", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Amount { get; set; }


    [Column("net_salary", TypeName = EntityDataType.EntityDataType.IntType)]
    public int NetSalary { get; set; }
  }
}