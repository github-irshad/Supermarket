using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface IDocumentService
    {
       public void AddDocumentsService(IFormFile files);
    }
}