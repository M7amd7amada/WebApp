namespace WebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Product>? Products => Set<Product>();
    public DbSet<Category>? Categories => Set<Category>();
    public DbSet<Supplier>? Suppliers => Set<Supplier>();
}