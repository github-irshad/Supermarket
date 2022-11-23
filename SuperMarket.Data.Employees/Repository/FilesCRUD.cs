using SuperMarket.Data.Employees.Interfaces;
using SuperMarket.Data.Employees.Models;
using Microsoft.AspNetCore.Hosting;

namespace SuperMarket.Data.Employees.Repository
{
  public class FilesCRUD : IFilesCRUD
  {
    private readonly IWebHostEnvironment webHostEnvironment;
    public FilesCRUD(IWebHostEnvironment webHostEnvironment)
    {
      this.webHostEnvironment = webHostEnvironment;
    }

    public void AddFile(FilesModel filesModel)
    {
    
        if (filesModel.files.Length > 0)
        {
          if (!Directory.Exists(webHostEnvironment.WebRootPath + "\\Uploads\\"))
          {
            Directory.CreateDirectory(webHostEnvironment.WebRootPath + "\\Uploads\\");
            }
            using(FileStream fileStream = System.IO.File.Create(webHostEnvironment.WebRootPath+"\\Uploads"+filesModel.files.FileName)){
              filesModel.files.CopyTo(fileStream);
              fileStream.Flush();
              
          }
        }
      
    }
  }
}