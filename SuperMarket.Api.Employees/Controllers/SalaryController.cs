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
    public IActionResult GetSalaryComps()
    {


      return Ok(salaryService.ShowSalaryComps());
    }

    


    [HttpPut]
    [Route("Component/Edit")]
    public ActionResult EditComp(SalaryRequestDto changeRequest, int id)
    {
      salaryService.EditComponent(changeRequest, id);
      return Ok();
    }

    // [HttpDelete]
    // [Route("Component/Delete/{id}")]
    // public ActionResult DeleteComp(int id)
    // {
    //   salaryService.DeleteComponent(id);
    //   return Ok();
    // }

    //Master Salary Controllers

    [HttpPost]
    [Route("Add/{id}")]
    public ActionResult AddSalaries(int id,MasterSalaryReq salaryDto)
    {
      masterSalaryService.AddSalary(id,salaryDto);
      return Ok();
    }

    [HttpDelete]
    [Route("Delete/{EmpId}/{CompId}")]
    public ActionResult DeleteSalaryComp(int EmpId, int CompId)
    {
      masterSalaryService.DeleteSalary(EmpId, CompId);
      return Ok();
    }

    [HttpGet]
    [Route("View/{EmpId}/All")]
    public ActionResult GetSalariesofEmp(int EmpId){
        // masterSalaryService.GetSalariesofAnEmp(EmpId);
      // var result =  masterSalaryService.GetSalariesofAnEmp(EmpId);
      return Ok(
        masterSalaryService.GetSalariesofAnEmp(EmpId)
      );
    }


    //Salary Calculations

    [HttpGet]
    [Route("Totals/{id}")]
    public ActionResult GetTotalSalary(int id){
      return Ok(
        salaryService.salariesTotals(id)
      );
    }

    // [HttpGet]
    // [Route("Gross/{id}")]
    // public ActionResult GetGrossSalary(int id)
    // {
    //   return Ok(
    //     salaryService.GrossSalaryService(id)
    //   );
    // }
  }
}