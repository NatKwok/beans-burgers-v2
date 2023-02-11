using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Pages
{
    public class DeleteModel : PageModel
    {
        private ApplicationDbContext db;
        public DeleteModel(ApplicationDbContext db) => this.db = db;
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public async Task OnGetAsync(){
            OrderItem item = new OrderItem() { Id = Id };
            db.OrderItems.Remove(item);
            db.SaveChanges();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            Redirect("http://localhost:5280/Menu");
        }

        public async Task<IActionResult> OnPostAsync(){
            string itemIndex = Request.Form["Order"];
            int itemInt = Int32.Parse(itemIndex);
            MenuItem add = db.MenuItems.ToList().ElementAt(itemInt - 1);

            OrderItem cartItem = new OrderItem { CustomBurger = add.Name, BurgerPrice = (float)add.Price, Quantity = 1 };
            db.OrderItems.Add(cartItem);
            db.SaveChanges();

            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            return RedirectToPage("Menu");
        }
    }
}
