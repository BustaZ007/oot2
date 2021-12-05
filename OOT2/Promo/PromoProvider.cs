using System.Collections.Generic;
using OOT2.Books;

namespace OOT2.Promo
{
    public class PromoProvider : IPromoProvider
    {

        public List<IPromo> GetActivePromos(List<IBook> books)
        {
            return new List<IPromo>
            {
                new FreeEBookPromo(books)
            };
        }
    }
}