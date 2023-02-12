using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace BeansBurgers_v2.Pages
{
    public class CustomizeModel : PageModel
    {
        private ApplicationDbContext _db;
        // public CustomizeModel(ApplicationDbContext db) => this.db = db;

        public int Id {get; set;}
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        // public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();  
        public MenuItem MenuItem {get; set;}
        public BunsEnum Buns {get; set;}
        public PattiesEnum Patties {get; set;}
        public CheeseEnum Cheese {get; set;}
        public SauceEnum Sauce {get; set;}
        public ToppingsEnum Toppings {get; set;}

        public CustomizeModel(ApplicationDbContext db)  
        {  
            _db = db;  
        }
        
        public async Task OnGet(int? id) {

            MenuItem = await _db.MenuItems.FindAsync(id);
            Console.WriteLine(MenuItem.Name);
            
        }

        public async Task<IActionResult> OnPostAsync(int id) {

            MenuItem itemfromDB = await _db.MenuItems.FindAsync(id);
    Console.WriteLine(itemfromDB.Name);
    Console.WriteLine(MenuItem.Id);
                itemfromDB.Buns = MenuItem.Buns;
                itemfromDB.Patties = MenuItem.Patties;
                itemfromDB.Sauces = MenuItem.Sauces;
                itemfromDB.Toppings = MenuItem.Toppings;
                await _db.SaveChangesAsync();
                return RedirectToPage("Menu");
                

                return Page();
            
            

                
            

           
        }

    }
}
