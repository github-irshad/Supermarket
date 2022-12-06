using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class SalaryService : ISalaryService
  {
    private readonly ISalaryManagement salaryManagement;
    private readonly IMapper mapper;

    public SalaryService(ISalaryManagement salaryManagement, IMapper mapper)
    {
      this.salaryManagement = salaryManagement;
      this.mapper = mapper;
    }

    public void DeleteComponent(int id)
    {
      salaryManagement.DeleteComponent(id);
    }

    public void EditComponent(SalaryRequestDto changeRequest, int id)
    {
      salaryManagement.EditComponent(id,changeRequest);
    }

    public void SalaryDtoToEntity(SalaryRequestDto requestDto)
    {

      var salaryModel = mapper.Map<SalaryRequestDto, SalaryComponents>(requestDto);

      salaryModel.Created_at = DateTime.UtcNow;
      salaryModel.Updated_at = DateTime.UtcNow;

      salaryModel.Created_by = 0;
      salaryModel.Updated_by = 0;

      salaryManagement.AddSalaryComponent(salaryModel);
    }

    public IEnumerable<SalaryComponents> ShowSalaryComps()
    {
      return salaryManagement.GetSalaryComponents();
    //   mapper.Map<SalaryComponents,SalaryCompShowDto>(salaryComponent);
    }
  }
}