using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityframeworkdbfirst
{
    class Program
    {

       
        static void Main(string[] args)
        {
            employeeEFDBEntities context = new employeeEFDBEntities();

            //var employee = new employee()
            //{
            //    empid = 1,
            //    name = "tuhin",
            //    salary = 21700,
            //    ssn = 23456,
            //    deptid = 14
            //};
            //context.employees.Add(employee);
            //var employee1 = new employee()
            //{
            //    empid = 2,
            //    name = "mohan",
            //    salary = 21700,
            //    ssn = 23496,
            //    deptid = 14
            //};
            //context.employees.Add(employee1);

            //    var employee2 = new employee()
            //    {
            //        empid = 3,
            //        name = "vimal",
            //        salary = 21700,
            //        ssn = 23490,
            //        deptid = 1
            //    };
            //    context.employees.Add(employee2);
            //    context.SaveChanges();

            linqtoentity();
            modify();
            delete();
        }

        public static void linqtoentity()
        {
            employeeEFDBEntities context = new employeeEFDBEntities();

            var employees = context.employees;

            var emplist = from emp in employees
                          orderby emp.empid
                          select emp;
            foreach(var emp in emplist)
            {
                Console.WriteLine("empid {0} name {1}  salary {2}  ssn {3} ", emp.empid, emp.name, emp.name, emp.ssn);
            }
        }

        public static void modify()
        {
            employeeEFDBEntities context = new employeeEFDBEntities();

            var employees = context.employees;

            var emplist = from emp in employees
                          orderby emp.empid
                          select emp;
            foreach (var emp in emplist)
            {
                if(emp.empid==2)
                {
                    emp.name = "anup";
                }
            }
            context.SaveChanges();
        }
        public static void delete()
        {
            employeeEFDBEntities context = new employeeEFDBEntities();

            var employees = context.employees;

            var employee = new employee { empid = 4 };
            employees.Attach(employee);
            employees.Remove(employee);
            context.SaveChanges();
            
        }
    }
}
