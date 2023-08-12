using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PokedexRazorPages.Data;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Pages.Ratings
{
    public class CreateModel : PageModel
    {
        private readonly PokedexRazorPages.Data.PokedexRazorPagesContext _context;

        public CreateModel(PokedexRazorPages.Data.PokedexRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rating Rating { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Rating == null || Rating == null)
            {
                return Page();
            }

            _context.Rating.Add(Rating);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
