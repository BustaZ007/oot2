namespace OOT2.Books
{
    public class EBook : IBook
    {
        public EBook(string name, BookType type, string author, decimal price, int year, EBookFormat format)
        {
            Name = name;
            Type = type;
            Author = author;
            Price = price;
            Year = year;
            Format = format;
        }

        public string Name { get; set; }
        public BookType Type { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public  EBookFormat Format { get; }
    }
}