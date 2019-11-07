using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TinyDependencyInjectionContainer
{
    public class InterfaceResolver
    {
        private readonly string dllFile, interfaceName, interfaceImpl, className;
        public InterfaceResolver(string file)
        { 
            try
            {
                var tLines = File.ReadAllLines(file);
                var i = 0;
                while (tLines[i][0] == '#'|| tLines[i][0] =='\n')
                    i++;
                var line=tLines[i].Split('*');
                if (line.Length != 4 /*|| !ControlLines(line)*/)
                {

                }
                else
                {
                    this.dllFile = line[0];
                    this.interfaceName = line[1];
                    this.interfaceImpl = line[2];
                    this.className = line[3];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*bool ControlLines(string[] line)
        {
            var regex0= new Regex(@".*\.dll?$");
            var regex1 = new Regex();
            var regex2 = new Regex();
            var regex3 = new Regex();
            Regex[] regices = {regex0, regex1, regex2, regex3};
        }*/

        public T Instantiate<T>() where T : class
        {
            var a=Assembly.LoadFrom(dllFile);
            foreach (var t in a.GetTypes())
            {
                var interfaces = t.GetInterfaces();
                if (interfaces.ToString().Contains(interfaceName))
                {
                    if (typeof(T).Assembly.Equals(a))
                    {
                        var implAssembly = Assembly.LoadFrom(interfaceImpl);
                        foreach (var t1 in implAssembly.GetTypes())
                        {
                            if (t1.IsClass && t1.FullName==className)
                            {
                                var act= Activator.CreateInstance(t1);
                                return (T)act;
                            }
                            
                        }
                    }
                }
            }
            return null;
        }
    }
}
