using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class MenuModel : PageModel
    {
        public int Id {get; set;}
        private ApplicationDbContext db;
        public MenuModel(ApplicationDbContext db) => this.db = db;
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); 
        public MenuItem MenuItem {get; set;}

        
        public async Task OnGetAsync(){
            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            MenuItem = await db.MenuItems.FindAsync(Id);
        }

        public async Task<IActionResult> OnPostAsync(){
            Console.WriteLine("Post");
            string itemIndex = Request.Form["Order"];
            int itemInt = Int32.Parse(itemIndex);
            MenuItem add = db.MenuItems.ToList().ElementAt(itemInt - 1);

            OrderItem cartItem = new OrderItem { CustomBurger = add.Name, BurgerPrice = (float)add.Price, Quantity = 1 };
            db.OrderItems.Add(cartItem);
            db.SaveChanges();

            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            return Page();
        }
    }

}
