using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegates1
{
    class Program
    {
        public delegate double saldelegate(int ds, float sd);
        static void Main(string[] args)
        {
            saldelegate deleg = new saldelegate(getsalary);
            var salary = deleg.Invoke(30, 800);
            Console.WriteLine("salary = {0}", salary);

          //  deleg = new saldelegate(getincentive);
            deleg += getincentive;
            var incent = deleg.Invoke(30, 800);
            Console.WriteLine("incentive = {0}", incent);
            Console.ReadKey();
        }
        public static double getsalary(int nds, float spd)
        {
            var salary = (nds * spd);
            return salary;
        }

        public static double getincentive(int nds, float spd)
        {
            var incent = 0.1*(nds * spd);
            return incent;
        }
    }
}
