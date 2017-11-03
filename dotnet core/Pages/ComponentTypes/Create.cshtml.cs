using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet_core.Model;

namespace dotnet_core.Pages.ComponentTypes
{
    public class CreateModel : PageModel
    {
    public enum ComponentTypeStatus
    {
        Available,
        ReservedAdmin
    }
        private readonly dotnet_core.Model.EX5Context _context;
      
        public CreateModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ComponentType ComponentType { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ComponentType.Add(ComponentType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}