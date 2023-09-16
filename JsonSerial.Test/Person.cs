using JsonSerial.Core;

namespace JsonSerial.Test;

public class Person
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }
    
    [Ignore]
    public string FullName => $"{LastName} {FirstName}";
}