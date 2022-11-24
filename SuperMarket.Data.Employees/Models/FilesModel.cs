using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperMarket.Data.Employees.Models
{
    public class FilesModel
    {
        public IFormFile? files {get; set;}
    }
}