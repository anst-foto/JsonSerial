using JsonSerial.Core;
using JsonSerial.Test;

var person = new Person()
{
    LastName = "Starinin",
    FirstName = "Andrey",
    Age = 37
};

var json = JsonSerializer.Serialize(person);
Console.WriteLine(json);