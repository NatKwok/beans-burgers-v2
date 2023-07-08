using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BeansBurgers_v2.Models;
using BeansBurgers_v2.Data;
using Microsoft.AspNetCore.Identity;

namespace BeansBurgers_v2.Pages
{
    public class EditEmployeeModel : PageModel
    {
        private ApplicationDbContext db;
        public EditEmployeeModel(ApplicationDbContext db) => this.db = db;
        public List<IdentityUser> Users { get; set; } = new List<IdentityUser>();
        
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }

        public void OnGet(){
            Users = db.Users.ToList();
        }

        public async Task<IActionResult> OnPostAsync(){
            string username = Request.Form["username"];
            string phone = Request.Form["phone"];
            string email = Request.Form["email"];

            Users = db.Users.ToList();
            foreach(IdentityUser user in Users){
                if(user.Id == Id){
                    user.Email = email;
                    user.PhoneNumber = phone;
                    user.UserName = username;
                }
            }
            db.SaveChanges();
            return RedirectToPage("Employees");
        }
    }
}

