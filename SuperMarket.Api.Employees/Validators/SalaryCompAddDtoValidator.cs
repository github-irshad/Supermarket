using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Api.Employees.Validators
{
    public class SalaryCompAddDtoValidator : AbstractValidator<SalaryRequestDto>
    {
        public SalaryCompAddDtoValidator()
        {
            RuleFor(x=>x.ComponentName).NotEmpty();
            RuleFor(x=>x.ComponentType).NotEmpty();
            RuleFor(x=>x.Description).NotEmpty();
        }
    }
}