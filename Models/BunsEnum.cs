using System.ComponentModel.DataAnnotations;

namespace BeansBurgers_v2.Pages
{
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
}