using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokedexRazorPages.Models;

namespace PokedexRazorPages.Data
{
    public class PokedexRazorPagesContext : DbContext
    {
        public PokedexRazorPagesContext (DbContextOptions<PokedexRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<PokedexRazorPages.Models.Rating> Rating { get; set; } = default!;
    }
}
