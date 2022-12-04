using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuperMarket.Api.Employees.Exception;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Api.Employees.Middleware
{
  public class SuperMarketExceptionMiddleware : IMiddleware
  {

    // var errorModel = new ErrorModel()
    // {
    // //  ResponseCode = Enum.GetName(typeof(HttpStatusCode.InternalServerError),500),
    //  ResponseCode = 500,
    //  Message = "An error occured",
    //  Error = new List<string>{ex.Message}   
    // };

    // context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
    // context.Response.ContentType = MediaTypeNames.Application.Json;

    // await context.Response.WriteAsync(JsonConvert.SerializeObject(errorModel));
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      try
      {
        await next(context);
      }

      catch (DomainNotFoundException e)
      {
        
        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
        await context.Response.WriteAsync(e.Message);
      }
      catch(DomainValidationException e)
      {
        context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        await context.Response.WriteAsync(e.Message);
      }
      catch(System.Exception e)
      {
       context.Response.StatusCode = 500;
        await context.Response.WriteAsync(e.Message); 
      }
    }
  }
}
