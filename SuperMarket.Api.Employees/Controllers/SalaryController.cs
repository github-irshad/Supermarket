using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.RequestModel;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("Salary")]
  public class SalaryController : ControllerBase
  {
    private readonly ISalaryService salaryService;
    private readonly IMasterSalaryService masterSalaryService;

    public SalaryController(ISalaryService salaryService, IMasterSalaryService masterSalaryService)
    {
      this.salaryService = salaryService;
      this.masterSalaryService = masterSalaryService;
    }

    [HttpPost]
    [Route("Component/New")]
    public ActionResult AddNewSalaryComp(SalaryRequestDto salaryRequest)
    {
      salaryService.SalaryDtoToEntity(salaryRequest);
      return Ok();
    }

    [HttpGet]
    [Route("Components/All")]
    public IActionResult GetSalaryComps(){
        
        
        return Ok(salaryService.ShowSalaryComps());
    }

    [HttpPut]
    [Route("Component/Edit")]
    public ActionResult EditComp(SalaryRequestDto changeRequest, int id){
        salaryService.EditComponent(changeRequest,id);
        return Ok();
    }

    [HttpDelete]
    [Route("Component/Delete/{id}")]
    public ActionResult DeleteComp(int id){
        salaryService.DeleteComponent(id);
        return Ok();
    }

    //Master Salary Controllers

    [HttpPost]
    [Route("Add")]
    public ActionResult AddSalaries(MasterSalaryDto salaryDto){
        masterSalaryService.AddSalary(salaryDto);
        return Ok();
    }
  }
}