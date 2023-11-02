using EdiX12.Model.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiX12.Model
{
    public abstract class Segment
    {
        public List<SegmentValidationError> Validate(ValidationSettings settings = null);
    }
}
