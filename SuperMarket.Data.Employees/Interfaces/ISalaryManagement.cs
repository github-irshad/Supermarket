using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Data.Employees.Interfaces
{
  public interface ISalaryManagement
    {
        public void AddSalaryComponent(SalaryComponents salaryComponent);

        public IEnumerable<SalaryComponents> GetSalaryComponents();

        public void DeleteComponent(int id);

        public void EditComponent(int id,SalaryRequestDto editedSalaryComp);

        
    }
}