using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflectedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("productcomp");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("base type : {0}", type.BaseType);
                Console.WriteLine("name : {0}", type.Name);

                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("method name : {0}", method.Name);
                    Console.WriteLine("return type : {0}", method.ReturnType);

                    ParameterInfo[] parameters = method.GetParameters();

                    foreach (ParameterInfo parameter in parameters)
                    {
                        Console.WriteLine("parameter name : {0}", parameter.Name);
                        Console.WriteLine("paremeter type : {0}", parameter.ParameterType);
                        Console.WriteLine("_________________________________________________");
                    }
                    Console.WriteLine("_________________________________________________");
                }
                Console.WriteLine("_________________________________________________");

            }
        }
    }
}

