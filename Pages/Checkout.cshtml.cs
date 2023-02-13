using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;

namespace BeansBurgers_v2.Pages
{
    public class CheckoutModel : PageModel
    {
        private ApplicationDbContext db;
        public CheckoutModel(ApplicationDbContext db) => this.db = db;
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        public async Task<IActionResult> OnGetAsync(){
            double price = 0;

            return RedirectToPage("Menu");
        }
    }
}
