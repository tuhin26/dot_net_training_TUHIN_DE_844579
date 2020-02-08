using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 30;
            b = 46;
            Console.WriteLine("before swapping a = {0} b = {1}", a, b);
            swap<int>(ref a,ref  b);

            Console.WriteLine("after swapping a = {0} b = {1}", a, b);

            string s1, s2;
            s1 = "hello";
            s2 = "hi";
            Console.WriteLine("before swapping s1 = {0} s2 = {1}", s1, s2);

            swap<string>(ref s1, ref s2);

            Console.WriteLine("after swapping s1 = {0} s2 = {1}", s1, s2);


        }
        public static void swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;

        }
    }
}
