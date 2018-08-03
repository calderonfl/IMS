using System.Collections;
using System.Collections.Generic;

namespace IMS.Entities
{
    public class Products : ICollection<Product>
    {
        private readonly ICollection<Product> products;

        public Products() : this(new List<Product>())
        {
        }
        public Products(ICollection<Product> products)
        {
            this.products = products;
        }
        public int Count => products.Count;
        bool ICollection<Product>.IsReadOnly => products.IsReadOnly;
        public void Add(Product item) => products.Add(item);
        void ICollection<Product>.Clear() => products.Clear();
        bool ICollection<Product>.Contains(Product item) => products.Contains(item);
        void ICollection<Product>.CopyTo(Product[] array, int arrayIndex) => products.CopyTo(array, arrayIndex);
        IEnumerator<Product> IEnumerable<Product>.GetEnumerator() => products.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => products.GetEnumerator();
        bool ICollection<Product>.Remove(Product item) => products.Remove(item);
    }
}
