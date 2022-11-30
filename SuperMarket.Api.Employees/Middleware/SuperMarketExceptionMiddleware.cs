using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Api.Employees.Middleware
{
  public class SuperMarketExceptionMiddleware : IMiddleware
  {

    // private readonly RequestDelegate request;
    private readonly ILogger logger;
    public SuperMarketExceptionMiddleware(ILogger logger)
    {
        // this.request = request;
        this.logger = logger;
    }


    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      try
      {
        await next(context);
      }
      catch (Exception ex)
      {
        
        logger.LogError(ex,ex.Message);
        await HandleExceptionAsync(context,ex);
        
      }
    }

    private async Task HandleExceptionAsync(HttpContext context,Exception ex ){

        var errorModel = new ErrorModel()
        {
        //  ResponseCode = Enum.GetName(typeof(HttpStatusCode.InternalServerError),500),
         ResponseCode = 500,
         Message = "An error occured",
         Error = new List<string>{ex.Message}   
        };

        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = MediaTypeNames.Application.Json;

        await context.Response.WriteAsync(JsonConvert.SerializeObject(errorModel));
    }
  }
}