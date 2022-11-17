

using Microsoft.AspNetCore.Http;
using SuperMarket.Data.Employees.Models;

namespace SuperMarket.Data.Employees.Interfaces
{
  public interface IEmployeeManagement
  {
    public IEnumerable<Employee> GetAllEmployees();
    public Employee GetEmployeeById(int id);
    // public void DeleteEmployee(int id);
    public void AddNewEmployee(Employee newEmployee);
    // public Employee UpdateEmployee(int id, UpdateEmployeeModel updateEmployeeModel);


    //Document CRUD operations
    public void AddDocuments(IFormFile files);

    public string GetDocumentById(int Id);

    public void DeleteDocument(int Id);

    public string UpdateDocument(int Id);
  }
}