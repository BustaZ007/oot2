using System;
using OOT2.Calculation;

namespace OOT2.PromoCodes
{
    public class SumDiscountPromoCode : IPromoCode
    {
        private readonly decimal _sum;

        public SumDiscountPromoCode(decimal sum)
        {
            _sum = sum;
        }

        public void Apply(OrderInfo orderInfo)
        {
            orderInfo.Discount += Math.Min(_sum, orderInfo.TotalPrice);
        }
    }
}