using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class CustomizeModel : PageModel
    {
        private ApplicationDbContext db;
        public CustomizeModel(ApplicationDbContext db) => this.db = db;

        public int Id {get; set;}
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();  
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();  
        public MenuItem MenuItem {get; set;}
        public BunsEnum Buns {get; set;}
        public PattiesEnum Patties {get; set;}
        public List<ToppingsEnum> Toppings {get; set;}
        public CheeseEnum Cheese {get; set;}
        public SauceEnum Sauce {get; set;}

        
        public async Task OnGetAsync(){
            Ingredients = await db.Ingredients.ToListAsync();
            OrderItems = await db.OrderItems.ToListAsync();
            MenuItem = await db.MenuItems.FirstOrDefaultAsync(b => b.Id == Id);
        }

        public async Task<IActionResult> OnPostAsync(int? Id) {

            var itemtoUpdate = await db.MenuItems.FirstOrDefaultAsync(a => a.Id == Id);
            if(ModelState.IsValid) {
              itemtoUpdate.Buns = BunsEnum.Poppy_Seed;

              await db.SaveChangesAsync();
                
            }
            return Page();

                
            

           
        }

    }
}
