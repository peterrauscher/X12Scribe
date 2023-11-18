using X12Scribe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model
{
    public abstract class IX12Object<TChild>
    {
        public virtual IList<TChild>? Children { get; set; }
    }

    public abstract class IX12Object : IX12Object<string> { }
}
