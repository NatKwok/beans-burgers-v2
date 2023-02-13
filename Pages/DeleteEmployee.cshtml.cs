using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Pages
{
    public class DeleteEmployeeModel : PageModel
    {
        private ApplicationDbContext db;
        public DeleteEmployeeModel(ApplicationDbContext db) => this.db = db;
        public List<IdentityUser> Users { get; set; } = new List<IdentityUser>();
        
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }

        public async Task<IActionResult> OnGetAsync(){
            IdentityUser person = new IdentityUser() { Id = Id };
            db.Users.Remove(person);
            db.SaveChanges();
            return RedirectToPage("Employees");
        }
    }
}
