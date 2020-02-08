using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace threadpriority
{
    class Program
    {
        public static long count1, count2;
        static void Main(string[] args)
        {
            Console.WriteLine("the main thread started");

            Thread t1 = new Thread(increamentcount1);
            Thread t2 = new Thread(increamentcount2);

            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            Thread.Sleep(10000);

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("count1 is {0}", count1);
            Console.WriteLine("count2 is {0}", count2);

            Console.WriteLine("the main thread exited");
        }
        public static void increamentcount1()
        {
            while(true)
            {
                count1 = count1 + 1;

            }
            
        }
        public static void increamentcount2()
        {
            while (true)
            {
                count2 = count2 + 1;

            }
            
        }
    }
}
    