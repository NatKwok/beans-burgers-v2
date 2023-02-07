using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class Address {

        [Key]
        public int AddressId {get; set;}
        public int CustomerId {get; set;}
        public string StreetAddress {get; set;}

    }
}