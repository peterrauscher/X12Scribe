using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model.Segments.Headers
{
    public class ISA : Segment
    {
        private string _recordDelimiter;
        private string _fieldDelimiter;
        private string _subfieldDelimiter;
        // TODO: Add authorization & security information support
        // ISA01 Authorization Information Qualifier
        string AuthorizationInformationQualifier { get; set; }
        string AuthorizationInformation { get; set; }
        string SecurityInformationQualifier { get; set; }
        string SecurityInformation { get; set; }
        // ISA05 Interchange ID Qualifier (Sender)
        string SenderIdQualifier { get; set; }
        // ISA06 Interchange ID (Sender)
        string SenderId { get; set; }
        // ISA07 Interchange ID Qualifier (Receiver)
        string ReceiverIdQualifier { get; set; }
        // ISA08 Interchange ID (Receiver)
        string ReceiverId { get; set; }
        // ISA09 Interchange Date in format YYYYMMDD
        string InterchangeDate { get; set; }
        // ISA10 Interchange Item in format HHMM
        string InterchangeTime { get; set; }
        // ISA11 Interchange Control Standards Identifier
        string InterchangeControlStandardsID { get; set; }
        // ISA12 Interchange Control Version Number
        string InterchangeControlVersion { get; set; }
        // ISA13 Interchange Control Number
        string ICN { get; set; }
        // ISA14 Acknowledgement Requested?
        string AcknowledgementRequested { get; set; }
        // ISA15 Usage Indicator (testing or production)
        string UsageIndicator { get; set; }
        // ISA16 Component Element Separator
        string ComponentElementSeparator { get; set; }

        public ISA(string ICN, X12Options options) {
            this.ICN = ICN.PadLeft(9, '0').Substring(0, 9);
            InitializeISA(options);
        }

        public ISA(int ICN, X12Options options)
        {
            this.ICN = ICN.ToString().PadLeft(9, '0').Substring(0, 9);
            InitializeISA(options);
        }

        private void InitializeISA(X12Options options)
        {
            AuthorizationInformationQualifier = "00";
            AuthorizationInformation = " ".PadRight(10);
            SecurityInformationQualifier = "00";
            SecurityInformation = " ".PadRight(10);
            SenderIdQualifier = options.SenderIdQualifier;
            SenderId = options.SenderId.PadRight(15).Substring(0, 15);
            ReceiverIdQualifier = options.ReceiverIdQualifier;
            ReceiverId = options.ReceiverId.PadRight(15).Substring(0, 15);
            InterchangeDate = DateTime.Now.ToString("yyyyMMdd");
            InterchangeTime = DateTime.Now.ToString("HHmm");
            InterchangeControlStandardsID = options.InterchangeControlStandardsID; // Default for X12 standard
            InterchangeControlVersion = options.InterchangeControlVersion;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
    }
}
