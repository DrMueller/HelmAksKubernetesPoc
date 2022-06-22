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
    public class DeleteModel : PageModel
    {
        private readonly WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext _context;

        public DeleteModel(WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Individual Individual { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Individual = await _context.Individual.FirstOrDefaultAsync(m => m.Id == id);

            if (Individual == null)
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

            Individual = await _context.Individual.FindAsync(id);

            if (Individual != null)
            {
                _context.Individual.Remove(Individual);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
