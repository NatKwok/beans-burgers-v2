using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models
{

    public class MenuItem
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        //public ICollection<Ingredient> Ingredients {get; set;}

        // enum Category { Dish Side, Burger, Drink Other}
    }
    public enum BunsEnum
    {
        [Display(Name = "Brioche")]
        Brioche = 0,
        [Display(Name = "Ciabatta")]
        Ciabatta = 1,
        [Display(Name = "Sesame Seed")]
        Sesame_Seed = 2,
        [Display(Name = "Poppy Seed")]
        Poppy_Seed = 3,

    }

    public enum PattiesEnum
    {
        Angus = 0,
        Fried_Chicken = 1,
        Fish_Cake = 2,
        Bison = 3,
        Beyond_Meat = 4,
        Portobello = 5
    }

    public enum ToppingsEnum
    {
        Lettuce = 0,
        Tomatoes = 1,
        Pickles = 2,
        Red_Onions = 3,
        Caramelized_Onions = 4,
        Mushrooms = 5,
        Banana_Peppers = 6

    }

    public enum CheeseEnum
    {
        Cheddar = 0,
        Jalepeno_Monterey_Jack = 1,
        Swiss = 2,
        Goat_Cheese = 3
    }

    public enum SauceEnum
    {
        Ketchup = 0,
        Mustard = 1,
        Relish = 2,
        Mayo = 3,
        Spicy_Mayo = 4,
        Tartar_Sauce = 5,
        BBQ = 6,
        Pico_de_Gallo = 7,
        Guacamole = 8
    }
}