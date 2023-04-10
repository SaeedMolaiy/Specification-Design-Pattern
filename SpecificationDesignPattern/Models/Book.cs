using SpecificationDesignPattern.Infrastructure;

namespace SpecificationDesignPattern.Models;

public class Book : ISpecification<DateTime>, ISpecification<Author>
{
    public Book(string name, Author author, DateTime releaseDate)
    {
        Name = name;
        Author = author;
        ReleaseDate = releaseDate;
    }

    public string Name { get; set; }

    public DateTime ReleaseDate { get; set; }

    public Author Author { get; set; }

    /// <inheritdoc />
    public bool IsSatisfiedBy(Author candidate)
    {
        return Author.FullName == candidate.FullName;
    }

    /// <inheritdoc />
    public bool IsSatisfiedBy(DateTime candidate)
    {
        return ReleaseDate == candidate;
    }

}