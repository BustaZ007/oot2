using System.Collections.Generic;
using OOT2.Books;

namespace OOT2.Delivery
{
    public interface IDeliveryCalculator
    {
        decimal Calculate(List<IBook> products, DeliveryType deliveryType);
    }
}