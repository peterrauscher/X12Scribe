using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Annotations;
using X12Scribe.Attributes;

namespace X12Scribe.Model.Segments.Headers
{
    public class GS : Segment
    {
        [Pos(1)]
        [ElementProperties("479")]
        public string FunctionalIdentifierCode {  get; set; }
        [Pos(2)]
        [ElementProperties("142")]
        public string ApplicationSendersCode { get; set; }
        [Pos(3)]
        [ElementProperties("124")]
        public string ApplicationReceiversCode { get; set; }
        [Pos(4)]
        [ElementProperties("373")]
        public string Date { get; set; }
        [Pos(5)]
        [ElementProperties("337")]
        public string Time { get; set; }
        [Pos(6)]
        [ElementProperties("28")]
        public int GroupControlNumber { get; set; }
        [Pos(7)]
        [ElementProperties("455")]
        public string ResponsibleAgencyCode { get; set; }
        [Pos(8)]
        [ElementProperties("480")]
        public string VersionReleaseIndustryIdentifierCode { get; set; }

        public GS(string functionalIdentifierCode, string groupControlNumber) : base("GS") {
            FunctionalIdentifierCode = functionalIdentifierCode;
            ApplicationSendersCode = _options.SenderId;
            ApplicationReceiversCode = _options.ReceiverId;
            Date = DateTime.Now.ToString("yyyyMMdd");
            Time = DateTime.Now.ToString("HHmmss");
            GroupControlNumber = groupControlNumber;
            ResponsibleAgencyCode = 
            VersionReleaseIndustryIdentifierCode = 
        }
    }
}
