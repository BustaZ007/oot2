using OOT2.Calculation;

namespace OOT2.PromoCodes
{
    public class FreeDeliveryPromoCode : IPromoCode
    {
        public void Apply(OrderInfo orderInfo)
        {
            orderInfo.Discount += orderInfo.DeliveryPrice;
        }
    }
}