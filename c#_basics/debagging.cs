using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debagging
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 5;
            b = 6;
            var c = multiply(a, b);
            Console.WriteLine("multiplication is {0}", c);

            for(int i =0;i<=3;i++)
            {
               int x = 4 + i;

                Console.WriteLine("Result = {0}",x);
            }
            Console.ReadKey();


        }
        public static double multiply(int a, int b)
        {

            var c = a * b;
            return c;
        }
        
    }
}
