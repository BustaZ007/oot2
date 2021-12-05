using System;
using System.Collections.Generic;
using System.Linq;
using OOT2.Books;
using OOT2.Calculation;

namespace OOT2.Promo
{
    public class FreeEBookPromo : IPromo
    {
        private readonly List<IBook> _books;

        public FreeEBookPromo(List<IBook> books)
        {
            _books = books;
        }

        public void Apply(OrderInfo orderInfo)
        {
            var oneAuthorBooks = orderInfo.Items
                .Where(oi => !oi.IsPromoApplied)
                .Where(oi => oi.Book.GetType() == typeof(PaperBook))
                .GroupBy(oi => oi.Book.Author)
                .Select(g => new
                {
                    author = g.Key,
                    count = g.Count(),
                    items = new List<OrderItem>(g)
                })
                .FirstOrDefault(g => g.count == 2);

            if (oneAuthorBooks?.author is null)
                return;

            oneAuthorBooks.items
                .ForEach(oi => oi.IsPromoApplied = true);

            var promoBook = _books
                .FirstOrDefault(b => b.Type == BookType.ElectronicBook && b.Author == oneAuthorBooks.author);
            if (promoBook is null)
                return;
            
            orderInfo.Items.Add(new OrderItem()
            {
                Book = promoBook,
                Discount = promoBook.Price,
                IsPromoApplied = true
            });
        }
    }
}