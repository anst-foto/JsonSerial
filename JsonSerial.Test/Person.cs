using System.Text.Json.Serialization;
using JsonSerial.Core;

namespace JsonSerial.Test;

public class Person
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }
    
    [Ignore]
    [JsonIgnore]
    public string FullName => $"{LastName} {FirstName}";
}