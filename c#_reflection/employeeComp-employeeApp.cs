using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeComp;

namespace employeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee() { empid =1, empname= "tuhin",deptname= "tech" };
           var x= emp.showdata();
            Console.WriteLine(x);
            var b = emp.getsalary(30, 700);

            Console.WriteLine("salary = {0}", b);

            var t = emp.incentive(b);

            Console.WriteLine("incentive = {0}", t);
            Console.ReadKey();
        }
    }
}
