using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeansBurgers_v2.Models.Stripe;

namespace BeansBurgers_v2.Contracts
{
    public interface IStripeAppService
    {
        Task<StripeCustomer> AddStripeCustomerAsync(AddStripeCustomer customer, CancellationToken ct);
        Task<StripePayment> AddStripePaymentAsync(AddStripePayment payment, CancellationToken ct);
    }
}