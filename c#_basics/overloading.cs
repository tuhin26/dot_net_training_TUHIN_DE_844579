
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            maths m = new maths();
            var c = m.add(50, 89);
            Console.WriteLine("sum (int) = {0}", c);

           
           c = m.add(5.99, 8.09);
            Console.WriteLine("sum (double) = {0}", c);
            Console.ReadKey();

        }
    }
    public class maths
    {
        public double add(int a , int b)
        {
            int c = a + b;
            return c;
        }

        public double add(double a, double b)
        {
            double c = a + b;
            return c;
        }
    }
}
