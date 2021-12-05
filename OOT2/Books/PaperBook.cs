namespace OOT2.Books
{
    public class PaperBook : IBook
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

        public PaperBook(string name, BookType type, string author, decimal price, int year)
        {
            Name = name;
            Type = type;
            Author = author;
            Price = price;
            Year = year;
        }
    }
}