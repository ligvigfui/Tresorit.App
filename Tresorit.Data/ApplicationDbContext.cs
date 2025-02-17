using Microsoft.EntityFrameworkCore;
using Tresorit.Data.DataBaseModels;

namespace Tresorit.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        base.OnConfiguring(optionsBuilder);
    }

}
