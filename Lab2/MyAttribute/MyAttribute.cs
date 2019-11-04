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
        public object[] Arguments { get; private set; }

        public ExecuteMe(params object[] objects)
        {
            this.Arguments = objects;
        }
    }
}
