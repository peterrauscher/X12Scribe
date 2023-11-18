using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X12Scribe.Model.Elements
{
    public class Element : IX12Object
    {
        readonly string _value;
        public string ID { get; set; }
        public string? Name { get; set; }
        public string? DataType { get; set; }
        public int? MinLength { get; set; }
        public int? MaxLength { get; set; }
        public int? Position { get; set; }
        public bool? Required { get; set; }

        public IList<Dictionary<string, string>>? Codes { get; set; }

        public Element(string id, int position = 1, bool required = false, string value = "")
        {
            Element properties = ElementPropertiesProvider.GetElement(id);

            ID = properties.ID;
            Name = properties.Name;
            DataType = properties.DataType;
            MinLength = properties.MinLength;
            MaxLength = properties.MaxLength;
            Codes = properties.Codes;
            Position = position;
            Required = required;

            _value = value;
        }

        public static implicit operator string(Element element)
        {
            return element._value;
        }

        public static implicit operator Element(string value)
        {
            return new Element(value);
        }

        override public string ToString()
        {
            return _value;
        }
    }
}
