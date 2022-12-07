using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Repository
{
  public class MasterSalaryManagement : IMasterSalaryManagement
  {
    private readonly EmployeeDbContext _employeeDbContext;

    private readonly IMapper mapper;
    public MasterSalaryManagement(EmployeeDbContext employeeDbContext, IMapper mapper)
    {
      _employeeDbContext = employeeDbContext;
      this.mapper = mapper;
    }


    public void AddSalary(MasterSalaryDto masterSalaryDto)
    {
    //     foreach(var Employee_id in masterSalaryDto.Employee_id ){
    //         foreach(int compId in ){

    //  _employeeDbContext.EmployeeSalary.Add(); 
    //         }
    //     }

    }
  }
}