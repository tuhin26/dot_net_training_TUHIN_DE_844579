using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            if (a > 10)
            {
                Console.WriteLine("good mornging");
            }
            else if (a < 10)
            {
                Console.WriteLine("good evening");
            }
            else
                Console.WriteLine("good night");
            int b = 3;
            switch (b)
            {
                case 1:
                    {
                        Console.WriteLine("hey");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("hi");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("hello");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("hola");
                        break;
                    }
            }
            Console.WriteLine("enter the no");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", n, i, n * i);

            }
            int t = 10;

            do
            {
                Console.WriteLine("{0} is less than 100", t);
                t = t + 10;

            }
            while (t < 100);

            int y = 10;

            while (y < 100)
            {

                Console.WriteLine("{0} is less than 100", y);
                y = y + 10;


            }
            Console.ReadKey();

            int e, i, f;
            Console.WriteLine("enter a no");
            e = int.Parse(Console.ReadLine();
            f = 1;
            for(i=1;i<=e;i++)
            {
                f = f * i;
                Console.WriteLine("factorial of {0}={1}", e, f);
                
            }

        }
    }
}