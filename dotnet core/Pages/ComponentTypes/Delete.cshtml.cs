using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Pages.ComponentTypes
{
    public class DeleteModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public DeleteModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public ComponentType ComponentType { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ComponentType = await _context.ComponentType.SingleOrDefaultAsync(m => m.ComponentTypeId == id);

            if (ComponentType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ComponentType = await _context.ComponentType.FindAsync(id);

            if (ComponentType != null)
            {
                _context.ComponentType.Remove(ComponentType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
