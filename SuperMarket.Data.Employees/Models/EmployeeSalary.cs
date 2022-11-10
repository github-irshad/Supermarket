using System.ComponentModel.DataAnnotations.Schema;
using SuperMarket.Data.Employees.Common;

namespace SuperMarket.Data.Employees.Models
{
  [Table("EmployeeSalary")]
  public class EmployeeSalary : CommonProps
    {
        public int EmployeeSalaryId {get; set;}
        public int EmployeeId {get; set;}
        public int SalaryComponentId {get; set;}
        public int Amount {get; set;}
    }
}