using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("EmployeeSalary")]
  public class EmployeeSalary : CommonProps
  {
    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int EmployeeSalaryId { get; set; }

    
    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int EmployeeId { get; set; }


    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int SalaryComponentId { get; set; }


    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Amount { get; set; }
  }
}