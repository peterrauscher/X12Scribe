using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model
{
    public class ICN
    {
        readonly string _value;
        public ICN(string icn)
        {
            this._value = icn.PadLeft(9, '0').Substring(0, 9);
        }

        public static implicit operator string(ICN icn)
        {
            return icn._value;
        }

        public static implicit operator ICN(string icn)
        {
            return new ICN(icn);
        }

        public static implicit operator ICN(int icn)
        {
            return new ICN(icn.ToString());
        }
    }

}
