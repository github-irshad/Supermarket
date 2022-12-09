using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  [Table("Employee")]
  public class Employee : CommonProps
  {


    // [Column("employee_id", TypeName = EntityDataType.EntityDataType.BigIntType)]
    // public int EmployeeId { get; set; }


    [Column("firstName", TypeName =EntityDataType.EntityDataType.StringType )]
    public string FirstName { get; set; }


    [Column("lastName", TypeName = EntityDataType.EntityDataType.StringType)]
    public string LastName { get; set; }


    [Column("address", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Address { get; set; }


    [Column("aadhar_number", TypeName =EntityDataType.EntityDataType.StringType)]
    public string AadharNumber { get; set; }


    [Column("aadhar_document", TypeName = EntityDataType.EntityDataType.StringType)]
    public string AadharDocument { get; set; }
    

    [Column("verification", TypeName = EntityDataType.EntityDataType.BoolType)]
    public bool IsVerified { get; set; }


    [Column("designation", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Designation { get; set; }

    [Column("email", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Email { get; set; }

    [Column("phone_number", TypeName = EntityDataType.EntityDataType.StringType)]
    public string PhoneNumber { get; set; }

    [Column("department", TypeName = EntityDataType.EntityDataType.StringType)]
    public string Department { get; set; }


  // 1-1 Relation
    public EmployeeSalary? employeeSalary {get; set;}
    // public User? user { get; set; }
  }
}