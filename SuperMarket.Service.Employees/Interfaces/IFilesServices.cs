using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface IFilesServices
    {
        public void AddFilesService(FilesModel file,int id);
        public string Get(int id);
    }
}