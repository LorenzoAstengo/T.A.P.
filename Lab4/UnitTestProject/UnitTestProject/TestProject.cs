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

            List<T> resList = new List<T>();
            foreach (var elem in seqList)
            {
                if (elem.Equals(val))
                    resList.AddRange(newValuesList);
                else
                    resList.Add(elem);
            }
            return resList;
        }

        public static void Main()
        {

        }
    }
}
