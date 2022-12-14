using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  [Table("User")]
  public class User : CommonProps
  {

    // [ForeignKey]
    [Column("user_name", TypeName = EntityDataType.EntityDataType.StringType)]
    public string UserName { get; set; }


    
    [Column("password", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Password { get; set; }


    [Column("user_type", TypeName = EntityDataType.EntityDataType.StringType)]
    public UserType UserType { get; set; }

    [Column("employee_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int EmployeeId { get; set; }


    public Employee? employee {get; set;}


  }
}