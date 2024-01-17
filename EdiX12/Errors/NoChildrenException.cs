using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Errors
{
    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException() { }

        public InvalidCharacterException(string message) : base(message) { }
    }
}
