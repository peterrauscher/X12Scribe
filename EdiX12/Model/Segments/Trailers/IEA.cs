using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model.Segments.Trailers
{
    public class IEA : Segment
    {
        public string ICN { get; set; }
        public int FunctionalGroupsCount { get; set; }

        public IEA(string ICN, int functionalGroupsCount, X12Options? options = null) : base (options)
        {
            this.ICN = ICN;
            FunctionalGroupsCount = functionalGroupsCount;
        }
    }
}
