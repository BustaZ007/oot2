using System;
using System.Collections.Generic;
using System.Linq;
using OOT2.Books;

namespace OOT2.Delivery
{
    public class DeliveryCalculator : IDeliveryCalculator
    {
        public decimal Calculate(List<IBook> products, DeliveryType deliveryType)
        {
            switch (deliveryType)
            {
                case DeliveryType.Delivery:
                    var hasPaperBook = products.OfType<PaperBook>().Any();
                    if (!hasPaperBook)
                        return 0;
                    var totalPrice = products
                        .Where(b => b.Type == BookType.PaperBook)
                        .Sum(b => b.Price);
                    return totalPrice < 1000  ? 200 : 0;
                case DeliveryType.Pickup:
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException(nameof(deliveryType), deliveryType, null);
            }
        }
    }
}