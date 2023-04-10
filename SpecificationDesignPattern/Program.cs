using SpecificationDesignPattern.Models;

var dateTime = DateTime.Now;
var author = new Author("Saeed Molaiy");

var book = new Book("c# 11",author,dateTime);

Console.WriteLine(book.IsSatisfiedBy(dateTime));
Console.WriteLine(book.IsSatisfiedBy(author));

Console.ReadKey();