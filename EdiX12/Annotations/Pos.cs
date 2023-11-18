using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Annotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PosAttribute : Attribute
    {
        public PosAttribute(int position)
        {
            Pos = position;
        }

        public int Pos { get; set; }
    }
}
