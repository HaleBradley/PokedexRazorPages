using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexRazorPages.Data;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Pages.Ratings
{
    public class EditModel : PageModel
    {
        private readonly PokedexRazorPages.Data.PokedexRazorPagesContext _context;

        public EditModel(PokedexRazorPages.Data.PokedexRazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rating Rating { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rating == null)
            {
                return NotFound();
            }

            var rating =  await _context.Rating.FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }
            Rating = rating;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RatingExists(Rating.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RatingExists(int id)
        {
          return (_context.Rating?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
