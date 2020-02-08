using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate double saldelegate(int ds, float sd);
        static void Main(string[] args)
        {
            saldelegate deleg = new saldelegate(getsalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("salary = {0}"; salary);
            Console.ReadKey();
        }
        public static double getsalary(int nds,float spd)
        {
            var salary = (nds + spd);
            return salary;
        }
    }
}
