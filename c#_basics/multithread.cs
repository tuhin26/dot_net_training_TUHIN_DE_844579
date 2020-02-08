using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithread
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("main thread started");

            Thread t = Thread.CurrentThread;
            t.Name = "main thread";
            Console.WriteLine("{0} is starting with id {1}", t.Name, t.ManagedThreadId);
            //method1();
            //method2();
            //method3();

            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            Thread t3 = new Thread(method3);
           // ParameterizedThreadStart p = new ParameterizedThreadStart(test);
            Thread tp = new Thread(new ParameterizedThreadStart(test));
            Thread t4 = new Thread(area);

            t1.Start();
            t2.Start();
            t3.Start();
            tp.Start(100);
            t4.Start();
            t1.Join(); t2.Join();t3.Join();tp.Join();t4.Join();
            Console.WriteLine("main thread exited");
            

        }
        public static void method1()
        {
            for (int i=0;i<=30;i++)
            {
                Console.WriteLine("method1 {0}", i);
            }
        }
        public static void method2()
        {
            for (int i = 0; i <= 40; i++)
            {
                if (i==20)
                {
                    Thread.Sleep(5000);
                }
                Console.WriteLine("method2 {0}", i);
            }
        }
        public static void method3()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("method3 {0}", i);
                
            }
        }
        public static void test(object max)
        {
            int j = Convert.ToInt32(max);
            for(int i =1;i<= j; i++)
            {
                Console.WriteLine("test {0}", i);
            }
        }
        public static void area()
        {
            double l, b;
            Console.WriteLine("enter the length");
            //l=double.Parse(Console.ReadLine());
            l = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the breadth");
            b =double.Parse(Console.ReadLine());
            var a = l * b;

            Console.WriteLine("area is {0}", a);
        }
    }
}
