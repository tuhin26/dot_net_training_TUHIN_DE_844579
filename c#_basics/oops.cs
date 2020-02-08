using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(); //instantiation of employee class using new keyword
            employee emp1 = new employee(1,"tuhin",3,"tech");  //instantiation of employee class using constructior
            employee emp2 = new employee(4, "mohan", 1, "admin");

            emp1.showdata(); //instance method should be called with an object refference
            emp2.showdata();

            product prd = new product() { productid = 1, productname = "badam shake", productprice = 25 };

            customer c = new customer() { customerid = 1, customername = "tuhin", country = "india" };

            prd.showdata();
            c.showdata();

            Console.ReadKey();

        }
    }

    public class employee ////access specifier is internal by default for class
    {
        int empid;//access specifier is private by default for class member
        string empname;
        short deptid;
        string deptname;

        public employee() // default constructor
        { }

       // public employee(int eid , string ename) //constructor with two parameters
       // {
            //empid = eid;
           // empname = ename;

       // }

        public employee(int eid, string ename, short did, string dname) // constructor with 4 parameters
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }

        public  void showdata()  //instance method
        {
            Console.WriteLine("empid = {0}", empid);
            Console.WriteLine("empname = {0}", empname);
            Console.WriteLine("dept id = {0}", deptid);
            Console.WriteLine("dept name = {0}", deptname);

        }
    }

    //access specifier - private , protected , public , internal , protected internal.
    //private- can only be accessed within the class where its defined
    //protected - can only be accessed within the base and derived class
    //public - can be accessed with in class and outside of that class or assembly
    //internal - can be accessed only within the current assembly of where that class is defined
    //protected internal - can be accessed anywhere with in the current assembly and
    //only within the derived class of that assembly

    public class product
    {
        int pid;
        //defining the properties for the class
        public int productid
        {
            get { return pid; }
            set { pid = value; }
        }


        //automatic properties, compiler does implementation here
        public string productname
        {
            get;
            set;
        }

        public int productprice
        {
            get;
            set;
        }

        public void showdata()
        {
            Console.WriteLine("productid = {0}", productid);
            Console.WriteLine("productname = {0}", productname);
            Console.WriteLine("productprice = {0}", productprice);
        }
    }

    public class customer
    {
        int cid;
        public int customerid
        {
            get { return  cid; }
            set { cid = value; }
        }


        
        public string customername
        {
            get;
            set;
        }

        public string country
        {
            get;
            set;
        }

        public void showdata()
        {
            Console.WriteLine("customerid = {0}", customerid);
            Console.WriteLine("customername = {0}",customername);
            Console.WriteLine("counrty = {0}", country);
        }
    }




}
