using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employee.Models
{
    public class EmployeeModel
    {
        public int EmployeeId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public int AdharNumber {get; set;}
        public string adharDocumnet {get; set;}
        public bool isVerified {get; set;}
        public string designation {get; set;}
    }
}