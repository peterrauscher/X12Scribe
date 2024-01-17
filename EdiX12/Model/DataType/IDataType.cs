using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model.DataType
{
    public abstract class IDataType
    {
        public virtual bool validate();
    }
}
