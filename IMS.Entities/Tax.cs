namespace IMS.Entities
{
    public abstract class Tax
    {
        public abstract decimal GetTax(decimal TotalPrice);
    }
}