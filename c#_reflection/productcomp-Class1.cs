using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productcomp
{
    public class productcomp
    {
        public int productid
        { get; set; }
        public string productname
        { get; set; }
        public int orderid
        { get; set; }

        public double getprice(int price ,double tax)
        {
            double tp = price + tax;
            return tp;
        }
    }
}
