using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarket.Data.Employees.Models;
using SuperMarket.Data.Employees.RequestModel;

namespace SuperMarket.Service.Employees.Interfaces
{
    public interface ISalaryService
    {
        public void SalaryDtoToEntity(SalaryRequestDto requestDto);
        public IEnumerable<SalaryComponents> ShowSalaryComps();
        public void EditComponent(SalaryRequestDto changeRequest, int id);

        // public void DeleteComponent(int id);

        // public double NetSalaryService(int Id);

        // public double GrossSalaryService(int id);
        public SalariesTotals salariesTotals(int id);
    }
}