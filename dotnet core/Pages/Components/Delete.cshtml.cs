using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Pages.Components
{
    public class DeleteModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public DeleteModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Component Component { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Component = await _context.Component.SingleOrDefaultAsync(m => m.ComponentId == id);

            if (Component == null)
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

            Component = await _context.Component.FindAsync(id);

            if (Component != null)
            {
                _context.Component.Remove(Component);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
