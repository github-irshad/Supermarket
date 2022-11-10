using SuperMarket.Data.Employee.Common;

namespace SuperMarket.Data.Employee.Models
{
  public class EmployeeSalary : CommonProps
    {
        public int EmployeeSalaryId {get; set;}
        public int EmployeeId {get; set;}
        public int SalaryComponentId {get; set;}
        public int Amount {get; set;}
    }
}