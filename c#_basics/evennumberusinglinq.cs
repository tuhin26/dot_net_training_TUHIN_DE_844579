using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumberusinglinq
{
    class Program
    {
        static void Main(string[] args)
        {

            big();

        }
        public static void big()
        {
            int a = 9, b = 18, c = 3;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("big ={0}", a);

                }
                else
                {
                    Console.WriteLine("big = {0}", c);
                }

            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("big = {0}", b);
                }
                else
                {
                    Console.WriteLine("big = {0}", c);
                }
            }
        }
    }
}
