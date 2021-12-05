using OOT2.Books;

namespace OOT2.Calculation
{
    public class OrderItem
    {
        public IBook Book { get; set; }
        public decimal Discount { get; set; }
        public bool IsPromoApplied { get; set; }

        public decimal InitialPrice => Book.Price;
        public decimal FinalPrice => InitialPrice - Discount;
    }
}