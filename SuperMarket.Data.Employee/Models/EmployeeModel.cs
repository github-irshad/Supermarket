namespace SuperMarket.Data.Employee.Models
{
  public class EmployeeModel
    {
        
        public int EmployeeModelId {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? Address {get; set;}
        public int AadharNumber {get; set;}
        public string? AadharDocument {get; set;}
        public bool isVerified {get; set;}
        public string? Designation {get; set;}
    }
}