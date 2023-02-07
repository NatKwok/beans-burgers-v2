using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Models {

    public class PaymentInfo {

        [Key]
        public int PaymentId {get; set;}
        public int CustomerId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string StreetAddress {get; set;}
        public string PostalCode {get; set;}
        public int CreditCard {get; set;}
    }
}