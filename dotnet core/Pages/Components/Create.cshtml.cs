using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet_core.Model;

namespace dotnet_core.Pages.Components
{
    public class CreateModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;
        public SelectList ComponentTypes;
        public CreateModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var temp = _context.ComponentType.ToList();
            this.ComponentTypes = new SelectList(temp, "ComponentTypeId", "ComponentName");
            return Page();
        }

        [BindProperty]
        public Component Component { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Component.Add(Component);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}