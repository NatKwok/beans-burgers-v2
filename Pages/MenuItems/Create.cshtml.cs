using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Authorization;

namespace BeansBurgers_v2.Pages_MenuItems
{
    [Authorize(Roles = "admin")]
    public class CreateModel : PageModel
    {
        private readonly BeansBurgers_v2.Data.ApplicationDbContext _context;

        public CreateModel(BeansBurgers_v2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MenuItem MenuItem { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MenuItems.Add(MenuItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
