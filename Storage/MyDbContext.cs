using Microsoft.EntityFrameworkCore;

using Project.Storage.Entity;

namespace Project.Storage
{
    public class MyDbContext:DbContext
    {

        public DbSet<Auth> Auth { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Users_With_Mailing> Users_Withs_Mailing { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Shop_Rating> Shop_Rating { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Rating> Product_Ratings { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ExampleDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder
                .Entity<Auth>()
                .HasOne(u => u.Users)
                .WithOne(p => p.Auth)
                .HasForeignKey<Users>(p => p.Auth_id);

            modelBuilder
                .Entity<Users>()
                .HasOne(u => u.Payment)
                .WithOne(p => p.Users)
                .HasForeignKey<Payment>(p => p.UserId);

            modelBuilder
                .Entity<Product>()
                .HasOne(u => u.Payment)
                .WithOne(p => p.Product)
                .HasForeignKey<Payment>(p => p.Product_id);

            modelBuilder
                .Entity<Product>()
                .HasOne(u => u.Product_Rating)
                .WithOne(p => p.Product)
                .HasForeignKey<Product_Rating>(p => p.product_id);

            modelBuilder
                .Entity<Shop>()
                .HasOne(u => u.Shop_Rating)
                .WithOne(p => p.Shop)
                .HasForeignKey<Shop_Rating>(p => p.Shop_Id);

            modelBuilder
                .Entity<Users>()
                .HasOne(u => u.Malling)
                .WithOne(p => p.Users)
                .HasForeignKey<Users_With_Mailing>(p => p.User_Id);
        }
    }

}
