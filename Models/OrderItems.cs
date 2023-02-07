using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class OrderItems {

        [Key]
        public int Id {get; set;}
        public string Product {get; set;}
        public string CustomBurger {get; set;}
        public float BurgerPrice {get; set;}
        public int Quantity {get; set;}
        
    }
}