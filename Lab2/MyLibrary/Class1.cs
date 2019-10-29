using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttribute;

namespace MyLibrary
{
    public class Class1
    {
        [ExecuteMe("Prova1", "Fine")]
        public void M1(string s1, string s2)
        {
            Console.WriteLine("M1 {0}, {1}", s1, s2);

        }
    }
}
