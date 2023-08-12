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
    public class IndexModel : PageModel
    {
        private readonly PokedexRazorPages.Data.PokedexRazorPagesContext _context;

        public IndexModel(PokedexRazorPages.Data.PokedexRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Rating> Rating { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Rating != null)
            {
                Rating = await _context.Rating.ToListAsync();
            }
        }
    }
}
