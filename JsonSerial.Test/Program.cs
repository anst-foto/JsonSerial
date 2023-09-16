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

var json2 = System.Text.Json.JsonSerializer.Serialize(person);
Console.WriteLine(json2);

var person2 = System.Text.Json.JsonSerializer.Deserialize<Person>(json2);
Console.WriteLine($"{person2.FullName}, {person2.Age}");