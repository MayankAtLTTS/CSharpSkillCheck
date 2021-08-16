using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport : Employee
    {
        private object p;
        private string v;

        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJ, Employee managerEmpObj,string pCode) :base(eID,eName,eLevel,eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
        public DirectReport() : base() { }

        
    }
}
