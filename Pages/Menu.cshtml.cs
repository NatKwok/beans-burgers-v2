using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Pages
{
    public class MenuModel : PageModel
    {
        public ApplicationDbContext db;
        public MenuModel(ApplicationDbContext db) => this.db = db;

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public OrderItem addedItem { get; set; }
        
        public async Task OnGetAsync(){
            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
        }

        public async Task OnPostAsync(){
            string itemIndex = Request.Form["Order"];
            int itemInt = Int32.Parse(itemIndex);

            addedItem.MenuItem = db.MenuItems.ElementAt(itemInt);
            db.OrderItems.Add(addedItem);
        }
    }
}
