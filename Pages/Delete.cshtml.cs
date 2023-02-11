using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeansBurgers_v2.Pages
{
    public class DeleteModel : PageModel
    {
        private ApplicationDbContext db;
        public DeleteModel(ApplicationDbContext db) => this.db = db;

        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public async Task OnGetAsync(){
            OrderItem item = new OrderItem() { Id = Id };
            db.OrderItems.Remove(item);
            db.SaveChanges();
            LocalRedirect("/Menu");
        }
    }
}
