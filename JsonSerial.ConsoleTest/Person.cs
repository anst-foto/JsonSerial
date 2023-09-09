namespace JsonSerial.ConsoleTest;

public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string FullName => $"{LastName} {FirstName}";

    public DateTime DateOfBirth { get; set; }
}