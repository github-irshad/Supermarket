using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Api.Employees.Controllers
{
  [ApiController]
  [Route("File")]
  public class FileController : ControllerBase
  {
    private readonly IFilesServices filesServices;
    

    public FileController(IFilesServices filesServices)
    {
      this.filesServices = filesServices;
    
    }

    [HttpPost("Upload")]
    public ActionResult Post([FromForm]FilesModel fileobj)
    {      
        filesServices.AddFilesService(fileobj);
        return Ok();
      
    }
  }
}