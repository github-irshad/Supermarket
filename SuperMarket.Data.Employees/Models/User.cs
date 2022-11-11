using SuperMarket.Data.Employees.Common;


namespace SuperMarket.Data.Employees.Models
{
  public class User : CommonProps
    {
        public int Id {get; set;}
        public string UserName {get; set;}

        public string Password {get; set;}
        public  UserType UserType {get; set;}



    }
}