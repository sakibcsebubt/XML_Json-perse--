using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass1;

namespace TestDataClass1
{
    public class DataList1
    {
        public List<TestClass1.Company.employeeinfo> employeeinfos = new List<Company.employeeinfo>();

        public DataList1()
        {

        }
        public DataList1(bool isgetdata = false)
        {
            if (isgetdata)
                this.getemployee();
        }
        public void getemployee()
        {
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Jamman", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Sakib ", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Shoukhin", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Baizid", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Hasan", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
            employeeinfos.Add(new Company.employeeinfo() { EmpID = 00111, EmpName = "Mr. Anirudho", Empage = 25, Empjoindate = DateTime.Parse("10-Jan-2012"), Empsalary = 25000 });
        }

       
    }
}
