using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers.Data
{
    public class StripeOptions
    {
        public string SecretKey { get; set; }
        public string PublishableKey { get; set; }
        public string WebhookSecret { get; set; }
    }
}