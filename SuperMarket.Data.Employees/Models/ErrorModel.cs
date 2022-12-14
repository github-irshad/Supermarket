using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SuperMarket.Data.Employees.Models
{
    public class ErrorModel
    {
        public int StatusCode {get; set;}
        public string Message {get; set;}
        public override string ToString() {
            return JsonConvert.SerializeObject(this);
            }
    }
}