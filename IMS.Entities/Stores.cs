using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IMS.Entities
{
    public class Stores : ICollection<Store>
    {
        private readonly ICollection<Store> stores;

        public Stores() : this(new List<Store>())
        {

        }
        public Stores(IEnumerable<Store> categories)
        {
            this.stores = new List<Store>(categories);
        }
        public int Count => stores.Count;
        public void Add(Store item)
        {
            stores.Add(item);
        }
        bool ICollection<Store>.IsReadOnly => stores.IsReadOnly;
        public Store this[string Id] { get => stores.Where(f => f.Id == Id).FirstOrDefault(); }
        void ICollection<Store>.Clear() => stores.Clear();
        bool ICollection<Store>.Contains(Store item) => stores.Contains(item);
        void ICollection<Store>.CopyTo(Store[] array, int arrayIndex) => stores.CopyTo(array, arrayIndex);
        IEnumerator<Store> IEnumerable<Store>.GetEnumerator() => stores.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => stores.GetEnumerator();
        bool ICollection<Store>.Remove(Store item) => stores.Remove(item);
    }
}
