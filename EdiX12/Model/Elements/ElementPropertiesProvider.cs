using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace X12Scribe.Model.Elements
{
    static internal class ElementPropertiesProvider
    {
        static Dictionary<string, Element> ElementProperties = JsonConvert.DeserializeObject < Dictionary<string, Element>>(File.ReadAllText("Elements.json"));

        public static Element GetElement(string ID)
        {
            if (ElementProperties.ContainsKey(ID))
                return ElementProperties[ID];
            else
                throw new KeyNotFoundException("Not a valid X12 Element ID");
        }
    }
}
