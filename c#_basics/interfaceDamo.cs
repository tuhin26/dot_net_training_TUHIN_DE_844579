using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] { 90, 97, 98, 90, 95, 87 };

            result objr = new result();
            var avg = objr.getavgmarks(marks);
            objr.displayavg(avg);
            objr.showgrade(avg);
            Console.ReadKey();
        }
    }
    public interface iexam
    {
        double getavgmarks(int[] marks);
        void displayavg(double avg);

    }
    public interface istudent
    {
        void showgrade(double avg);

    }

    public class result : iexam, istudent
    {
        public void displayavg(double avg)
        {
            Console.WriteLine("the avg marks ={0}", avg);
        }

        public double getavgmarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for(int i=0;i<marks.Length;i++)
            {
                total = total + marks[i];
                
            }
            avg = total / marks.Length;
            return avg;

        }

        public void showgrade(double avg)
        {
            if(avg>=70)
            {
                Console.WriteLine("distinction");
            }
            else
            {
                Console.WriteLine("pass");
            }
        }
    }
}
