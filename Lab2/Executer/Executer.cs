using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MyAttribute;
using MyLibrary;

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
                    foreach (var method in type.GetMethods())
                    {
                        object[] customAtt = method.GetCustomAttributes(typeof(ExecuteMe), false);
                        if (customAtt.Any())
                        {
                            foreach (ExecuteMe cA in customAtt)                         //Non sono sicuro sia corretto il cast a ExecuteMe
                            {
                                object istance;
                                istance = Activator.CreateInstance(type);
                                method.Invoke(istance, cA.GetStrings());      //Così controlla e stampa solo gli attributi stringa
                            }
                            
                        }

                        
                    }
                }
                    
            }

            

            
        }
    }
}
