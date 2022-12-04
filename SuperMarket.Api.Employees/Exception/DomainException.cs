using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employees.Exception
{
    public abstract class DomainException : System.Exception
    {
        public DomainException(string message):base(message)
        {
            
        }
    }

    public class DomainNotFoundException : DomainException{
        public DomainNotFoundException(string message):base(message)
        {
            
        }
    }

    public class DomainValidationException : DomainException{
        public DomainValidationException(string message):base(message)
        {
            
        }
    }
}