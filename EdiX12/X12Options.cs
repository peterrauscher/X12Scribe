using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe
{
    public class X12Options
    {
        public string RecordDelimiter { get; set; } = "~";
        public string FieldDelimiter { get; set; } = "*";
        public string SubfieldDelimiter { get; set; } = ">";
        public string AuthorizationInformationQualifier { get; set; } = "00";
        public string AuthorizationInformation { get; set; } = " ".PadRight(10);
        public string SecurityInformationQualifier { get; set; } = "00";
        public string SecurityInformation { get; set; } = " ".PadRight(10);
        public string SenderIdQualifier { get; set; } = "ZZ";
        public string SenderId { get; set; } = "SENDERID".PadLeft(15, '0');
        public string ReceiverIdQualifier { get; set; } = "ZZ";
        public string ReceiverId { get; set; } = "RECEIVERID".PadLeft(15, '0');
        public string InterchangeControlStandard { get; } = "U";
        public string InterchangeControlVersion { get; } = "00401";
        public string UsageIndicator { get; set; } = System.Diagnostics.Debugger.IsAttached ? "T" : "P";
        public bool RequestAcknowledgement { get; set; } = true;
    }
}
