using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet_core.Model;

namespace dotnet_core.Pages.tablejoins
{
    public class CreateModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public CreateModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryId");
        ViewData["ComponentTypeId"] = new SelectList(_context.ComponentType, "ComponentTypeId", "ComponentTypeId");
            return Page();
        }

        [BindProperty]
        public tableJoin tableJoin { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.tableJoin.Add(tableJoin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}