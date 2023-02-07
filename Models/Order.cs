using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class Order {

        [Key]
        public int OrderId {get; set;}
        public int CustomerId {get; set;}
        public int PaymentInfoId {get; set;}
        public int AddressId {get; set;}
        public float Subtotal {get; set;}
        public float Tax {get; set;}
        public float Total {get; set;}
        public string ItemList {get; set;}
    }
}