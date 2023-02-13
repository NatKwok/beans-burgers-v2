using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class CheckoutModel : PageModel
    {
        private ApplicationDbContext db;
        public string Id { get; set; }
        public CheckoutModel(ApplicationDbContext db) => this.db = db;
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        public OrderItem OrderItem { get; set;}
        public async Task OnGetAsync(){
            Console.WriteLine("AsyncFunction");
            OrderItems = await db.OrderItems.ToListAsync();
            //double price = 0;


            // return RedirectToPage("Menu");
        }

        public async Task<IActionResult> OnPostAsync() {

            OrderItem = await db.OrderItems.FindAsync(Id);

            var body = $@"<p>Item Name: {OrderItem.CustomBurger} 
                        <br>Price: ${OrderItem.BurgerPrice}
                        <br>Quantity: {OrderItem.Quantity} 
                        <br>Description: {OrderItem.Description}
                            </p>";
            
            for(int i = 0; i < db.OrderItems.ToList().Count(); i++) {
                //For each OrderItem, write the var body
            }
            return RedirectToPage("Index");
        }
    }
}
