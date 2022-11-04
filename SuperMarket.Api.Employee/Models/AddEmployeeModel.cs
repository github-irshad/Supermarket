using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employee.Models
{
    public class AddEmployeeModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public int AadharNumber {get; set;}
        public string AadharDocument {get; set;}
        public bool isVerified {get; set;}
        public string Designation {get; set;}
    }
}