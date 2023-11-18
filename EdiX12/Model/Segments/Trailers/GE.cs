using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model.Segments.Trailers
{
    public class GE
    {
        public int TransactionCount { get; set; }
        public int GroupControlNumber { get; set; }
    }
}
