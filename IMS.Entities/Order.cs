using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Entities
{
    public class Order: ICollection<OrdenItem>
    {
        private readonly ICollection<OrdenItem> items;
        private readonly Tax tax;
        private readonly Discount discount;
        public Order(Tax tax, Discount discount)
        {
            items = new List<OrdenItem>();
            this.tax = tax;
            this.discount = discount;
        }
        public decimal TotalOrder => items.Select(f => f.TotalPrice).Sum();
        public decimal Tax => tax.GetTax(TotalOrder);
        public decimal Discount => items.Where(f => !f.HasDiscount).Select(t => t.TotalPrice).Sum();
        public decimal Total => TotalOrder + Tax;
        public int Count => items.Count;
        public int QuantityTotal => items.Select(f => f.Quantity).Sum();
        bool ICollection<OrdenItem>.IsReadOnly => items.IsReadOnly;
        public void Add(OrdenItem item) => items.Add(item);
        public bool Remove(OrdenItem item) => items.Remove(item);
        void ICollection<OrdenItem>.Clear() => items.Clear();
        bool ICollection<OrdenItem>.Contains(OrdenItem item) => items.Contains(item);
        void ICollection<OrdenItem>.CopyTo(OrdenItem[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);
        IEnumerator<OrdenItem> IEnumerable<OrdenItem>.GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
    }
}
