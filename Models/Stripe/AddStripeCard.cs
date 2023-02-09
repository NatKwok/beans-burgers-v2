using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers_v2.Models.Stripe
{
    public class AddStripeCard
    {
        public string Name { get; set; }

        public string CardNumber { get; set; }

        public string ExpirationYear { get; set; }

        public string ExpirationMonth { get; set; }

        public string Cvc { get; set; }
    }
}