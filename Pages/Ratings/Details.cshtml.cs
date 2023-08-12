using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokedexRazorPages.Data;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Pages.Ratings
{
    public class DetailsModel : PageModel
    {
        private readonly PokedexRazorPages.Data.PokedexRazorPagesContext _context;

        public DetailsModel(PokedexRazorPages.Data.PokedexRazorPagesContext context)
        {
            _context = context;
        }

      public Rating Rating { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Rating == null)
            {
                return NotFound();
            }

            var rating = await _context.Rating.FirstOrDefaultAsync(m => m.Id == id);
            if (rating == null)
            {
                return NotFound();
            }
            else 
            {
                Rating = rating;
            }
            return Page();
        }
    }
}
