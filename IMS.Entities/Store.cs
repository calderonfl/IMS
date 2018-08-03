using System;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Entities
{
    public class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Inventory Inventory { get; set; }
    }
}
