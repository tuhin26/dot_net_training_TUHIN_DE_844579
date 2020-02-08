using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack is lifo and queue is fifo

            Stack<float> fnumber = new Stack<float>();

            fnumber.Push(10.90f);
            fnumber.Push(12.90f);
            fnumber.Push(106.90f);
            fnumber.Push(19.90f);

            foreach (var fn in fnumber) 
            Console.WriteLine(fn);

            fnumber.Pop();
            Console.WriteLine("after pop");
            foreach (var fn in fnumber)
                Console.WriteLine(fn);
            Console.WriteLine("queue");
            Queue<int> q = new Queue<int>();

            q.Enqueue(2);
            q.Enqueue(20);
            q.Enqueue(270);
            q.Enqueue(5);
            foreach (var fn in q)
                Console.WriteLine(fn);
            q.Dequeue();
            Console.WriteLine("after dequeue");
            foreach (var fn in q)
                Console.WriteLine(fn);

            Console.ReadKey();
        }
    }
}
