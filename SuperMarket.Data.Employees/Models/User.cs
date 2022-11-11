using System.ComponentModel.DataAnnotations;
using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  public class User : CommonProps
    {
        public int UserId {get; set;}

        // [Required]
        public string? UserName {get; set;}

        // [Required]
        public string? Password {get; set;}
        public  UserType UserType {get; set;}



    }
}