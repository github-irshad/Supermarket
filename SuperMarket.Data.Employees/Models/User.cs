using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  [Table("User")]
  public class User 
  {
    [Key]
    [Column("id", TypeName = EntityDataType.EntityDataType.IntType)]
    [ForeignKey("Id")]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }


    [Column("created_at", TypeName = EntityDataType.EntityDataType.DateTimeType)]
    public DateTime? Created_at { get; set; }


    [Column("created_by", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Created_by { get; set; }


    [Column("updated_at", TypeName = EntityDataType.EntityDataType.DateTimeType)]
    public DateTime? Updated_at { get; set; }


    [Column("updated_by", TypeName = EntityDataType.EntityDataType.IntType)]
    public int Updated_by { get; set; }

    // [ForeignKey]
    [Column("user_name", TypeName = EntityDataType.EntityDataType.StringType)]
    public string UserName { get; set; }


    
    [Column("password", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Password { get; set; }


    [Column("user_type", TypeName = EntityDataType.EntityDataType.StringType)]
    public UserType UserType { get; set; }


  
    public Employee? employee {get; set;}

    // [Column("employee_id", TypeName = EntityDataType.EntityDataType.IntType)]
    // public int EmployeeId { get; set; }

  }
}