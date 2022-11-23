using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("SalaryComponents")]
  public class SalaryComponents : CommonProps
  {
    


    [Column("component_name", TypeName = EntityDataType.EntityDataType.StringType)]
    public string ComponentName { get; set; }


    [Column("component_type", TypeName = EntityDataType.EntityDataType.StringType)]
    public ComponentType? ComponentType { get; set; }

    
    [Column("description", TypeName = EntityDataType.EntityDataType.StringType
    )]
    public string Description { get; set; }


    public EmployeeSalary? employeeSalary {get; set;}
    

   

  }
}