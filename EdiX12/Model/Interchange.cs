using EdiX12.Model.Segments.Headers;
using EdiX12.Model.Segments.Trailers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model
{
    public class Interchange
    {
        private ISA _interchangeControlHeader;
        private List<FunctionalGroup> functionalGroups;
        private IEA _interchangeControlTrailer;

        public Interchange(X12Options options = null)
        {
            if (options is null) Options = new X12Options();
            else Options = options;
        }

        public string ToString()
        {
            StringBuilder ToStringBuilder = new StringBuilder();
            ToStringBuilder.Append(ISA.ToString());
            foreach (FunctionalGroup fg in _functionalGroups)
                ToStringBuilder.Append(fg.ToString());
            ToStringBuilder.Append(IEA.ToString());
            return ToStringBuilder.ToString();
        }
    }
}
