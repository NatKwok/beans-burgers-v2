using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class Ingredient {

        [Key]
        public int Id {get; set;}
        public string Type {get; set;}
        public string Description {get; set;}
        public string PictureURL {get; set;}
        public double ExtraCost {get; set;}
        public string Category {get; set;}

    }
}