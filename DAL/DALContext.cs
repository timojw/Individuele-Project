using Microsoft.EntityFrameworkCore;
using DAL_Layer.Model;

namespace DAL_Layer
{
    public class DALContext : DbContext
    {
        public DALContext(DbContextOptions<DALContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            //modelBuilder.Entity<OrderProduct>().ToTable("OrderProducts");

            //modelBuilder.Entity<Order>()
            //    .HasMany(x => x.Products)
            //    .WithOne(x => x.Event);
        }

    }
}