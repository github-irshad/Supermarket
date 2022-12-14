using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Data;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Repository
{
  public class SalaryManagement : ISalaryManagement
  {
    private readonly EmployeeDbContext employeeDbContext;
    private readonly IMapper mapper;

    public SalaryManagement(EmployeeDbContext employeeDbContext, IMapper mapper)
    {
      this.employeeDbContext = employeeDbContext;
      this.mapper = mapper;
    }

    public void AddSalaryComponent(SalaryComponents salaryComponent)
    {
      employeeDbContext.SalaryComponents.Add(salaryComponent);
      employeeDbContext.SaveChanges();
    }

    public void DeleteComponent(int id)
    {

      employeeDbContext.SalaryComponents.Remove(
        employeeDbContext.SalaryComponents.Where(x => x.Id == id).FirstOrDefault()
      );
      employeeDbContext.SaveChanges();

    }

    

    public void EditComponent(int id,SalaryRequestDto editedSalaryComp)
    {
      var editComp = employeeDbContext.SalaryComponents.Where(x=>x.Id == id).FirstOrDefault();
      
      mapper.Map<SalaryRequestDto,SalaryComponents>(editedSalaryComp,editComp);

      employeeDbContext.SaveChanges();
      
    }

    public IEnumerable<SalaryComponents> GetSalaryComponents()
    {
      return employeeDbContext.SalaryComponents.ToList();
      // return mapper.Map<List<SalaryComponents>,List<SalaryCompShowDto>>(salaryComponent);
    }

    public string CompToString(int id){
     var selectedComp = employeeDbContext.SalaryComponents.Where(x => x.Id == id).FirstOrDefault(); 
     return selectedComp.ComponentName;
    }


    
  }
}