using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.Models
{
    public class ErrorModel
    {
        public int ResponseCode {get; set;}
        public string Message {get; set;}
        public List<string> Error {get; set;}
    }
}