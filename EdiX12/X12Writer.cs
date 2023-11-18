using X12Scribe;
using X12Scribe.Model;
using X12Scribe.Model.Segments.Headers;
using X12Scribe.Model.Segments.Trailers;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;

public class X12Writer
{
    public X12Options Options { get; set; }

    public X12Writer(X12Options options)
    {
        Options = options;
    }

    public void Write(IX12Object x12Object, Stream stream)
    {
        using (StreamWriter writer = new StreamWriter(stream))
        {
            writer.Write(x12Object.ToString());
        }
    }

    public void Write(IX12Object x12Object, string filePath) => File.WriteAllText(new FileInfo(filePath).FullName, ToString());

    public string ToString(IX12Object x12Object) { return x12Object.ToString(); }
}
