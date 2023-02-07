using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models
{
    public class Customer 
    {

        [Key]
        public int Id {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}


    }
}