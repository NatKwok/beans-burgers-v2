using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Pages
{
    public class EmployeesModel : PageModel
    {
        public int Id {get; set;}
        private ApplicationDbContext db;
        public EmployeesModel(ApplicationDbContext db) => this.db = db;
        public List<IdentityUser> Users { get; set; } = new List<IdentityUser>();

        
        public void OnGet(){
            Users = db.Users.ToList();
        }
    }
}
