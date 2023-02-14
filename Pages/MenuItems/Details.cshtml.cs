using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;

namespace BeansBurgers_v2.Pages_MenuItems
{
    public class DetailsModel : PageModel
    {
        private readonly BeansBurgers_v2.Data.ApplicationDbContext _context;

        public DetailsModel(BeansBurgers_v2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public MenuItem MenuItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MenuItems == null)
            {
                return NotFound();
            }

            var menuitem = await _context.MenuItems.FirstOrDefaultAsync(m => m.Id == id);
            if (menuitem == null)
            {
                return NotFound();
            }
            else 
            {
                MenuItem = menuitem;
            }
            return Page();
        }
    }
}
