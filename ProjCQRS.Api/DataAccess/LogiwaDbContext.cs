namespace ProjCQRS.Api.DataAccess
{
    using ProjCQRS.Api.Entity;
    using Microsoft.EntityFrameworkCore;

    public class ProjCQRSDbContext: DbContext
    {
        public ProjCQRSDbContext(DbContextOptions<ProjCQRSDbContext>options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne<Category>(s => s.Category)
                .WithMany(ad => ad.Products);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
