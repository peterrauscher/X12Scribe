using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model.Segments
{
    internal class SegmentProperties
    {
        public string ID;
        public string? Name;
        public List<Dictionary<string, string>> SegmentFields;
    }
}
