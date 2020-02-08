using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace code1stdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            productDBContext context = new productDBContext();
            var order = context.orders;
            var o4 = order.Add(new order() {id=4,name="book",customerId=1});
            //var o25 = order.Add(new order() { orderid = 5, name = "laptop",customerId = 1 });
            //var o6 = order.Add(new order() { orderid = 6, name = "phone", customerId = 3 });

            context.SaveChanges();

        }   }

        public class productDBContext : DbContext
        {
            public productDBContext() : base("name=productDBContext")
            {

            }
            public DbSet<customer> customers { get; set; }
            public DbSet<order> orders { get; set; }

        }
    
    public class customer
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
    public class order
    {
        public int id { get; set; }
        public string name { get; set; }
        public int customerId { get; set; }
    }
}
