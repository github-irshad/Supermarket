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

    public void AddFile(FilesModel filesModel,int id)
    {
    
        if (filesModel.files.Length > 0)
        {
          if (!Directory.Exists(webHostEnvironment.WebRootPath + "\\Uploads\\"+id.ToString()))
          {
            Directory.CreateDirectory(webHostEnvironment.WebRootPath + "\\Uploads\\"+id.ToString());
            }
            using(FileStream fileStream = System.IO.File.Create(webHostEnvironment.WebRootPath+"\\Uploads\\"+id.ToString()+"\\"+id.ToString()+".jpeg")){
              filesModel.files.CopyTo(fileStream);
              fileStream.Flush();
              
          }
        }
      
    }

    public string GetFile(int id)
    {
      return webHostEnvironment.WebRootPath+"\\Uploads\\"+id.ToString()+"\\"+id.ToString()+".jpeg";
    }

    public void DeleteFile(int id){
      var filepath = webHostEnvironment.WebRootPath+"\\Uploads\\"+id.ToString()+"\\"+id.ToString()+".jpeg";
      if(System.IO.File.Exists(filepath)){
        System.IO.File.Delete(filepath);
      }

    }
  }
}