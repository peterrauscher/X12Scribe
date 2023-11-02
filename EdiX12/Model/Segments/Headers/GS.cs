using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model.Segments.Headers
{
    public class GS
    {
        string FunctionalIdentifierCode;
        string ApplicationSendersCode;
        string ApplicationReceiversCode;
        string Date;
        string Time;
        string GroupControlNumber;
        string ResponsibleAgencyCode;
        string VersionReleaseIndustryIdentifierCode;

        public GS(string functionalIdentifier) {
            FunctionalIdentifierCode = functionalIdentifier;
            ApplicationSendersCode = 
            ApplicationReceiversCode = 
            Date = 
            Time = 
            GroupControlNumber = 
            ResponsibleAgencyCode = 
            VersionReleaseIndustryIdentifierCode = 
        }
    }
}
