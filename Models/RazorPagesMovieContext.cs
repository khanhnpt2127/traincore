using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;


namespace RazorPagesMovie.Models
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movies> Movie { get; set; }
        
    }
}