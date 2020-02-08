using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    class Program
    {
        public delegate void maths(int a, int b);
        static void Main(string[] args)
        {
            maths m = new maths(add);

            

            m += substract;
            

            m += multi;
           

            m += div;
            m.Invoke(70, 54);


        }

        public static void add(int x, int y)
        {
            double c = x + y;
            Console.WriteLine("sum = {0}", c);

        }
        public static void substract(int x, int y)
        {
            double c = x - y;
            Console.WriteLine("substraction = {0}", c);

        }
        public static void multi(int x, int y)
        {
            double c = x * y;
            Console.WriteLine("multiplication = {0}", c);

        }
        public static void div(int x, int y)
        {
            double c = x / y;
            Console.WriteLine("div = {0}", c);

        }
    }
}
