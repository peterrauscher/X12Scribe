using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Model.Elements;

namespace X12Scribe.Model.Segments
{
    static internal class SegmentPropertiesProvider
    {
            static Dictionary<string, SegmentProperties> SegmentPropertiesDictionary = JsonConvert.DeserializeObject<Dictionary<string, SegmentProperties>>(File.ReadAllText("Segments.json"));

            public static SegmentProperties GetSegmentProperties(string ID)
            {
                if (SegmentPropertiesDictionary.ContainsKey(ID))
                    return SegmentPropertiesDictionary[ID];
                else
                    throw new KeyNotFoundException("Not a valid X12 Segment ID");
            }
        }
}
