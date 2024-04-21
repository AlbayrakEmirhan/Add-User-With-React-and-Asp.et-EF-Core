namespace Contacts.Api;

public class Person
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public string? SurName { get; set; }
    public string? mail { get; set; }
    public string? Number { get; set; }

}
