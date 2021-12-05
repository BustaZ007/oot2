using System.Collections.Generic;
using OOT2.Books;

namespace OOT2.Promo
{
    public interface IPromoProvider
    {
        List<IPromo> GetActivePromos(List<IBook> books);
    }
}