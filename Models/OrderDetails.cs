using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class OrderDetails {

        [Key]
        public int Id {get; set;}
        public List<OrderItem> OrderItemsList {get; set;} = new List<OrderItem>();
        public int totalItems {get; set;} =0;
        public double totalPrice {get; set;} =0;

        public double totalTax {get; set;} =0;
        public double grandTotal {get; set;} =0;

    }
}