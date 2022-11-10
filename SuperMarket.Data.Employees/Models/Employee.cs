using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.EntityDataType;

namespace SuperMarket.Data.Employees.Models
{
  [Table("Employee")]
  public class Employee : CommonProps
  {


    [Column("employee_id", TypeName = EntityDataType.EntityDataType.BigIntType)]
    public int EmployeeId { get; set; }


    [Column("firstName", TypeName =EntityDataType.EntityDataType.StringType )]
    public string? FirstName { get; set; }


    [Column("lastName", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? LastName { get; set; }


    [Column("Address", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? Address { get; set; }


    [Column("Aadhar_number", TypeName =EntityDataType.EntityDataType.IntType)]
    public int AadharNumber { get; set; }


    [Column("Aadhar_Document", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? AadharDocument { get; set; }
    

    [Column("Verification", TypeName = EntityDataType.EntityDataType.BoolType)]
    public bool isVerified { get; set; }


    [Column("Designation", TypeName = EntityDataType.EntityDataType.StringType)]
    public string? Designation { get; set; }
  }
}