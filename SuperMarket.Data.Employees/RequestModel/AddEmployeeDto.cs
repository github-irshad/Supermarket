using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.RequestModel
{
  public class AddEmployeeDto
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string AadharNumber { get; set; }
    public string AadharDocument { get; set; }
    
    public string Designation { get; set; }
  }
}