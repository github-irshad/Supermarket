using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employee.Common;

namespace SuperMarket.Data.Employee.Models
{
  [Table("Employee")]
  public class EmployeeModel : CommonProps
  {


    [Column("employee_id", TypeName = EntityDataType.StringType)]
    public int EmployeeId { get; set; }


    [Column("firstName", TypeName = EntityDataType.StringType)]
    public string? FirstName { get; set; }


    [Column("lastName", TypeName = EntityDataType.StringType)]
    public string? LastName { get; set; }


    [Column("Address", TypeName = EntityDataType.StringType)]
    public string? Address { get; set; }


    [Column("Aadhar_number", TypeName = EntityDataType.StringType)]
    public int AadharNumber { get; set; }


    [Column("AAdhar_Document", TypeName = EntityDataType.StringType)]
    public string? AadharDocument { get; set; }
    

    [Column("Verification", TypeName = EntityDataType.StringType)]
    public bool isVerified { get; set; }


    [Column("Designation", TypeName = EntityDataType.StringType)]
    public string? Designation { get; set; }
  }
}