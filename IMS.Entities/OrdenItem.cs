using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Entities
{
    public class OrdenItem
    {
        private Discount discount;
        public OrdenItem() : this(Discount.NoDiscountDefault)
        {
            
        }

        public OrdenItem(Discount discount)
        {
            this.discount = discount;
        }

        public string Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public bool HasDiscount => !discount.IsDefault;
        public decimal TotalPrice
        {
            get
            {
                return discount.GetDiscountMount(Product.Price) * Quantity;
            }
        }
    }
}
