using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe.Checkout;
using BeansBurgers_v2.Models;

namespace BeansBurgers_v2.Controllers
{
    [Route("BeansBurgers_v2/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {

        //private readonly StripeSettings _stripeSettings;
        public PaymentsController()
        {
            StripeConfiguration.ApiKey = "sk_test_51MXtruBCj4yzLlBMzVnhRYadCL6qvKi3m6CTFaNOYKDl0LFikOBiFOrOdpUwCGWyzdURIHC9VXGWlaZFbM9UpMpp00un7giNCn";
        }



        [HttpPost("create-checkout-session")]
        public async Task<IActionResult> CreateCheckoutSession([FromBody] CreateCheckoutSessionRequest req)
        {
            Console.WriteLine("Creating checkout session");

            var options = new SessionCreateOptions
            {
                SuccessUrl = req.SuccessUrl,
                CancelUrl = req.FailureUrl,
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                Mode = "payment",
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        Price = req.PriceId,
                        Quantity = 1,
                    },
                },
            };

            var service = new SessionService();
            service.Create(options);
            try
            {
                var session = await service.CreateAsync(options);
                return Ok(new CreateCheckoutSessionResponse
                {
                    SessionId = session.Id,
                    PublicKey = "pk_test_51MXtruBCj4yzLlBMZMupybulAVopdVNQ8LjLKwALGQVflkxoOXSrIz5itOZEQZ0OY2gfPnNxs48xhEAvV1jYFmfF00gclYWJVs"
                });
            }
            catch (StripeException e)
            {
                Console.WriteLine(e.StripeError.Message);
                return BadRequest(new ErrorResponse
                {
                    ErrorMessage = new ErrorMessage
                    {
                        Message = e.StripeError.Message,
                    }
                });
            }

        }


        //[HttpPost("cutomer-poral")]
        //public IActionResult CustomerPortal([FromBody] CustomerPortalRequest req)
        //{
        //    return Ok();
        //}

    }
}