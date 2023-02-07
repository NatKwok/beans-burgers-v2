using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class Order {

        [Key]
        public int Id {get; set;}
        public IdentityUser Customer {get; set;}

        [Column(TypeName="money")]
        public decimal Total {get; set;}

        [Column(TypeName="money")]
        public decimal DeliveryCost {get; set;}

        [Column(TypeName="money")]
        public decimal Tax {get; set;}
        public string StripePaymentCode { get; set;} // transaction confirmation
        public ICollection<OrderItem> OrderItems {get; set;}
    }
}