using System.Collections.Generic;
using System.Linq;
using OOT2.Books;
using OOT2.Delivery;
using OOT2.Promo;
using OOT2.PromoCodes;

namespace OOT2.Calculation
{
    public class Cart
    {
        private readonly IDeliveryCalculator _deliveryCalculator;
        private readonly IPromoProvider _promoProvider;

        public Cart(IDeliveryCalculator deliveryCalculator, IPromoProvider promoProvider)
        {
            _deliveryCalculator = deliveryCalculator;
            _promoProvider = promoProvider;
        }

        public OrderInfo GetOrderInfo(List<IBook> books, DeliveryType deliveryType, IPromoCode promoCode, List<IBook> allBooks)
        {
            var orderInfo = new OrderInfo
            {
                Items = books.Select(b => new OrderItem {Book = b}).ToList(),
                DeliveryPrice = _deliveryCalculator.Calculate(books,
                    deliveryType)
            };

            promoCode?.Apply(orderInfo);
            _promoProvider.GetActivePromos(allBooks).ForEach(p => p.Apply(orderInfo));

            return orderInfo;
        }
    }
}