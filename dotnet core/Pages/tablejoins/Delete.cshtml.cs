using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Pages.tablejoins
{
    public class DeleteModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public DeleteModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public tableJoin tableJoin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            tableJoin = await _context.tableJoin
                .Include(t => t.Category)
                .Include(t => t.ComponentType).SingleOrDefaultAsync(m => m.CategoryId == id);

            if (tableJoin == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            tableJoin = await _context.tableJoin.FindAsync(id);

            if (tableJoin != null)
            {
                _context.tableJoin.Remove(tableJoin);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
