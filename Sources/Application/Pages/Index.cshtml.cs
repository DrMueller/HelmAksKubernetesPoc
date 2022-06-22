using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.Data;
using WebApplication1.DataAccess.DbContexts.Contexts.Implementation;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext _context;

        public IndexModel(WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext context)
        {
            _context = context;
        }

        public IList<Individual> Individual { get;set; }

        public async Task OnGetAsync()
        {
            Individual = await _context.Individual.ToListAsync();
        }
    }
}
