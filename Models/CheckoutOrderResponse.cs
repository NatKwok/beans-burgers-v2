using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeansBurgers_v2.Models
{
    public class CheckoutOrderResponse
    {
        public string? SessionId { get; set; }

        public string? PubKey { get; set; }

    }
}