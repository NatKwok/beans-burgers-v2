using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers_v2.Models.Stripe
{
    public class AddStripeCustomer
    {
        public string Email { get; set; }

        public string Name { get; set; }
        public AddStripeCard CreditCard { get; set; }
    }

}

