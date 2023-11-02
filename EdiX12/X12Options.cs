using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12
{
    public class X12Options
    {
        public string RecordDelimiter { get; set; } = "~";
        public string FieldDelimiter { get; set; } = "*";
        public string SubfieldDelimiter { get; set; } = ">";
        public string SenderIdQualifier { get; set; } = "ZZ";
        public string SenderId { get; set; } = "SENDERID".PadLeft(15, '0');
        public string ReceiverIdQualifier { get; set; } = "ZZ";
        public string ReceiverId { get; set; } = "RECEIVERID".PadLeft(15, '0');
        public string InterchangeControlStandardsID { get; set; } = "U";
        public string InterchangeControlVersion { get; set; } = "00401";
        public string UsageIndicator { get; set; } = System.Diagnostics.Debugger.IsAttached ? "T" : "P";
    }
}
