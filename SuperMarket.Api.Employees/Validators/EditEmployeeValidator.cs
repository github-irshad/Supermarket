using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Api.Employees.Validators
{
  public class EditEmployeeValidator : AbstractValidator<EditEmployee>
  {
    public EditEmployeeValidator()
    {

      RuleFor(x => x.Email).EmailAddress();
      RuleFor(x => x.FirstName).NotEmpty();
      RuleFor(x => x.PhoneNumber).NotEmpty();
      RuleFor(x => x.AadharNumber).NotEmpty();
      RuleFor(x => x.LastName).NotEmpty();
      // RuleFor(x => x.AadharDocument).NotEmpty();
      RuleFor(x => x.Designation).NotEmpty();
      RuleFor(x => x.Address).NotEmpty();
      RuleFor(x => x.Department).NotEmpty();
      // RuleFor(x=>x.UserType).NotEmpty();
    }
  }
}