using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Pages
{
    public class MenuModel : PageModel
    {
        private ApplicationDbContext db;
        public MenuModel(ApplicationDbContext db) => this.db = db;

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        
        public async Task OnGetAsync(){
            Ingredients = await db.Ingredients.ToListAsync();
            MenuItems = await db.MenuItems.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
        }
    }
}
