using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Entities
{
    public class Bill
    {
        public int NumberBill { get; set; }
        public string Description { get; set; }
        public Issuing Issuing { get; set; }
        public Receiver Receiver { get; set; }
        public Order Order { get; set; }
        public bool IsCardPayment { get; set; }
        public int CardPaymentNumber { get; }
    }
}
