using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Api.Employees.Middleware
{
  public class SuperMarketAPIMiddleware : IMiddleware
  {
    public Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      throw new NotImplementedException();
    }
  }
}