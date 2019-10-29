using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ExecuteMe : Attribute
    {
        private readonly string[] _strings;
        private readonly int[] _ints;

        public ExecuteMe(params string[] strings)
        {
            this._strings = strings;
        }

        public ExecuteMe(params int[] ints)
        {
            this._ints = ints;
        }
        public string[] GetStrings()
        {
            return _strings;
        }

        public int[] GetInts()
        {
            return _ints;
        }
    }
}
