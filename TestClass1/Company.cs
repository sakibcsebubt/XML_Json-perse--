using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass1
{
    public class Company
    {
        public class employeeinfo
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public int Empage { get; set; }
            public DateTime Empjoindate { get; set; }
            public decimal Empsalary { get; set; }

        }

    }
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
    }
}
