using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    public class TestProject
    {
        public static List<T> MacroExpansion<T>(List<T> seqList, T val, List<T> newValuesList)
        {
            if(seqList==null || newValuesList==null)
                throw new ArgumentNullException();
            return newValuesList;
        }

        public static void Main()
        {

        }
    }
}
