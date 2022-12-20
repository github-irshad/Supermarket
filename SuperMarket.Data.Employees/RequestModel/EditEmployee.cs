using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Common;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.RequestModel
{
  public class EditEmployee
  {


    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string AadharNumber { get; set; }
    // public string AadharDocument { get; set; }
    // public bool isVerified { get; set; }
    public string Designation { get; set; }
    // public EmployeeSalary? employeeSalary { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public string PhoneNumber { get; set; }
    public UserType UserType { get; set; }
    // public string ProfilePic { get; set; }
  }
}