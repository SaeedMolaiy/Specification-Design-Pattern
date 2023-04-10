namespace SpecificationDesignPattern.Models;

public class Author
{
    public Author(string fullName)
    {
        FullName = fullName;
    }

    public string FullName { get; set; }
}
