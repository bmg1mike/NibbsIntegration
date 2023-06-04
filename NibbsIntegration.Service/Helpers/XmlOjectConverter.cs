namespace NibbsIntegration.Service;

public class XmlOjectConverter
{
    public static string ObjectToXML(object obj)
    {
        using (var stringwriter = new Utf8StringWriter())
        {
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(stringwriter, obj);
            return stringwriter.ToString();
        };

    }

    public static T? XmlToObject<T>(string input) where T : class
    {
        var serializer = new XmlSerializer(typeof(T));

        using (StringReader sr = new StringReader(input))
        {
            return (T?)serializer.Deserialize(sr);
        };

    }


}

public class Utf8StringWriter : StringWriter
{
    public override Encoding Encoding => Encoding.UTF8;
}