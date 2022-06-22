using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.DataAccess.Data;
using WebApplication1.DataAccess.DbContexts.Contexts.Implementation;

namespace WebApplication1.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext _context;

        public CreateModel(WebApplication1.DataAccess.DbContexts.Contexts.Implementation.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Individual Individual { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Individual.Add(Individual);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
