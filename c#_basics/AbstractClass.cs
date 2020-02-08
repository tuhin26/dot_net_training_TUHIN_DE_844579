using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            sbaccount objsb = new sbaccount();

            ccaccount objcc = new ccaccount();

            double sisb = objsb.getsimpleinterest(95000.00, 5, 8);
            double total = objsb.gettotalamount(50000, sisb);

            Console.WriteLine("simple interest(savings account) ={0}", sisb);
            Console.WriteLine("total amount {0}", total);

            double sicc = objcc.getsimpleinterest(95000.00, 5, 8);
            double totalcc = objcc.gettotalamount(50000, sicc);

            Console.WriteLine("simple interest(current account) ={0}", sicc);
            Console.WriteLine("total amount {0}", totalcc);
            objsb.show(); //calling the concrete method define with in the banking base class
        }
    }
    public abstract class banking
    {
        public abstract double getsimpleinterest(double pr, int td, short rt);
        public abstract double gettotalamount(double bal, double si);
        public void show()
        {
            Console.WriteLine("example of abstract class");

        }
    }
    public class sbaccount : banking

    {
        public override double getsimpleinterest(double pr, int td, short rt)
        {
            double si = (pr * td * rt) / 100;
            return si;

        }

        public override double gettotalamount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }

    }
    public class ccaccount : banking
    {
        public override double getsimpleinterest(double pr, int td, short rt)
        {
            double si = 0.25 * (pr * td * rt) / 100;
            return si;

        }
        public override double gettotalamount(double bal, double si)
        {
            double tamount = bal + si;
            return tamount;
        }
    }
}