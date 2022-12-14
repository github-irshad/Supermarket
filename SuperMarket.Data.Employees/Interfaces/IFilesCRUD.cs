using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Interfaces
{
    public interface IFilesCRUD
    {
        public void AddFile(FilesModel filesModel,int id);

        public string GetFile(int id);

        public void DeleteFile(int id);
    }
}