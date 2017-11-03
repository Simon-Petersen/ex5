using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet_core.Model;

namespace dotnet_core.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public IndexModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
