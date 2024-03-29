using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models
{

    public class OrderItem
    {

        [Key]
        public int Id { get; set; }
        //public string Product {get; set;}
        public MenuItem MenuItem { get; set; } // NULL of custom burger is used

        public string CustomBurger { get; set; }
        public float BurgerPrice { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public BunsEnum Bun { get; set; }
        public PattiesEnum Pattie { get; set; }
        public ToppingsEnum Topping { get; set; }
        public SauceEnum Sauce { get; set; }
        public CheeseEnum Cheese { get; set; }

    }
}