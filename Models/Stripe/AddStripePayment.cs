using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers_v2.Models.Stripe
{
    public class AddStripePayment
    {
        public string CustomerId { get; set; }

        public string ReceiptEmail { get; set; }

        public string Description { get; set; }

        public string Currency { get; set; }

        public long Amount { get; set; }
    }
}