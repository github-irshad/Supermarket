using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  [Table("User")]
  public class User : CommonProps
  {

    
    [Column("userName", TypeName = EntityDataType.EntityDataType.StringType)]
    public string UserName { get; set; }


    
    [Column("password", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Password { get; set; }


    [Column("user_type", TypeName = EntityDataType.EntityDataType.IntType)]
    public UserType UserType { get; set; }



  }
}