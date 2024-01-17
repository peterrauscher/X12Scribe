using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Errors
{
    public class NoChildrenException : Exception
    {
        public NoChildrenException() { }

        public NoChildrenException(string message) : base(message) { }
    }
}
