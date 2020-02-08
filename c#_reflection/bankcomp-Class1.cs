using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankComp
{
    public class SavingsBank
    {
        public  double simpleinterest(double p,int t, double r)
        {
            var si = (p * t * r) / 100;
            return si;

        }
        public double getbalance(double si, double p)
        {
            var balance = si + p;
            return balance;
        }
    }
}
