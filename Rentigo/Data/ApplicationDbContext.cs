using Microsoft.EntityFrameworkCore;
using Rentigo.Models;

namespace Rentigo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Table « CategoriesVoitures » dans la base de données SQL Server
        public DbSet<CategoryVoiture> CategoriesVoitures { get; set; }
    }
}