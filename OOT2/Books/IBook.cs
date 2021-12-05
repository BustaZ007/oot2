using System;

namespace OOT2.Books
{
    public interface IBook
    {
        string Name { get; set; }
        BookType Type { get; set; }
        string Author { get; set; }
        decimal Price { get; set; }
        int Year { get; set; }
    }
}