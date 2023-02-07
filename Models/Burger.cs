using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models
{
    public class Burger
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } // customer is expected to "name" their burger ?

        public ICollection<Ingredient> Ingredients {get; set;}

    }
}