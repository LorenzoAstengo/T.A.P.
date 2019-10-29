using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Executer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dll = Assembly.LoadFrom("MyLibrary.dll");
            foreach (var type in dll.GetTypes())
            {
                if(type.IsClass)
                    Console.WriteLine(type.FullName);
                Console.ReadLine();
            }
        }
    }
}
