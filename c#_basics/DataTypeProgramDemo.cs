using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypesProgramDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bb = 255;
            short s = 99;
            int n = 98;
            long l = 565787878;
            float f = 10.99f;
            double ddd = 30.99;
            decimal m = 999.99m;

            Console.WriteLine("values of bb={0} , s={1} , n={2} , l={3} , f={4} , ddd={5} , m={6}", bb, s, n, l, f, ddd, m);

            DateTime dd = DateTime.Now;

            Console.WriteLine("the current day is : {0}", dd);

            Console.WriteLine("the current short date is : {0}", dd.ToShortDateString());

            Console.WriteLine("the current long date is : {0}", dd.ToLongDateString());

            Console.WriteLine("the current time is : {0}", dd.ToShortTimeString());

            Console.WriteLine("the current long time is : {0}", dd.ToLongTimeString());

            int a, b;
            a = 50;
            b = 60;

            Add(a, b);

            double result = Multiply(a, b);

            Console.WriteLine("the multiplication of {0} , {1} ={2}", a, b, result);


            Console.ReadKey();


        }

        public static void Add(int a, int b)
        {
            double d = a + b;

            Console.WriteLine("the addition of {0} , {1} ={2}",a,b,d);




        }
            
        public static double Multiply(int a , int b)
        {

            double d = a * b;
            return d;
        }
        
            
    }
    
}
