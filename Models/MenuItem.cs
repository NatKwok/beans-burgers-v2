using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class MenuItem {

        [Key]
        public int ItemId {get; set;}
        public string ItemName {get; set;}
        public float ItemPrice {get; set;}
        public string ItemDescription {get; set;}

    }
}