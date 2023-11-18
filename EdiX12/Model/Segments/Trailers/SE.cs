using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using X12Scribe.Annotations;
using X12Scribe.Attributes;
using X12Scribe.Model;

namespace X12Scribe.Model.Segments.Trailers
{
    public class SE : Segment
    {
        [Pos(1)]
        [ElementProperties(id: "96", name: "Number of Included Segments", required: true, minLength: 1, maxLength: 10)]
        public string NumberOfSegments { get; set; }
        [Pos(2)]
        [ElementProperties(id: "329", name: "Transaction Set Control Number", required: true, minLength: 4, maxLength: 9)]
        public string TransactionSetControlNumber { get; set; }

        public SE(string controlNumber, string transactionID, X12Options? options = null) : base(options)
        {

        }
    }
}
