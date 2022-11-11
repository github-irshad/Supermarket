using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  [Table("User")]
  public class User : CommonProps
  {

    [Column("User_id", TypeName = EntityDataType.EntityDataType.IntType)]
    public int UserId { get; set; }


    // [Required]
    [Column("UserName", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? UserName { get; set; }


    // [Required]
    [Column("Password", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? Password { get; set; }

    
    [Column("UserType", TypeName = EntityDataType.EntityDataType.IntType)]
    public UserType UserType { get; set; }



  }
}