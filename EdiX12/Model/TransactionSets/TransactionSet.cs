using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Model.Segments;
using X12Scribe.Model.Segments.Headers;
using X12Scribe.Model.Segments.Trailers;

namespace X12Scribe.Model.TransactionSets
{
    public class TransactionSet : IX12Object<Segment>
    {
        public string Code { get; set; }
        public ICN TransactionSetControlNumber { get; set; }
        public ST ST { get; set; }
        public SE SE { get; set; }

        public TransactionSet(ICN transactionSetControlNumber, string code)
        {
            Code = code;
            ST = new ST(transactionSetControlNumber, code);
            SE = new SE(transactionSetControlNumber, code);
            TransactionSetControlNumber = transactionSetControlNumber;
        }

        public virtual string ToString(X12Options options) {
            StringBuilder sb = new StringBuilder();
            sb.Append(ST.ToString(options));
            foreach (Segment segment in Children)
            {
                sb.Append(options.RecordDelimiter);
                sb.Append(segment.ToString(options));
            }
            sb.Append(options.RecordDelimiter);
            sb.Append(SE.ToString());
            sb.Append(options.RecordDelimiter);
            return sb.ToString();
        }

        override public void Validate(X12Options options)
        {
            this.ST.Validate(options);
            if(this.Children != null)
                foreach(Segment segment in Children)
                    segment.Validate(options);
            this.SE.Validate(options);
        }
    }
}
