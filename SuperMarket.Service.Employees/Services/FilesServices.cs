using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Service.Employees.Interfaces;

namespace SuperMarket.Service.Employees.Services
{
  public class FilesServices : IFilesServices
  {

    private readonly IFilesCRUD filesOp;

    public FilesServices(IFilesCRUD filesOp)
    {
      this.filesOp = filesOp;
    }

    public void AddFilesService(FilesModel file,int id)
    {
      filesOp.AddFile(file,id);
      
    }
    public string Get(int id){
      return filesOp.GetFile(id);
    }
  }
}