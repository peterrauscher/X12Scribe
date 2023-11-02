using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model.Segments.Headers
{
    // For reference: https://www.stedi.com/edi/x12-004010/segment/ST
    public class ST
    {
        // ST01 Transaction Set Identifier Code (Mandatory)
        string IdentifierCode {get; set;}
        // ST02 Transaction Set Control Number (Mandatory)
        string ControlNumber {get; set;}

        public ST(string ICN, string transactionType)
        {
            this.ControlNumber = ICN;
            this.IdentifierCode = transactionType;
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder("ST");
            sb.Append(IdentifierCode);
            sb.Append(ControlNumber);
            return sb.ToString();
        }
    }
}
