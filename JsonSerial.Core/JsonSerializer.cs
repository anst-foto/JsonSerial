using System.Reflection;
using System.Text;

namespace JsonSerial.Core;

public static class JsonSerializer
{
    public static string Serialize(object obj)
    {
        var type = obj.GetType();

        var stringBuilder = new StringBuilder();
        stringBuilder.Append("{");
        foreach (var property in type.GetProperties())
        {
            if (property.GetCustomAttribute(typeof(IgnoreAttribute)) is IgnoreAttribute { Ignore: true })
            {
                continue;
            }

            stringBuilder.Append("\"");
            stringBuilder.Append(property.Name);
            stringBuilder.Append("\": \"");
            stringBuilder.Append(property.GetValue(obj));
            stringBuilder.Append("\", ");
        }

        stringBuilder.Append("}");

        return stringBuilder.ToString();
    }
}