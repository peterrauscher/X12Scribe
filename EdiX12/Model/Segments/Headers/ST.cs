using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Annotations;
using X12Scribe.Attributes;

namespace X12Scribe.Model.Segments.Headers
{
    // For reference: https://www.stedi.com/edi/x12-004010/segment/ST
    public class ST : Segment
    {
        [Pos(1)]
        [ElementProperties(id: "143", name: "Transaction Set Identifier Code", required: true, minLength: 3, maxLength: 3)]
        string TransactionSetIdentifierCode { get; set;}
        [Pos(2)]
        [ElementProperties(id: "329", name: "Transaction Set Control Number", required: true, minLength: 4, maxLength: 9)]
        string TransactionSetControlNumber {get; set;}

        public ST(string controlNumber, string transactionID) : base("ST")
        {
            TransactionSetControlNumber = controlNumber;
            TransactionSetIdentifierCode = transactionID;
        }

        override public string ToString(X12Options options)
        {
            StringBuilder sb = new StringBuilder("ST");
            sb.Append(options.FieldDelimiter);
            sb.Append(TransactionSetIdentifierCode);
            sb.Append(options.FieldDelimiter);
            sb.Append(TransactionSetControlNumber);
            return sb.ToString();
        }
    }
}
