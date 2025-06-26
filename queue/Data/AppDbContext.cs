using Microsoft.EntityFrameworkCore;
using queue.Entities;

namespace queue.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
    
    # region database entities
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });

        modelBuilder.Entity<OrderProduct>().HasOne(op => op.Order).WithMany(o => o.OrderProducts)
                                                                   .HasForeignKey(op => op.OrderId);
        
        base.OnModelCreating(modelBuilder);
    }
}