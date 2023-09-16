namespace JsonSerial.Core;

public class IgnoreAttribute : Attribute
{
    public bool Ignore { get; set; } = true;
}