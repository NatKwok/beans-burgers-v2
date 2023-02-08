using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages
{
    public class CustomizeModel : PageModel
    {
        private ApplicationDbContext db;
        public CustomizeModel(ApplicationDbContext db) => this.db = db;

        public int Id {get; set;}
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();        
        
        public async Task OnGetAsync(){
            Ingredients = await db.Ingredients.ToListAsync();
        }
    }
}
