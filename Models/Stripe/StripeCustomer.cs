using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers_v2.Models.Stripe
{
    public class StripeCustomer
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CustomerId { get; set; }

        public StripeCustomer(string name, string email, string customerId)
        {
            Name = name;
            Email = email;
            CustomerId = customerId;
        }
    }
}