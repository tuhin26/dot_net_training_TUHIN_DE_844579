using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndArraysDemo
{
    class Program
    {
        enum department
        {
            physics = 10,
            chemistry = 12,
            mathematics = 15,
            biology = 18
        };

        enum color
        {
            red = 19,
            blue ,
            green 


        };

        static void Main(string[] args)
        {
            Console.WriteLine("dept id of physics: {0}", (int)department.physics);
            Console.WriteLine("dept id of chemistry: {0}", (int)department.chemistry);
            Console.WriteLine("dept id of mathematics: {0}", (int)department.mathematics);
            Console.WriteLine("dept id of biology: {0}", (int)department.biology);

            Console.WriteLine("the color red indicates: {0}", (int)color.red);
            Console.WriteLine("the color blue indicates: {0}", (int)color.blue);
            Console.WriteLine("the color green indicates: {0}", (int)color.green);

            Console.ReadKey();
        }
    }
}
