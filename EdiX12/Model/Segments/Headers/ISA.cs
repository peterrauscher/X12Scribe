using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Attributes;

namespace X12Scribe.Model.Segments.Headers
{
    public class ISA : Segment
    {
        public ICN ICN
        {
            get { return ICN; }
            set
            {
                ICN = value;
                this[13] = value;
            }
        }

        public ISA(string ICN) : base("ISA") {
            this.ICN = ICN;
        }

        public string ToString(X12Options options)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
