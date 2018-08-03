using System.Collections.Generic;

namespace IMS.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products{get;}
    }
}
