using OOT2.Calculation;

namespace OOT2.PromoCodes
{
    public interface IPromoCode
    {
        void Apply(OrderInfo orderInfo);
    }
}