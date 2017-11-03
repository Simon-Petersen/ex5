using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Pages.tablejoins
{
    public class EditModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public EditModel(dotnet_core.Model.EX5Context context)
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
           ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId");
           ViewData["ComponentTypeId"] = new SelectList(_context.ComponentType, "ComponentTypeId", "ComponentTypeId");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(tableJoin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
            }

            return RedirectToPage("./Index");
        }
    }
}
