using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ElementPropertiesAttribute : Attribute
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public ElementPropertiesAttribute(string id, string name, bool required, int minLength, int maxLength) {
            ID = id;
            Name = name;
            Required = required;
            MinLength = minLength;
            MaxLength = maxLength;
        }
    }
}