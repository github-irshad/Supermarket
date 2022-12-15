using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Mapping
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<AddEmployee, Employee>();
      CreateMap<EditEmployee, Employee>();
      CreateMap<AddEmployeeDto, AddEmployee>();
      CreateMap<UserDto, User>();
      CreateMap<SalaryRequestDto, SalaryComponents>();
      // CreateMap<List<SalaryComponents>,List<SalaryCompShowDto>>();
      CreateMap<EmpSalaryDto, EmployeeSalary>();
      CreateMap<MasterSalaryReq, MasterSalaryDto>();
      // CreateMap<List<EmployeeSalary>,List<EmpSalaryReqDto>>();

    }
  }
}