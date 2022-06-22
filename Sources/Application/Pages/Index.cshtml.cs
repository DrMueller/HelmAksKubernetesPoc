using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataAccess.Data;
using WebApplication1.DataAccess.DbContexts;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
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
