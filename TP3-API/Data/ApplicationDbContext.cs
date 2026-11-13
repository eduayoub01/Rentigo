using Microsoft.EntityFrameworkCore;
using TP3_API.Model;

namespace TP3_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CategoryVoiture> CategoriesVoitures { get; set; }

        public DbSet<Voiture> Voitures { get; set; }
    }
}
