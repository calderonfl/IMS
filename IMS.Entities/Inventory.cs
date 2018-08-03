using System.Collections;
using System.Collections.Generic;

namespace IMS.Entities
{
    public class Inventory : ICollection<InventoryItem>
    {
        private readonly ICollection<InventoryItem> items;

        public Inventory() : this(new List<InventoryItem>())
        {

        }
        public Inventory(IEnumerable<InventoryItem> items)
        {
            this.items = new List<InventoryItem>(items);
        }
        public int Count => items.Count;
        bool ICollection<InventoryItem>.IsReadOnly => items.IsReadOnly;
        public void Add(InventoryItem item) => items.Add(item);
        void ICollection<InventoryItem>.Clear() => items.Clear();
        bool ICollection<InventoryItem>.Contains(InventoryItem item) => items.Contains(item);
        void ICollection<InventoryItem>.CopyTo(InventoryItem[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);
        IEnumerator<InventoryItem> IEnumerable<InventoryItem>.GetEnumerator() => items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => items.GetEnumerator();
        bool ICollection<InventoryItem>.Remove(InventoryItem item) => items.Remove(item);
        public Store Store { get; set; }
    }
}
