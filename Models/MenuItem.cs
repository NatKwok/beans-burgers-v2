using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class MenuItem {

        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public double Price {get; set;}
        //public string Description {get; set;}
        public ICollection<Ingredient> Ingredients {get; set;}

        // enum Category { Dish Side, Burger, Drink Other}

    }
}