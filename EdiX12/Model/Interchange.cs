using X12Scribe.Model.Segments.Headers;
using X12Scribe.Model.Segments.Trailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Model.FunctionalGroups;

namespace X12Scribe.Model
{

    public class Interchange : IX12Object<FunctionalGroup>
    {
        X12Options options { get {
                return options;
            }
            set
            {
                options = value;
                ISA[1] = value.AuthorizationInformationQualifier;
                ISA[2] = value.AuthorizationInformation;
                ISA[3] = value.SecurityInformationQualifier;
                ISA[4] = value.SecurityInformation;
                ISA[5] = value.SenderIdQualifier;
                ISA[6] = value.SenderId;
                ISA[7] = value.ReceiverIdQualifier;
                ISA[8] = value.ReceiverId;
                ISA[9] = DateTime.Now.ToString("yyMMdd");
                ISA[10] = DateTime.Now.ToString("HHmm");
                ISA[11] = value.InterchangeControlStandard;
                ISA[12] = value.InterchangeControlVersion;
                ISA[14] = value.RequestAcknowledgement ? "1" : "0";
                ISA[15] = value.UsageIndicator;
                ISA[16] = value.SubfieldDelimiter;
            }
        }
        public ICN ICN;
        public int GroupCount;
        private ISA ISA;
        private IEA IEA;

        public Interchange(ICN ICN)
        {
            ISA = new ISA(ICN);
            IEA = new IEA(ICN, 0);
            this.ICN = ICN;
            GroupCount = 0;
            Children = new List<FunctionalGroup>();
        }

        public void Add(FunctionalGroup group)
        {
            Children.Add(group);
            GroupCount++;
        }

        public void RemoveAt(int index)
        {
            Children.RemoveAt(index);
            GroupCount--;
        }

        public string ToString(X12Options options)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ISA.ToString());
            sb.Append(options.RecordDelimiter);
            foreach (FunctionalGroup fg in Children)
                sb.Append(fg.ToString());
            sb.Append(IEA.ToString());
            sb.Append(options.RecordDelimiter);
            return sb.ToString();
        }
    }
}
