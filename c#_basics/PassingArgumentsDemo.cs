using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passing_ArgumentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing and unboxing
            object obj ; //object as refference type

            int a = 10;

            obj = a; //converting a value type to refference type implicitly called boxing

            int b = (int)a; // converting a refference/boxed type to value type called unboxing

            Console.WriteLine("the values of a = {0} and b = {1}", a, b);

            

            //Passing_Argument by value type

            int i, j;
            i = 10;
            j = 20;
            //double sum= show(i, j);

            double sum = show(ref i, ref j);
            Console.WriteLine("the values of i = {0} and j = {1}", i, j);
            Console.WriteLine("sum = {0}", sum);
            Console.ReadKey();

        }
        public static double show(ref int  a,ref int  b)
        {
            double c = a + b;

            a = a + 5;
            b = b + 5;
            return c;
        }


    }
}
