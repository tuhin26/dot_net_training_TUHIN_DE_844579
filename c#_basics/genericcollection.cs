using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace genericcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList item = new ArrayList(100);

            item.Add("hello");

            item.Add(13);

            item.Add(DateTime.Now);

            foreach (object obj in item)
            {
                Console.WriteLine(obj.ToString());

            }
            List<int> myitem = new List<int>();

            myitem.Add(13);
            //myitem.Add("hi");//showing error
            myitem.Add(12);

            foreach (var n in myitem)
            {
                Console.WriteLine(n.ToString());

            }

            List<string> employee = new List<string>() { "tuhin", "mohan", "vimal", "anup" }; // collection initializer

            foreach (var r in employee)
            {
                Console.WriteLine(r.ToString());

            }

            Dictionary<int, string> fruit = new Dictionary<int, string>();

            fruit.Add(1, "mango");
            fruit.Add(2, "banana");

            foreach (KeyValuePair<int, string> kv in fruit)
                Console.WriteLine("key-> {0} , value-> {1}", kv.Key, kv.Value);

            //delete an item and add another

            fruit.Remove(1);
            fruit.Add(1, "apple");

            foreach (KeyValuePair<int, string> kv in fruit)
                Console.WriteLine("key-> {0} , value-> {1}", kv.Key, kv.Value);

            SortedDictionary<int, string> book = new SortedDictionary<int, string>();

            book.Add(1, "a");
            book.Add(3, "c");
            book.Add(2, "b");

            foreach (KeyValuePair<int, string> kv in book)
                Console.WriteLine("key-> {0} , value-> {1}", kv.Key, kv.Value);
            employee emp1 = new employee() {empid= 1, empname="tuhin", deptname="tech" };
            employee emp2 = new employee() { empid = 2, empname = "mohan", deptname = "manager" };
            employee emp3 = new employee() { empid = 3, empname = "vimal", deptname = "admin" };

            List<object> a = new List<object>();

            a.Add(emp1);

            a.Add(emp2);

            a.Add(emp3);

            foreach (employee emp in a)
            {
                Console.WriteLine("empid={0}  empname={1}  deptname ={2}", emp.empid, emp.empname, emp.deptname);
    
            }

            Console.ReadKey();




        }
    }
    public class employee
    {
        public int empid
        {
            get;
            set;
        }
        public string empname
        {
            get;
            set;
        }
        public string deptname
        {
            get;
            set;

        }
        



    }
}
