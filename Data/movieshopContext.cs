using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace movieshop.Models
{
    public class movieshopContext : DbContext
    {
        public movieshopContext (DbContextOptions<movieshopContext> options)
            : base(options)
        {
        }

        public DbSet<movieshop.Models.Movie> Movie { get; set; }
    }
}
