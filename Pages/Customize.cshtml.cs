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

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        // public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); 
        [BindProperty]
        public OrderItem OrderItem { get; set; }


        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }

        [BindProperty]
        public int ItemId { get; set; }
        public string ItemName { get; set; }


        public CustomizeModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task OnGetAsync(int? id)
        {

            OrderItems = await _db.OrderItems.ToListAsync();
            OrderItem = await _db.OrderItems.Where(i => i.Id == id).Include(oi => oi.MenuItem).FirstOrDefaultAsync();
            ItemName = OrderItem.MenuItem.Name;
            ItemId = OrderItem.MenuItem.Id;
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
            MenuItem mi = _db.MenuItems.Where(i => i.Id == ItemId).FirstOrDefault();

            OrderItem.MenuItem = mi;


            _db.OrderItems.Update(OrderItem);
            await _db.SaveChangesAsync();

            return RedirectToPage("Menu");
            //return RedirectToPage("Delete", new { id = OrderItem.Id });
            return Page();

            


        }

    }
}
