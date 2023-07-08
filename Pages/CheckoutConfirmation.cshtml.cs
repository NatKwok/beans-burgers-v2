using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.EntityFrameworkCore;

namespace BeansBurgers_v2.Pages
{
    public class CheckoutConfirmationModel : PageModel
    {
        private ApplicationDbContext db;
        public CheckoutConfirmationModel(ApplicationDbContext db) => this.db = db;
        public OrderDetails OrderDetails {get; set;} = new OrderDetails();
        public List<OrderItem> OrderItems {get; set;} = new List<OrderItem>();
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            OrderItems = await db.OrderItems.ToListAsync();
            foreach(OrderItem item in OrderItems){
                Console.WriteLine(item.CustomBurger);
            }
            OrderDetails = await db.OrdersDetails.Where(od => od.Id == id).Include(OrderDetails => OrderDetails.OrderItemsList).FirstOrDefaultAsync();
            return Page();
        }
    }
}
