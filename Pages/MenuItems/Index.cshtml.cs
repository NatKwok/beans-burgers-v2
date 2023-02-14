using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeansBurgers_v2.Data;
using BeansBurgers_v2.Models;
using Microsoft.AspNetCore.Authorization;

namespace BeansBurgers_v2.Pages_MenuItems
{
    [Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {
        private readonly BeansBurgers_v2.Data.ApplicationDbContext _context;

        public IndexModel(BeansBurgers_v2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MenuItems != null)
            {
                MenuItem = await _context.MenuItems.ToListAsync();
            }
        }
    }
}
