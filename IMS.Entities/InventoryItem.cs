namespace IMS.Entities
{
    public class InventoryItem
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
    }
}
