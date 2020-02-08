using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComp;

namespace SbClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsBank sb = new SavingsBank();
            var si = sb.simpleinterest(50000.00, 5, 8.00);

            Console.WriteLine("the simple interest is {0}", si);

            var bal = sb.getbalance(si,50000.00);
            Console.WriteLine("balance is {0}", bal);
            Console.ReadKey();

        }
    }
}
