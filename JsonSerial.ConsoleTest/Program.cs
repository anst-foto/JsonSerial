using JsonSerial.ConsoleTest;

var person = new Person
{
    FirstName = "Andrey",
    LastName = "Starinin",
    DateOfBirth = new DateTime(1986, 2, 18)
};

var result = JsonSerial.Core.JsonSerializer.Serialize(person);
Console.WriteLine(result);

File.WriteAllText(path: "person.json", result);