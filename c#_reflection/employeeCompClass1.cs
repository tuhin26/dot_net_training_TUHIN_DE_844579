using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeComp
{
    public class employee
    {
        public int empid { get; set; }

        public string empname { get; set; }

        public string deptname { get; set; }

        public double getsalary(int nds,double spd)
        {

            var salary = nds * spd;
            return salary;
        }
        public double incentive(double salary)
        {
            var incent = 0.05 * salary;
            return incent;
        }

        public string showdata()
        {
            return string.Format("empid = {0} empname = {1} deptname = {2}", empid, empname, deptname);
        }
    }
}
