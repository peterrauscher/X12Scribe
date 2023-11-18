using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12Scribe.Attributes;
using X12Scribe.Model.Elements;

namespace X12Scribe.Model.Segments
{
    public class Segment : IX12Object<Element>
    {
        public string ID;
        public string? Name;

        public Segment(string id)
        {
            Children = new List<Element>();
            SegmentProperties properties = SegmentPropertiesProvider.GetSegmentProperties(id);
            ID = properties.ID;
            Name = properties.Name;
            foreach (Dictionary<string, string> segmentField in properties.SegmentFields)
            {
                // TODO: Support Composites
                //if (segmentField.ContainsKey("Composite"))
                //    Add(new CompositeElement(segmentField["ID"]));
                //else
                Add(new Element(segmentField["ID"], int.Parse(segmentField["Position"]), segmentField["Required"] == "M"));
            }
        }

        public Element this[int pos]
        {
            get => Children[pos - 1];
            set => Children[pos - 1] = value;
        }

        public int Count => Children.Count;
        public void Add(Element item) => Children.Add(item);
        public void RemoveAt(int position) => Children.RemoveAt(position - 1);
        // TODO: Remove by Element ID
        //public void Remove(string id) => 

        public virtual string ToString(X12Options options)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ID);
            foreach (Element segmentElement in Children)
            {
                sb.Append(options.FieldDelimiter);
                sb.Append(segmentElement.ToString());
            }
            return sb.ToString();
        }
    }
}
