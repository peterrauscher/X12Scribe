using EdiX12;
using EdiX12.Model;
using EdiX12.Model.Segments.Headers;
using EdiX12.Model.Segments.Trailers;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Text;

public class X12Writer
{
    public static X12Options Options { get; set; }
	public Interchange Interchange { get; set; }

	public X12Writer()
	{

	}

    public void Write(Stream stream)
    {
        using (StreamWriter writer = new StreamWriter(stream))
        {
            writer.Write(Interchange.ToString());
        }
    }

	public void Write(string filename)
	{
        if (filename is null || filename.Trim().Length == 0)
			throw new ArgumentNullException("You must provide a valid file path to write to.");
        FileInfo file = new FileInfo(filename);
        File.WriteAllText(file.FullName, Interchange.ToString());
    }

    public List<Interchange> Get

	public void WriteToFile() => File.WriteAllText(_interchangeControlFile.FullName, ToString());
}
