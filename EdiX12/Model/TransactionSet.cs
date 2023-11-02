using EdiX12.Model.Segments.Headers;
using EdiX12.Model.Segments.Trailers ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model
{
    public abstract class TransactionSet
    {
        public GS Header { get; set; }
        public GE Trailer { get; set; }
    }
}
