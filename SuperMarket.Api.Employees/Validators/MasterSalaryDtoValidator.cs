using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Api.Employees.Validators
{
    public class MasterSalaryDtoValidator : AbstractValidator<MasterSalaryDto>
    {
        public MasterSalaryDtoValidator()
        {
            RuleFor(x=>x.Employee_id).NotEmpty();
            RuleFor(x=>x.SalaryComps).NotEmpty();
        }
    }
}