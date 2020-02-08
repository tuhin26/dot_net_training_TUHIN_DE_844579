using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
           var msg = name(55 ,"joy");
            Console.WriteLine(msg);

            Console.ReadKey();
           

        }
        public static string name(uint a ,string empname)
        {
            
          
          return  string.Format("congratulation {0} its your {1}th birthday", empname, a);



        }

    }
}
