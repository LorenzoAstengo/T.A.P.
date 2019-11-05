using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TinyDependencyInjectionContainer
{
    public class InterfaceResolver
    {
        private InterfaceResolver(){}
        public InterfaceResolver CreateResolver(string file)
        { 
            try
            {
                var tLines = File.ReadAllLines(file);
                var i = 0;
                while (tLines[i][0] == '#')
                    i++;
                var line=tLines[i].Split('*');
                if (line.Length != 4 /*|| !ControlLines(line)*/)
                    return null;
                return new InterfaceResolver();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /*bool ControlLines(string[] line)
        {
            var regex0= new Regex(@".*\.dll?$");
            var regex1 = new Regex();
            var regex2 = new Regex();
            var regex3 = new Regex();
            Regex[] regices = {regex0, regex1, regex2, regex3};
        }*/

        T Instantiate<T>() where T : class
        {
            
        }
    }
}
