using System.Linq;
using OOT2.Books;
using OOT2.Calculation;

namespace OOT2.PromoCodes
{
    public class FreeBookPromoCode : IPromoCode
    {
        private readonly IBook _book;

        public FreeBookPromoCode(IBook book)
        {
            _book = book;
        }

        public void Apply(OrderInfo orderInfo)
        {
            var orderItem = orderInfo.Items
                .Where(oi => !oi.IsPromoApplied)
                .FirstOrDefault(oi => oi.Book.Name == _book.Name && oi.Book.Author == _book.Author
                && oi.Book.Year == _book.Year && oi.Book.Type == _book.Type);
            if (orderItem == null)
                return;

            orderItem.IsPromoApplied = true;
            orderItem.Discount = orderItem.FinalPrice;
        }
    }
}