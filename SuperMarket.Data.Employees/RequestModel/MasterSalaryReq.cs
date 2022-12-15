using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket.Data.Employees.RequestModel
{
    public class MasterSalaryReq
    {
        public List<EmpSalaryReqDto> SalaryComps { get; set; }
    }
}