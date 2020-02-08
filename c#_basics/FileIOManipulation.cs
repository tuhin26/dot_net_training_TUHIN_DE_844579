using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\sample directory");
            //dir.Create();

            //FileInfo file = new FileInfo("c:\\sample directory\\sample.txt");
            //file.Create();

            //Console.WriteLine("the directory and the text has been created successfully");

            //FileStream fs = new FileStream("c:\\sample directory\\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);

            // StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine("this text has been written to the file using file i/o manipulation");

            //sw.Close();
            //fs.Close();


            FileStream fs = new FileStream("c:\\sample directory\\sample.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sa = new StreamWriter(fs);

            sa.WriteLine("this text has been written again to the file using file i/o manipulation");

            sa.Close();
            fs.Close();

            Console.WriteLine("some msg written in the file");

            fs = new FileStream("c:\\sample directory\\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            //var content = sr.ReadToEnd();
           // Console.WriteLine("the file content : {0}", content);

            string linebyline;
            while((linebyline =sr.ReadLine())!=null)
            {
                Console.WriteLine("\n the file content : {0}", linebyline);
            }

            sr.Close();
            fs.Close();


          



            Console.ReadKey();
        }
    }
}
