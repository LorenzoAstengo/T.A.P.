using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttribute;

namespace MyLibrary
{
    public class MyLibrary
    {
        
        [ExecuteMe]
        public void M1()
        {
            Console.WriteLine("M1");

        }

        [ExecuteMe("Prova1", " Prova1 fine")]
        [ExecuteMe("Prova2", "Prova2 fine")]
        public void M1(string s1, string s2)
        {
            Console.WriteLine("M1 {0}, {1}", s1, s2);

        }
    }
}
