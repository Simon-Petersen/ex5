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
    public class IndexModel : PageModel
    {
        private readonly dotnet_core.Model.EX5Context _context;

        public IndexModel(dotnet_core.Model.EX5Context context)
        {
            _context = context;
        }

        public IList<tableJoin> tableJoin { get;set; }

        public async Task OnGetAsync()
        {
            tableJoin = await _context.tableJoin
                .Include(t => t.Category)
                .Include(t => t.ComponentType).ToListAsync();
        }
    }
}
