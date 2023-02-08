using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class Ingredient {

        [Key]
        public int Id {get; set;}
        public string Name {get; set;} // Name instead
        public string PictureURL {get; set;}
        public double ExtraCost {get; set;}
        public int Category {get; set;}

    }
}