using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadlocking
{
    class threadlock
    {
        static void Main(string[] args)
        {
            threadlock tl = new threadlock();
            Thread t1 = new Thread(tl.display);
            Thread t2 = new Thread(tl.display);
            Thread t3 = new Thread(tl.display);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();

        }

        public void display()
        {
           lock (this) //this locks the resource for any thread to complete its task of execution
            {
                Console.Write("csharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine(" oop");
            }
        }
    }
}
