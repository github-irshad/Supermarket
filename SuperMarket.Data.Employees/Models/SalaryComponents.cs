using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("SalaryComponents")]
  public class SalaryComponents : CommonProps
  {
    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int SalaryComponentsId { get; set; }


    [Column("User_id", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? ComponentName { get; set; }


    [Column("User_id", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? ComponentType { get; set; }

    
    [Column("User_id", TypeName = EntityDataType.EntityDataType.StringType
    )]
    public string? Description { get; set; }

  }
}