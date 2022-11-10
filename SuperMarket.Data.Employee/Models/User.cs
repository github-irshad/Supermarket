using SuperMarket.Data.Employee.Common;

namespace SuperMarket.Data.Employee.Models
{
  public class User : CommonProps
    {
        public int Id {get; set;}
        public string UserName {get; set;}

        public string Password {get; set;}
        public  string UserType {get; set;}

    }
}