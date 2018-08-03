namespace IMS.Entities
{
    public abstract class Discount
    {
        public static Discount NoDiscountDefault = new NoDiscount();
        public abstract decimal GetDiscountMount(decimal price);
        public bool IsDefault => typeof(NoDiscount).Equals(this.GetType());
        private class NoDiscount : Discount
        {
            public override decimal GetDiscountMount(decimal price)
            {
                return price;
            }
        }
    }
}