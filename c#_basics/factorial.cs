using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, i, f;
            Console.WriteLine("enter a no");
            e = int.Parse(Console.ReadLine());
            f = 1;
            for (i = 1; i <= e; i++)
            {
                f = f * i;
                
            }
            Console.WriteLine("factorial of {0}={1}", e, f);
            Console.ReadKey();
        }
    }
}
