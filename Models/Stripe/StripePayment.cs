using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BeansBurgers_v2.Models.Stripe
{
    public class StripePayment
    {
        [Key]
        public string CustomerId { get; set; }
        public string ReceiptEmail { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public long Amount { get; set; }
        public string PaymentId { get; set; }

        public StripePayment(string customerId, string receiptEmail, string description, string currency, long amount, string paymentId)
        {
            CustomerId = customerId;
            ReceiptEmail = receiptEmail;
            Description = description;
            Currency = currency;
            Amount = amount;
            PaymentId = paymentId;
        }
    }
}