using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IMS.Entities
{
    public class Categories : ICollection<Category>
    {
        private readonly ICollection<Category> categories;
        public Categories():this(new List<Category>())
        {

        }
        public Categories(IEnumerable<Category> categories)
        {
            this.categories = new List<Category>(categories);
        }
        public int Count => categories.Count;
        public void Add(Category item)
        {
            categories.Add(item);
        }
        bool ICollection<Category>.IsReadOnly => categories.IsReadOnly;
        public Category this[string Id] { get => categories.Where(f => f.Id == Id).FirstOrDefault(); }
        void ICollection<Category>.Clear() => categories.Clear();
        bool ICollection<Category>.Contains(Category item) => categories.Contains(item);
        void ICollection<Category>.CopyTo(Category[] array, int arrayIndex) => categories.CopyTo(array, arrayIndex);
        IEnumerator<Category> IEnumerable<Category>.GetEnumerator() => categories.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => categories.GetEnumerator();
        bool ICollection<Category>.Remove(Category item) => categories.Remove(item);
    }
}
