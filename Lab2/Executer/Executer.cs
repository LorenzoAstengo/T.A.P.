using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyAttribute;      

namespace Executer
{
    class Executer
    {
        static void Main(string[] args)
        {
            var dll = Assembly.LoadFrom("MyLibrary.dll");
            
            foreach (var type in dll.GetTypes())
            {
                if (type.IsClass)
                {
                    Console.WriteLine(type.FullName);
                    try
                    {
                        var istance = Activator.CreateInstance(type);
                        foreach (var method in type.GetMethods())
                        {
                            foreach (var customAtt in method.GetCustomAttributes<ExecuteMe>())
                            {
                                method.Invoke(istance, customAtt.Arguments);
                            }

                        }
                    }
                    catch (MissingMethodException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
                    
            }

            

            
        }
    }
}
